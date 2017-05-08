using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Web.UI.HtmlControls;
using System.Web.Security;

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
            Response.Redirect("login.aspx#login");
        }

        var regex2 = new Regex("^[\'|\"]*$");
        if (regex2.IsMatch(user) || regex2.IsMatch(ssid))
        {
            Response.Redirect("login.aspx#login");
        }
        else
        {
            string config7 = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
            MySqlConnection comm = new MySqlConnection(config7);
            comm = new MySql.Data.MySqlClient.MySqlConnection();
            comm.ConnectionString = config7;

            string check = "SELECT sifre FROM kullanici WHERE kullaniciadi = @Kullaniciadi";
            MySqlCommand cmd7 = new MySqlCommand(check, comm);
            cmd7.Parameters.AddWithValue("@Kullaniciadi", user);

            comm.Open();

            string encryptedpass2 = cmd7.ExecuteScalar().ToString();
            string encryptedpass = EncryptDecrypt.Decrypt(encryptedpass2, true);

            comm.Close();

            if (EncryptDecrypt.Decrypt(ssid, true) != encryptedpass)
            {
                Response.Redirect("login.aspx#login");
            }
            else
            {
                Label12.Text = "<h3>Welcome " + user + ",</h3>";

                cmd7 = new MySqlCommand("UPDATE temp SET "+user+" = ''", comm);
              //  cmd7.Parameters.AddWithValue("@Username", user);
                comm.Open();
                cmd7.ExecuteNonQuery();
                comm.Close();
            }
        }
    }


    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        
       
            Response.Cookies["speaknlearn.com"].Expires = DateTime.Now.AddDays(-1);
            Session.Clear();
            Session.Abandon();
            FormsAuthentication.SignOut();
            Roles.DeleteCookie();
            Session.Clear();
            Response.Redirect("login.aspx#login");
        

    }

    protected void study_Click(object sender, EventArgs e)
    {
        MainFrame.Attributes.Add("src", "study.aspx");
    }

    protected void media_Click(object sender, EventArgs e)
    {
        MainFrame.Attributes.Add("src", "speakingtest.aspx");
    }

    protected void game_Click(object sender, EventArgs e)
    {
        MainFrame.Attributes.Add("src", "practice.aspx");
    }

    protected void stats_Click(object sender, EventArgs e)
    {
        MainFrame.Attributes.Add("src", "stats.aspx");
    }
}