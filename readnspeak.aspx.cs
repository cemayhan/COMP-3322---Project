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
    string urluser;
    private string TestUrl;
    //double[] Score;
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
            urluser = user;
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

            string giris = "SELECT COUNT(*) FROM kullanici WHERE kullaniciadi = @Kullaniciadi";
            MySqlCommand cmd = new MySqlCommand(giris, conn);
            cmd.Parameters.AddWithValue("@Kullaniciadi", user);
            conn.Open();

            int num;
            int.TryParse((cmd.ExecuteScalar().ToString()), out num);

            if (num != 1)
            {
                Response.Redirect("login.aspx");
            }
            else
            {

                giris = "SELECT sifre FROM kullanici WHERE kullaniciadi = @Kullaniciadi";
                cmd = new MySqlCommand(giris, conn);
                cmd.Parameters.AddWithValue("@Kullaniciadi", user);


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

                        MySqlCommand cmd2 = new MySqlCommand("SELECT COUNT(" + test2 + ") FROM questions WHERE " + test2 + " <> ''", con2);
                        // cmd2.Parameters.AddWithValue("@Unitname", test2);
                        int qnumber;

                        con2.Open();

                        string nomera = cmd2.ExecuteScalar().ToString();
                        int.TryParse(nomera, out qnumber);


                        str = new string[qnumber];



                        string sql2 = "SELECT * FROM questions WHERE " + test2 + " <> ''";
                        cmd2 = new MySqlCommand(sql2, con2);
                        // cmd2.Parameters.AddWithValue("@Unitname", test2);
                        cmd2.ExecuteNonQuery();

                        MySqlDataAdapter dt = new MySqlDataAdapter(cmd2);
                        DataSet ds = new DataSet();

                        int i = 0;

                        dt.Fill(ds);
                        int kura;

                        foreach (DataRow row in ds.Tables[0].Rows)
                        {

                            str[i] = row[test2].ToString();

                            i++;


                        }
                        kura = i;
                        dt.Dispose();
                        con2.Close();
                        Label1.Text = "<br />" + str[m];

                        TableRow tRow = new TableRow();
                        Table1.Rows.Add(tRow);
                        string[] text = new string[3];

                        for (i = 0; i < kura; i++)
                        {
                            TableCell tCell = new TableCell();
                            LinkButton link1 = new LinkButton();
                            tRow.Cells.Add(tCell);

                            link1.Text = (i + 1).ToString();
                            link1.ID = (i + 1).ToString();
                            link1.Click += new System.EventHandler(LinkButton1_Click);
                            link1.Attributes.Add("runat", "server");
                            link1.Attributes.Add("style", "border: 2px solid #0600b8;width:28px;height:25px; text-align: center;vertical-align: central;vertical-align: middle;margin: auto;display: inline-block;color: white;background-color: #78777a;)");

                            //Ceviri cv = new Ceviri();
                            //string tercume = cv.Translate(str[i], "de", "en");

                            //link1.Attributes.Add("TITLE", tercume);


                            tCell.Controls.Add(link1);
                            linlist.Add(link1);

                        }


                    }
                }
            }
        }



    }



    protected void Next_Click(object sender, ImageClickEventArgs e)
    {

        // System.Threading.Thread.Sleep(700);


        Int32.TryParse(Label5.Text, out no);
        no++;

        if (no == str.Length)
        {
            no = 0;
        }

        Label1.Text = "<br />" + str[no];
        ImageButton1.Attributes.Add("OnClick", "ImageButton1_Click");

        Label5.Text = no.ToString();
        Label5.Visible = false;
        Label5.Attributes.Add("style", "display:none;");



    }


    protected void Check_Click(object sender, ImageClickEventArgs e)
    {

        string config = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
        MySqlConnection conn = new MySqlConnection(config);
        conn = new MySql.Data.MySqlClient.MySqlConnection();
        conn.ConnectionString = config;
        conn.Open();

        Int32.TryParse(Label5.Text, out no);

        str[no] = str[no].Trim(new char[] { '?', '.', ',' });
        string test = CalculateSimilarity(str[no].ToLower(), (TextBox2.Text).ToLower()).ToString();

        string cheater = CalculateSimilarity(str[no].ToLower(), (TextBox1.Text).ToLower()).ToString();
        if (TextBox1.Text != null && test != cheater)
        {
                Label1.Text = "Cheating is bad, you are recorded as a cheater, you have been warned!";
            
        }
        else
        {
            

            double score;
            double.TryParse(test, out score);

            if(score > 0.69d)
            {
                score = 1d;
            }

            score = Math.Round((score * 10d), 3);
            int temp;

            MySqlCommand cmd = new MySqlCommand("UPDATE temp SET " + kullanici + " = @Score WHERE ID = @No", conn);
            // cmd.Parameters.AddWithValue("Username", kullanici);
            cmd.Parameters.AddWithValue("@Score", score.ToString());
            cmd.Parameters.AddWithValue("@No", no + 1);
            int.TryParse(cmd.ExecuteNonQuery().ToString(), out temp);
            cmd = new MySqlCommand("SELECT " + test2 + " FROM scores WHERE kullaniciadi = @Username", conn);
            cmd.Parameters.AddWithValue("@Username", kullanici);
            double terazi;
            double.TryParse(cmd.ExecuteScalar().ToString(), out terazi);


            cmd = new MySqlCommand("UPDATE scores SET " + test2 + " = IF((SELECT SUM(" + kullanici + ") FROM temp WHERE @Username IS NOT NULL AND @Username <> '') > " + terazi + " ,(SELECT SUM(" + kullanici + ") FROM temp WHERE @Username IS NOT NULL AND @Username <> ''), '" + terazi + "') WHERE kullaniciadi = @Username", conn);

            cmd.Parameters.AddWithValue("@Username", kullanici);
            //cmd.Parameters.AddWithValue("@Unitname", test2);
            int.TryParse(cmd.ExecuteNonQuery().ToString(), out temp);



            string text = str[no];
            TextBox1.Text = "";
            TextBox2.Text = "";

            if (score > 6.9d)
            {
                Label1.Text = text + "      = <font color=green size=5px>  &#10004;</font>" + "  %" + score * 10d;
                linlist.ElementAt((no)).Attributes.Add("style", "border: 2px solid #0600b8;width:28px;height:25px; text-align: center;vertical-align: central;vertical-align: middle;margin: auto;display: inline-block;color: #720309;background-color: #00ff11;");
            }
            else
            {
                Label1.Text = text + "      = <font color=red size=5px>  &#10006;</font>" + "  %" + score * 10d;
                linlist.ElementAt((no)).Attributes.Add("style", "border: 2px solid #0600b8;width:28px;height:25px; text-align: center;vertical-align: central;vertical-align: middle;margin: auto;display: inline-block;color: #720309;background-color: #ff0000;");
            }


            cmd.Dispose();
            conn.Close();
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        string id = (((LinkButton)sender).ClientID).ToString();
        Int32.TryParse(id, out no);
        Label5.Text = (no - 1).ToString();
        Label5.Visible = false;
        Label5.Attributes.Add("style", "display:none;");
        Label1.Text = "<br />" + str[no - 1];


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