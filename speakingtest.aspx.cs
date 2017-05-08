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

public partial class speakingtest : System.Web.UI.Page
{
    int m = 0;
    string[] str;
    List<LinkButton> linlist = new List<LinkButton> { };
    int soru = 0;
    int no;
    string kelime;
    string test2;
    string kullanici;
    double grade;
    int keep;
    string urluser;
    private string TestUrl;
    string onemli;
    string onemli2;
    string user = null;
    string ssid = null;
    string nickname;
    private List<String> aswear = new List<string> { "anus", "arse", "arsehole", "ass", "ass-hat", "ass-jabber", "ass-pirate", "assbag", "fuck", "göt", "sik", "asshole", "boob", "damn", "hell", "ibne", "kıç" };
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie myCookie = new HttpCookie("speaknlearn.com");
        myCookie = Request.Cookies["speaknlearn.com"];

        if (myCookie == null)
        {
            Response.Redirect("login.aspx#login");
        }
        else
        {
            user = myCookie["username"];
            kullanici = user;
            ssid = myCookie["sessionid"];
            urluser = user;

            //1
            if (user == "andyramire350931")
            {
                onemli = "1";
                onemli2 = "user1";
                nickname = "Guest1";
            }
            else if (user == "salasss")
            {
                onemli = "2";
                onemli2 = "user2";
                nickname = "Guest2";
            }
            //2
            else if (user == "chris")
            {
                onemli = "3";
                onemli2 = "user3";
                nickname = "Guest3";
            }
            else if (user == "josstheboss")
            {
                onemli = "4";
                onemli2 = "user4";
                nickname = "Guest4";
            }

            //3
            else if (user == "cristobal17")
            {
                onemli = "5";
                onemli2 = "user5";
                nickname = "Guest5";
            }
            else if (user == "arturomedrano")
            {
                onemli = "6";
                onemli2 = "user6";
                nickname = "Guest6";
            }
            //4
            else if (user == "alexander2603")
            {
                onemli = "7";
                onemli2 = "user7";
                nickname = "Guest7";
            }
            else if (user == "xxxLegendxxx")
            {
                onemli = "8";
                onemli2 = "user8";
                nickname = "Guest8";
            }
            //5
            else if (user == "genesis")
            {
                onemli = "9";
                onemli2 = "user9";
                nickname = "Guest9";
            }
            else if (user == "rbelgara2001")
            {
                onemli = "10";
                onemli2 = "user10";
                nickname = "Guest10";
            }
            //6
            else if (user == "EmanuelS")
            {
                onemli = "2";
                onemli2 = "user2";
                nickname = "Guest11";
            }
            else if (user == "angieovo")
            {
                onemli = "6";
                onemli2 = "user6";
                nickname = "Guest12";
            }
            //7
            else if (user == "lesleyojeda1")
            {
                onemli = "7";
                onemli2 = "user7";
                nickname = "Guest13";
            }
            else if (user == "brandino")
            {
                onemli = "7";
                onemli2 = "user7";
                nickname = "Guest14";
            }
            //8
            else if (user == "maria69")
            {
                onemli = "8";
                onemli2 = "user8";
                nickname = "Guest15";
            }
            else if (user == "micahle")
            {
                onemli = "8";
                onemli2 = "user8";
                nickname = "Guest16";
            }
            //9
            else if (user == "jonathansss")
            {
                onemli = "9";
                onemli2 = "user9";
                nickname = "Guest17";
            }
            else if (user == "jasmyns")
            {
                onemli = "9";
                onemli2 = "user9";
                nickname = "Guest18";
            }
            else if (user == "cemsultan")
            {
                onemli = "4";
                onemli2 = "user4";
                nickname = "Guest19";
            }
            else
            {
                onemli = "4";
                onemli2 = "user4";
                nickname = "Guest19";
            }
            string config = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(config);

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = config;

            //cmd = new MySqlCommand("SELECT " + onemli2 + "," + onemli + " FROM chat WHERE "+onemli+" <> ''", conn);
            MySqlCommand cmd = new MySqlCommand("SELECT `" + onemli2 + "`,`" + onemli + "` FROM chat WHERE " + onemli + " <> ''", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
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
                    if (row[column.ColumnName].ToString() != null && row[column.ColumnName].ToString() != "")
                    {
                        html.Append("<td>");
                        html.Append(row[column.ColumnName]);

                        html.Append("</td>");
                    }

                }
                html.Append("</tr>");
            }

            //Table end.
            html.Append("</table>");

            //Append the HTML string to Placeholder.
            PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
            sda.Dispose();
            cmd.Dispose();
            conn.Dispose();
        }
    }


    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (TextBox1.Text != null && TextBox1.Text != "")
        {
            string config = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(config);

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = config;
            

            string message = TextBox1.Text;
            String[] msgWords = message.Split(' ');

            bool checkin = true;

            foreach (var word in msgWords)
            {
                if (aswear.Contains(word.ToLower()))
                {
                    Label1.Text = "Please do not use banned words, the banned word you used is :" + word.Substring(0, 2) + "*****";
                    TextBox1.Text = "";
                    checkin = false;
                    break;
                }
            }
            if (checkin)
            {
                string reuser = nickname + " : ";
                MySqlCommand cmd = new MySqlCommand("INSERT INTO chat(`" + onemli + "`,`" + onemli2 + "`) VALUES(@Onemli, @Onemli2)", conn);
                cmd.Parameters.AddWithValue("@Onemli", TextBox1.Text);
                cmd.Parameters.AddWithValue("@Onemli2", reuser);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                cmd.Dispose();
                conn.Dispose();

                TextBox1.Text = "";
                Response.Redirect(Request.RawUrl);


            }
            
        }
    }
}