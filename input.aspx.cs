using System;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Configuration;
using System.Globalization;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Web.UI;

public partial class input : System.Web.UI.Page
{
    List<TextBox> results;

    private List<string> TextBoxIdCollection
    {
        get
        {
            var collection = ViewState["TextBoxIdCollection"] as List<string>;
            return collection ?? new List<string>();
        }
        set { ViewState["TextBoxIdCollection"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        foreach (string textboxId in TextBoxIdCollection)
        {
            var textbox = new TextBox { ID = textboxId };
            form1.Controls.Add(textbox);
        }
    }

    protected void Sorular_Click(object sender, EventArgs e)
    {
        var collection = new List<string>();

        int num;
        int.TryParse(Q7.Text, out num);
        TableRow trow = new TableRow();
        TableCell tcell = new TableCell();


        for (int i = 0; i < num; i++)
        {
            if (i % 2 == 0)
            {
                trow = new TableRow();
                tcell = new TableCell();
                sorutable.Rows.Add(trow);
                trow.Cells.Add(tcell);

                Label lbl = new Label();
                lbl.Text = "Question " + (i + 1) + "   :";
                lbl.Attributes.Add("Style", "font-size:large;font-color:green");
                tcell.Controls.Add(lbl);

                TextBox txt = new TextBox();
                txt.ID = "TextBox" + (i + 1);
                collection.Add(txt.ID);


                txt.Text = "";
                txt.Attributes.Add("Style", "Width:350px; Height:50px; BorderColor:blue;");
                tcell.Controls.Add(txt);
                Label lbl2 = new Label();
                lbl2.Text = "<br />";
                lbl2.Visible = false;


            }
            else
            {
                tcell = new TableCell();
                trow.Cells.Add(tcell);

                Label lbl = new Label();
                lbl.Text = "Question " + (i + 1) + "   :";
                lbl.Attributes.Add("Style", "font-size:large;font-color:green");
                tcell.Controls.Add(lbl);

                TextBox txt = new TextBox();
                txt.ID = "TextBox" + (i + 1);
                collection.Add(txt.ID);
                txt.Text = "";
                txt.Attributes.Add("Style", "Width:350px; Height:50px; BorderColor:blue;");
                tcell.Controls.Add(txt);

                Label lbl2 = new Label();
                lbl2.Text = "<br />";
                lbl2.Visible = false;


            }
        }

        TextBoxIdCollection = collection;
        Q7.Text = num.ToString();
        UnitName.Text = UnitName.Text;
        DueDate.Text = DueDate.Text;
    }


    protected void Submit_Click(object sender, EventArgs e)
    {
        int num;
        int.TryParse(Q7.Text, out num);
        string[] si = new string[num];


        int i = 1;
        foreach (Control x in form1.Controls)
        {
            if (x is TextBox)
            {

                if (x.ID.Contains("TextBox"))
                {
                    si[i - 1] = ((TextBox)x).Text;
                    i++;
                }
            }
        }



        Response.Write(si.Length);
        Response.Write("<br />");
        for(int k = 0; k < si.Length; k++)
        {
            Response.Write(si[k]);
        }



        string config = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
        MySqlConnection con = new MySqlConnection(config);
        con = new MySql.Data.MySqlClient.MySqlConnection();
        con.ConnectionString = config;

        string unitname = UnitName.Text;

        //creating column unitname
        MySqlCommand cmd = new MySqlCommand("ALTER TABLE questions ADD " + unitname + " CHAR(128) COLLATE utf8_unicode_ci NOT NULL AFTER ID", con);
        con.Open();
        cmd.ExecuteNonQuery();

        //inserting data into unitnames table (unitname, duedate, submitdate)
        cmd = new MySqlCommand("INSERT INTO unitnames(unitname,duedate,submitdate) VALUES (@Unitname,@Duedate,@Submitdate)", con);
        cmd.Parameters.AddWithValue("@Unitname", unitname);
        DateTime submitdate = DateTime.Now;
        DateTime duedate = DateTime.ParseExact(DueDate.Text, "MM-dd-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        cmd.Parameters.AddWithValue("@Duedate", duedate);
        cmd.Parameters.AddWithValue("@Submitdate", submitdate);
        cmd.ExecuteNonQuery();

        //adding unitname into scores table
        cmd = new MySqlCommand("ALTER TABLE scores ADD " + unitname + " CHAR(16) COLLATE utf8_unicode_ci NOT NULL", con);
        cmd.ExecuteNonQuery();
        cmd = new MySqlCommand("ALTER TABLE scores2 ADD " + unitname + " CHAR(16) COLLATE utf8_unicode_ci NOT NULL", con);
        cmd.ExecuteNonQuery();

        con.Close();


        for (int k = 0; k < si.Length; k++)
        {

            con.Open();

            MySqlCommand cmd2 = new MySqlCommand("update questions Set " + unitname + " = @Unitname where sira=@Sira", con);

            cmd2.Parameters.AddWithValue("@Unitname", si[k]);
            cmd2.Parameters.AddWithValue("@Sira", (k + 1).ToString());

            cmd2.ExecuteNonQuery();
            cmd2.Dispose();
            con.Close();
        }




        Response.Write("<script>alert('Kelimeler basari ile gonderildi')</script>");

    }


    /*
    public static string HtmlEncode(string text)
    {
        string result;
        using (StringWriter sw = new StringWriter())
        {
            var x = new HtmlTextWriter(sw);
            x.WriteEncodedText(text);
            result = sw.ToString();
        }
        return result;

    }

    }
    */
}