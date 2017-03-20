using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie myCookie = new HttpCookie("speaknlearn.com");
        myCookie = Request.Cookies["speaknlearn.com"];
        string user = null;
        string ssid = null;
        if (myCookie != null)
        {
            user = myCookie["username"];
            ssid = myCookie["sessionid"];
        }

        else
        {
            Response.Redirect("login.aspx");
        }

        Label1.Text = "<h3>WELCOME " + user + ",</h3>";

        string config = ConfigurationManager.ConnectionStrings["unitnamedata2"].ConnectionString;
        MySqlConnection con2 = new MySqlConnection(config);
        con2 = new MySql.Data.MySqlClient.MySqlConnection();
        con2.ConnectionString = config;
        string sql2 = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'data2' AND TABLE_NAME = 'unitnames'";
        MySqlCommand cmd2 = new MySqlCommand(sql2, con2);
        con2.Open();
        string count2 = cmd2.ExecuteScalar().ToString();
        con2.Close();


        string config2 = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
        MySqlConnection con3 = new MySqlConnection(config2);
        con3 = new MySql.Data.MySqlClient.MySqlConnection();
        con3.ConnectionString = config2;

        string sql3 = "SELECT * from unitnames";
        MySqlCommand cmd3 = new MySqlCommand(sql3, con3);
        con3.Open();
        cmd3.ExecuteNonQuery();

        int count = int.Parse(count2);

        MySqlDataAdapter dt = new MySqlDataAdapter(cmd3);
        DataSet ds = new DataSet();

        int i = 0;

        dt.Fill(ds);
        string[] str = new string[count];

        foreach (DataRow row in ds.Tables[0].Rows)
        {
            str[i] = row["unitname"].ToString();
            i++;
        }

        dt.Dispose();
        con3.Close();

        for(int j=0; j<count; j++)
        {
            string odev = "<h2><b>Unit - " + (j+1) + "</b></h2>";
            HyperLink odevlink = new HyperLink();
            odevlink.Text = odev;
            odevlink.NavigateUrl = "exercises.aspx?unit=" + str[j];
            
            Panel1.Controls.Add(odevlink);
            Panel1.Controls.Add(new LiteralControl("<br />"));
        }
    }
}