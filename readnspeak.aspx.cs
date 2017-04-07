using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Web;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public partial class exercises : System.Web.UI.Page
{
    public void Page_Load(object sender, EventArgs e)
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
                string test2;
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
                    string sql2 = "Select * from questions";
                    MySqlCommand cmd2 = new MySqlCommand(sql2, con2);
                    con2.Open();
                    MySqlDataAdapter dt = new MySqlDataAdapter(cmd2);
                    DataSet ds = new DataSet();

                    int i = 0;

                    dt.Fill(ds);
                    string[] str = new string[10];
                    var labels = new List<Label>()
            {
                Label1,Label2,Label3,Label4,Label5,Label6,Label7,Label8,Label9,Label10
            };

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        str[i] = row[test2].ToString();

                        labels[i].Text = str[i];
                        labels[i].Attributes.CssStyle.Value = ("text-align: center; font-family: 'Comic Sans MS', cursive, sans-serif; text-size: 10px;");

                        i++;
                    }

                    dt.Dispose();
                    con2.Close();
                }
            }
        }
    }
    protected void Button2_Click1(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        Response.Redirect("default.aspx");
    }

    protected void Button1_Click1(object sender, EventArgs e)
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
                string test2;
                var regexItem = new Regex("^[a-zA-Z0-9]*$");
                test2 = Request.QueryString["unit"];

                if (Request.QueryString["unit"] == null && regexItem.IsMatch(test2))
                {
                    Response.Redirect("default.aspx");
                }
                else
                {
                    MySqlConnection con3 = new MySqlConnection(config);
                    con3 = new MySql.Data.MySqlClient.MySqlConnection();
                    con3.ConnectionString = config;
                    string sql3 = "Select * from questions";
                    MySqlCommand cmd3 = new MySqlCommand(sql3, con3);
                    con3.Open();

                    MySqlDataAdapter dt2 = new MySqlDataAdapter(cmd3);
                    DataSet ds2 = new DataSet();

                    int i = 0;

                    dt2.Fill(ds2);
                    string[] str = new string[10];

                    foreach (DataRow row in ds2.Tables[0].Rows)
                    {
                        str[i] = row[test2].ToString().ToLower();
                        i++;
                    }

                    dt2.Dispose();
                    con3.Close();

                    var textboxes = new List<TextBox>()
            {
                TextBox1,TextBox2,TextBox3,TextBox4,TextBox5,TextBox6,TextBox7,TextBox8,TextBox9,TextBox10
            };

                    var labels = new List<Label>()
            {
                Label1,Label2,Label3,Label4,Label5,Label6,Label7,Label8,Label9,Label10
            };

                    string[] ans = new string[10];

                    for (int k = 0; k < textboxes.Count; k++)
                    {
                        ans[k] = textboxes[k].Text.ToLower();
                    }


                    double score = 0;
                    double[] score2 = new double[10];
                    double pass = 0.5;
                    double accuracy = 0;
                    string atrue = "<font color=green size=5px>  &#10004;</font>";
                    string afalse = "<font color=red size=5px>  &#10006;</font>";

                    for (int j = 0; j < 10; j++)
                    {
                        score2[j] = CalculateSimilarity(str[j], ans[j]);
                        score += Math.Round((score2[j] * 10), 0);
                        accuracy += score2[j];
                        if (score2[j] > pass)
                        {
                            string kelime = (Math.Round((score2[j] * 100d), 3).ToString());
                            labels[j].Text += atrue + " %" + kelime;
                        }
                        else
                        {
                            string kelime = (Math.Round((score2[j] * 100d), 3).ToString());
                            labels[j].Text += afalse + " %" + kelime;
                        }
                    }


                    if (score < 70)
                    {
                        Label11.Text = "Your Total Score is = <font color='red'><h1>" + score + "</h1></font>";
                    }
                    if (score > 69 && score < 80)
                    {
                        Label11.Text = "Your Total Score is = <font color='orange'><h1>" + score + "</h1></font>";
                    }
                    if (score > 79 && score < 90)
                    {
                        Label11.Text = "Your Total Score is = <font color='yellow'><h1>" + score + "</h1></font>";
                    }
                    if (score > 89 && score < 101)
                    {
                        Label11.Text = "Your Total Score is = <font color='lightgreen'><h1>" + score + "</h1></font>";
                    }
                    con3.Open();

                    cmd3 = new MySqlCommand("select " + test2 + " from scores where kullaniciadi = @Kullaniciadi", con3);
                    cmd3.Parameters.AddWithValue("@Kullaniciadi", user);
                    int number = int.Parse(cmd3.ExecuteScalar().ToString());
                    accuracy = accuracy * 10;
                    if (number < score)
                    {

                        cmd = new MySqlCommand("UPDATE scores SET " + test2 + " = @Score, accuracy = @Accuracy WHERE kullaniciadi = @Kullaniciadi", con3);

                        cmd.Parameters.AddWithValue("@Score", score);
                        cmd.Parameters.AddWithValue("@Accuracy", accuracy);
                        cmd.Parameters.AddWithValue("@Kullaniciadi", user);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        con3.Close();
                    }

                }
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




    public static bool hack(string str)
    {
        string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
        char[] specialCharactersArray = specialCharacters.ToCharArray();

        int index = str.IndexOfAny(specialCharactersArray);
        //index == -1 no special characters
        if (index == -1)
            return false;
        else
            return true;
    }
}