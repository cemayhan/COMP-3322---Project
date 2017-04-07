using System;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using System.Configuration;

public partial class view : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataBounds();

            
        }
    }

    private void DataBounds()
    {
        string config = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
        using(MySqlConnection cn = new MySqlConnection(config))
        {
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT unitname FROM unitnames", cn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                DropDownList2.DataSource = dt;
                DropDownList2.DataTextField = "unitname";
                DropDownList2.DataValueField = "unitname";
                DropDownList2.DataBind();
            }
        }
    }

    private DataTable GetData(string s)
    {

        string config = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
        MySqlConnection con = new MySqlConnection(config);
        con = new MySql.Data.MySqlClient.MySqlConnection();
        con.ConnectionString = config;
        con.Open();

        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM "+s+"",con))
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string config = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
        MySqlConnection con = new MySqlConnection(config);
        con = new MySql.Data.MySqlClient.MySqlConnection();
        con.ConnectionString = config;
        
        string s = DropDownList1.SelectedItem.Text;
        string text = DropDownList2.SelectedItem.Text;

        MySqlCommand cmd2 = new MySqlCommand("DELETE FROM "+s+" WHERE "+text+" IS NULL", con);
        con.Open();
        cmd2.ExecuteNonQuery();
        con.Close();
    }

    /*
     * sonra gelecegiz buraya
     * 
    protected void Button2_Click(object sender, EventArgs e)
    {
        string config = "server=localhost;uid=root;password=root;database=data2;";
        MySqlConnection con = new MySqlConnection(config);
        con = new MySql.Data.MySqlClient.MySqlConnection();
        con.ConnectionString = config;

        string num1 = droplist.SelectedValue;

        MySqlCommand cmd = new MySqlCommand("DELETE ID FROM kullanici WHERE studentname = '" + num1 + "'", con);

        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        Response.Redirect("view.aspx");
    }
    */

    protected void showtable()
    {
        string s = DropDownList1.SelectedItem.Text;
        Response.Write("<br /><br /><br />");
        //Populating a DataTable from database.
        DataTable dt = this.GetData(s);

        //Building an HTML string.
        StringBuilder html = new StringBuilder();

        //Table start.
        html.Append("<table border = '1'>");

        //Building the Header row.
        html.Append("<tr>");
        foreach (DataColumn column in dt.Columns)
        {
            html.Append("<th>");
            html.Append(column.ColumnName);
            html.Append("</th>");
        }
        html.Append("</tr>");

        //Building the Data rows.
        foreach (DataRow row in dt.Rows)
        {
            html.Append("<tr>");
            foreach (DataColumn column in dt.Columns)
            {
                html.Append("<td>");
                html.Append(row[column.ColumnName]);
                html.Append("</td>");
            }
            html.Append("</tr>");
        }

        //Table end.
        html.Append("</table>");

        //Append the HTML string to Placeholder.
        PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        showtable();
    }
}