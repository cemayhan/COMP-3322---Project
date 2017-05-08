using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChatGrade : System.Web.UI.Page
{
    string onemli;
    string onemli2;
    protected void Page_Load(object sender, EventArgs e)
    {
       


    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DropDownList1.Text == "1")
        {
            onemli = "1";
            onemli2 = "user1";
        }
        //2
        if (DropDownList1.Text == "2")
        {
            onemli = "2";
            onemli2 = "user2";
        }
        //3
        if (DropDownList1.Text == "3")
        {
            onemli = "3";
            onemli2 = "user3";
        }
        //4
        if (DropDownList1.Text == "4")
        {
            onemli = "4";
            onemli2 = "user4";
        }
        //5
        if (DropDownList1.Text == "5")
        {
            onemli = "5";
            onemli2 = "user5";
        }
        //6
        if (DropDownList1.Text == "6")
        {
            onemli = "6";
            onemli2 = "user6";
        }
        //7
        if (DropDownList1.Text == "7")
        {
            onemli = "7";
            onemli2 = "user7";
        }
        //8
        if (DropDownList1.Text == "8")
        {
            onemli = "8";
            onemli2 = "user8";
        }
        //9
        if (DropDownList1.Text == "9")
        {
            onemli = "9";
            onemli2 = "user9";
        }
        else
        {
            onemli = "admin";
            onemli2 = "useradmin";
        }

        string config = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
        MySqlConnection conn = new MySqlConnection(config);

        conn = new MySql.Data.MySqlClient.MySqlConnection();
        conn.ConnectionString = config;
        conn.Open();

        MySqlCommand cmd = new MySqlCommand("SELECT " + onemli2 + "," + onemli + " FROM chat", conn);
        cmd.ExecuteNonQuery();
        MySqlDataAdapter sda = new MySqlDataAdapter();
        cmd.Connection = conn;
        sda.SelectCommand = cmd;

        DataTable dt = new DataTable();
        sda.Fill(dt);
        //Building an HTML string.
        StringBuilder html = new StringBuilder();

        //Table start.
        html.Append("<table border = '0'>");


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
        conn.Close();
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        string config = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
        MySqlConnection conn = new MySqlConnection(config);

        conn = new MySql.Data.MySqlClient.MySqlConnection();
        conn.ConnectionString = config;
        conn.Open();

        MySqlCommand cmd = new MySqlCommand("SELECT SpeakingTest FROM scores WHERE kullaniciadi = @Kullanici", conn);
        cmd.Parameters.AddWithValue("@Kullanici", DropDownList2);
        int score;
        int.TryParse(cmd.ExecuteScalar().ToString(), out score);
        int score2;
        int.TryParse(TextBox1.Text, out score2);

        score = score + score2;


        cmd = new MySqlCommand("INSERT INTO unitnames(SpeakingTest) VALUES (@Score) WHERE kullaniciadi = @Kullanici", conn);
        cmd.Parameters.AddWithValue("@Score", TextBox1.Text);
        cmd.Parameters.AddWithValue("@Kullanici", score2);
        cmd.ExecuteNonQuery();
    }
}
