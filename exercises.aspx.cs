using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Web;
using System.Configuration;
public partial class exercises : System.Web.UI.Page
{


    public void Page_Load(object sender, EventArgs e)
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

        string test2;
        if (Request.QueryString["unit"] == null)
        {
            Response.Redirect("default.aspx");
        }
        else
        {
            test2 = Request.QueryString["unit"];

            string config = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
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

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                str[i] = row[test2].ToString();
                i++;
            }

            dt.Dispose();
            con2.Close();


            Label1.Text = "<center><h3><font face='Comic sans MS' align='middle'>" + str[0] + "</font></h3></center>";
            Label2.Text = "<center><h3><font face='Comic sans MS' align='middle'>" + str[1] + "</font></h3></center>";
            Label3.Text = "<center><h3><font face='Comic sans MS' align='middle'>" + str[2] + "</font></h3></center>";
            Label4.Text = "<center><h3><font face='Comic sans MS' align='middle'>" + str[3] + "</font></h3></center>";
            Label5.Text = "<center><h3><font face='Comic sans MS' align='middle'>" + str[4] + "</font></h3></center>";
            Label6.Text = "<center><h3><font face='Comic sans MS' align='middle'>" + str[5] + "</font></h3></center>";
            Label7.Text = "<center><h3><font face='Comic sans MS' align='middle'>" + str[6] + "</font></h3></center>";
            Label8.Text = "<center><h3><font face='Comic sans MS' align='middle'>" + str[7] + "</font></h3></center>";
            Label9.Text = "<center><h3><font face='Comic sans MS' align='middle'>" + str[8] + "</font></h3></center>";
            Label10.Text = "<center><h3><font face='Comic sans MS' align='middle'>" + str[9] + "</font></h3></center>";
        }
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        HttpCookie myCookie = new HttpCookie("speaknlearn.com");
        myCookie = Request.Cookies["speaknlearn.com"];
        string user = null;
        string ssid = null;
        if (myCookie == null)
        {
            Response.Redirect("login.aspx");
        }
        else
        {
            user = myCookie["username"];
            ssid = myCookie["sessionid"];
        }


        string test2;

        if (Request.QueryString["unit"] == null)
        {
            Response.Redirect("default.aspx");
        }
        else
        {
            test2 = Request.QueryString["unit"];



            string config = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
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
                str[i] = row[test2].ToString();
                i++;
            }

            dt2.Dispose();
            con3.Close();

            string firstans = TextBox1.Text.ToLower();
            string secondans = TextBox2.Text.ToLower();
            string thirdans = TextBox3.Text.ToLower();
            string fourthans = TextBox4.Text.ToLower();
            string fifthans = TextBox5.Text.ToLower();
            string sixthans = TextBox6.Text.ToLower();
            string seventhans = TextBox7.Text.ToLower();
            string eighthans = TextBox8.Text.ToLower();
            string ninthans = TextBox9.Text.ToLower();
            string tenthans = TextBox10.Text.ToLower();

            string ans1 = str[0].ToLower();
            string ans2 = str[1].ToLower();
            string ans3 = str[2].ToLower();
            string ans4 = str[3].ToLower();
            string ans5 = str[4].ToLower();
            string ans6 = str[5].ToLower();
            string ans7 = str[6].ToLower();
            string ans8 = str[7].ToLower();
            string ans9 = str[8].ToLower();
            string ans10 = str[9].ToLower();

            string sol1 = null;
            string sol2 = null;
            string sol3 = null;
            string sol4 = null;
            string sol5 = null;
            string sol6 = null;
            string sol7 = null;
            string sol8 = null;
            string sol9 = null;
            string sol10 = null;

            int score = 0;

            string atrue = "images/true.png";
            string afalse = "images/wrong.png";

            if (firstans == ans1)
            {
                sol1 = atrue;
                score += 10;
            }
            else
            {
                sol1 = afalse;
            }
            if (secondans == ans2)
            {
                sol2 = atrue;
                score += 10;
            }
            else
            {
                sol2 = afalse;
            }

            if (thirdans == ans3)
            {
                sol3 = atrue;
                score += 10;
            }
            else
            {
                sol3 = afalse;
            }

            if (fourthans == ans4)
            {
                sol4 = atrue;
                score += 10;
            }
            else
            {
                sol4 = afalse;
            }

            if (fifthans == ans5)
            {
                sol5 = atrue;
                score += 10;
            }
            else
            {
                sol5 = afalse;
            }

            if (sixthans == ans6)
            {
                sol6 = atrue;
                score += 10;
            }
            else
            {
                sol6 = afalse;
            }

            if (seventhans == ans7)
            {
                sol7 = atrue;
                score += 10;
            }
            else
            {
                sol7 = afalse;
            }

            if (eighthans == ans8)
            {
                sol8 = atrue;
                score += 10;
            }
            else
            {
                sol8 = afalse;
            }

            if (ninthans == ans9)
            {
                sol9 = atrue;
                score += 10;
            }
            else
            {
                sol9 = afalse;
            }

            if (tenthans == ans10)
            {
                sol10 = atrue;
                score += 10;
            }
            else
            {
                sol10 = afalse;
            }

            Label1.Text = Label1.Text + "<img src='" + sol1 + "' height='50' width='50'/>";
            Label2.Text = Label2.Text + "<img src='" + sol2 + "' height='50' width='50'/>";
            Label3.Text = Label3.Text + "<img src='" + sol3 + "' height='50' width='50'/>";
            Label4.Text = Label4.Text + "<img src='" + sol4 + "' height='50' width='50'/>";
            Label5.Text = Label5.Text + "<img src='" + sol5 + "' height='50' width='50'/>";
            Label6.Text = Label6.Text + "<img src='" + sol6 + "' height='50' width='50'/>";
            Label7.Text = Label7.Text + "<img src='" + sol7 + "' height='50' width='50'/>";
            Label8.Text = Label8.Text + "<img src='" + sol8 + "' height='50' width='50'/>";
            Label9.Text = Label9.Text + "<img src='" + sol9 + "' height='50' width='50'/>";
            Label10.Text = Label10.Text + "<img src='" + sol10 + "' height='50' width='50'/>";

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

            MySqlCommand cmd = new MySqlCommand("update scores Set " + test2 + " = @Score where kullaniciadi=@Kullaniciadi", con3);
                        
            cmd.Parameters.AddWithValue("@Score", score.ToString());
            cmd.Parameters.AddWithValue("@Kullaniciadi", user.ToString());
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con3.Close();
           
        }
    }
}