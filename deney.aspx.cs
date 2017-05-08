using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class deney : System.Web.UI.Page
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
    private string TestUrl;
    int Database()
    {
        var regexItem = new Regex("^[a-zA-Z0-9]*$");
        TestUrl = Request.QueryString["unit"];

        if (Request.QueryString["unit"] == null && regexItem.IsMatch(TestUrl))
        {
            return 0;
        }
        else
        {
            string config = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(config);

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = config;

            MySqlConnection con2 = new MySqlConnection(config);
            con2 = new MySql.Data.MySqlClient.MySqlConnection();
            con2.ConnectionString = config;

            MySqlCommand cmd2 = new MySqlCommand("SELECT COUNT(@Unitname) FROM questions", con2);
            cmd2.Parameters.AddWithValue("@Unitname", TestUrl);
            int indexno;

            con2.Open();
            int.TryParse((cmd2.ExecuteScalar().ToString()), out indexno);
            con2.Close();
            cmd2.Dispose();
            return indexno;
        }
    }
    double[] Score = new double[10];
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie myCookie = new HttpCookie("speaknlearn.com");
        myCookie = Request.Cookies["speaknlearn.com"];
        string user = null;
        string ssid = null;
        if (myCookie == null)
        {
            Response.Redirect("login.aspx#login");
        }
        else
        {
            user = myCookie["username"];
            kullanici = user;
            ssid = myCookie["sessionid"];
        }

        ssid = EncryptDecrypt.Decrypt(ssid, true);

        var passcheck = new Regex("('(''|[^'])*')|(;)|(\b(ALTER|CREATE|DELETE|DROP|EXEC(UTE){0,1}|INSERT( +INTO){0,1}|MERGE|SELECT|UPDATE|UNION( +ALL){0,1})\b)");

        if (passcheck.IsMatch(user) || passcheck.IsMatch(ssid))
        {
            Response.Redirect("login.aspx");
        }
        else
        {


            string config = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(config);

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = config;

            string giris = "SELECT sifre FROM kullanici WHERE kullaniciadi = @Kullaniciadi";
            MySqlCommand cmd = new MySqlCommand(giris, conn);
            cmd.Parameters.AddWithValue("@Kullaniciadi", user);
            conn.Open();

            string decryptedpass = EncryptDecrypt.Decrypt(cmd.ExecuteScalar().ToString(), true);

            conn.Close();

            if (ssid != decryptedpass)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                var regexItem = new Regex("^[a-zA-Z0-9]*$");
                test2 = Request.QueryString["unit"];

                if (Request.QueryString["unit"] == null && regexItem.IsMatch(test2))
                {
                    Response.Redirect("default.aspx");
                }
                else
                {
                    MySqlConnection con2 = new MySqlConnection(config);
                    con2 = new MySql.Data.MySqlClient.MySqlConnection();
                    con2.ConnectionString = config;

                    MySqlCommand cmd2 = new MySqlCommand("SELECT COUNT(@Unitname) FROM questions", con2);
                    cmd2.Parameters.AddWithValue("@Unitname", test2);
                    int qnumber;

                    con2.Open();
                    int.TryParse((cmd2.ExecuteScalar().ToString()), out qnumber);
                    str = new string[qnumber];



                    string sql2 = "Select * from questions";
                    cmd2 = new MySqlCommand(sql2, con2);

                    MySqlDataAdapter dt = new MySqlDataAdapter(cmd2);
                    DataSet ds = new DataSet();

                    int i = 0;

                    dt.Fill(ds);


                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        str[i] = row[test2].ToString();
                        i++;
                    }

                    dt.Dispose();
                    con2.Close();
                    Label1.Text = "<br />" + str[m];

                    TableRow tRow = new TableRow();
                    Table1.Rows.Add(tRow);
                    string[] text = new string[3];

                    for (i = 0; i < str.Length; i++)
                    {
                        TableCell tCell = new TableCell();
                        LinkButton link1 = new LinkButton();
                        tRow.Cells.Add(tCell);

                        link1.Text = (i + 1).ToString();
                        link1.ID = (i + 1).ToString();
                        link1.Click += new System.EventHandler(LinkButton1_Click);
                        link1.Attributes.Add("runat", "server");
                        link1.Attributes.Add("style", "border: 2px solid #0600b8;width:28px;height:25px; text-align: center;vertical-align: central;vertical-align: middle;margin: auto;display: inline-block;color: white;background-color: #78777a;)");

                        Ceviri cv = new Ceviri();
                        string tercume = cv.Translate(str[i], "tr", "en");

                        link1.Attributes.Add("TITLE", tercume);


                        tCell.Controls.Add(link1);
                        linlist.Add(link1);

                    }


                }



                if (!IsPostBack)
                {

                    Label5.Text = "1";
                    Label5.Visible = false;
                    Label5.Attributes.Add("style", "display:none;");


                }

            }
        }
    }



    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

        System.Threading.Thread.Sleep(2000);
        if (!IsPostBack)
        {

            Int32.TryParse(Label5.Text, out no);

            Label1.Text = "<br />" + str[no];
            ImageButton1.Attributes.Add("OnClick", "ImageButton1_Click");

            no++;
            Label5.Text = no.ToString();
            Label5.Visible = false;
            Label5.Attributes.Add("style", "display:none;");


        }

        else
        {

            Int32.TryParse(Label5.Text, out no);
            if (no <= 9)
            {

                Int32.TryParse(Label5.Text, out no);
                Label1.Text = "<br />" + str[no];
                ImageButton1.Attributes.Add("OnClick", "ImageButton1_Click");

                no++;
                Label5.Text = no.ToString();
                Label5.Visible = false;
                Label5.Attributes.Add("style", "display:none;");

            }

        }
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        if (IsPostBack)
        {
            System.Threading.Thread.Sleep(2000);

            Int32.TryParse(Label5.Text, out no);

            Score[no] = CalculateSimilarity(str[no - 1], TextBox1.Text);

            double answer = CalculateSimilarity(str[no - 1], TextBox1.Text);
            string text = str[no - 1];
            TextBox1.Text = "";

            if (answer > 0.69d)
            {
                Label1.Text = text + "      = <font color=green size=5px>  &#10004;</font>" + "  %" + answer * 100d;
                linlist.ElementAt((no - 1)).Attributes.Add("style", "border: 2px solid #0600b8;width:28px;height:25px; text-align: center;vertical-align: central;vertical-align: middle;margin: auto;display: inline-block;color: #720309;background-color: #00ff11;");
            }
            else
            {
                Label1.Text = text + "      = <font color=red size=5px>  &#10006;</font>" + "  %" + answer * 100d;
                linlist.ElementAt((no - 1)).Attributes.Add("style", "border: 2px solid #0600b8;width:28px;height:25px; text-align: center;vertical-align: central;vertical-align: middle;margin: auto;display: inline-block;color: #720309;background-color: #ff0000;");
            }


            string config = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(config);
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = config;



            grade = Math.Round(((Score.Sum() / Score.Length) * 100d), 2);

            MySqlCommand cmd = new MySqlCommand("UPDATE scores SET " + test2 + " = @Grade WHERE kullaniciadi = @Kullanici", conn);

            // cmd.Parameters.AddWithValue("@Unitname", test2);
            cmd.Parameters.AddWithValue("@Grade", grade.ToString());
            cmd.Parameters.AddWithValue("@Kullanici", kullanici);


            conn.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

            Label1.Text = " <br /> Total score :" + grade.ToString();

        }
    }



    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            string id = (((LinkButton)sender).ClientID).ToString();
            Int32.TryParse(id, out no);
            Label5.Text = no.ToString();
            Label5.Visible = false;
            Label5.Attributes.Add("style", "display:none;");

            if (no == 10)
            {
                Label1.Text = "<br />" + str[no - 1];

            }
            else
            {
                Label1.Text = "<br />" + str[no - 1];
            }
        }
        else
        {

            string id = (((LinkButton)sender).ClientID).ToString();
            int no;
            Int32.TryParse(id, out no);
            Label5.Text = no.ToString();
            Label5.Visible = false;
            Label5.Attributes.Add("style", "display:none;");

            if (no == 10)
            {
                Label1.Text = "<br />" + str[no - 1];
                m = no - 1;
            }
            else
            {
                Label1.Text = "<br />" + str[no - 1];
                m = no;
            }
        }

    }
    int ComputeLevenshteinDistance(string source, string target)
    {
        if ((source == null) || (target == null)) return 0;
        if ((source.Length == 0) || (target.Length == 0)) return 0;
        if (source == target) return source.Length;

        int sourceWordCount = source.Length;
        int targetWordCount = target.Length;

        // Step 1
        if (sourceWordCount == 0)
            return targetWordCount;

        if (targetWordCount == 0)
            return sourceWordCount;

        int[,] distance = new int[sourceWordCount + 1, targetWordCount + 1];

        // Step 2
        for (int i = 0; i <= sourceWordCount; distance[i, 0] = i++) ;
        for (int j = 0; j <= targetWordCount; distance[0, j] = j++) ;

        for (int i = 1; i <= sourceWordCount; i++)
        {
            for (int j = 1; j <= targetWordCount; j++)
            {
                // Step 3
                int cost = (target[j - 1] == source[i - 1]) ? 0 : 1;

                // Step 4
                distance[i, j] = Math.Min(Math.Min(distance[i - 1, j] + 1, distance[i, j - 1] + 1), distance[i - 1, j - 1] + cost);
            }
        }

        return distance[sourceWordCount, targetWordCount];
    }
    double CalculateSimilarity(string source, string target)
    {
        if ((source == null) || (target == null)) return 0.0;
        if ((source.Length == 0) || (target.Length == 0)) return 0.0;
        if (source == target) return 1.0;

        int stepsToSame = ComputeLevenshteinDistance(source, target);
        return (1.0 - ((double)stepsToSame / (double)Math.Max(source.Length, target.Length)));
    }
}