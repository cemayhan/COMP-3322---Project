using System;
using System.Web;
using MySql.Data.MySqlClient;
using System.Configuration;
public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string username = TextBox1.Text;
        string password = TextBox2.Text;

        if(hack(username) == false && hack(password) == false)
        {
            string config = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(config);
            

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = config;

            string sql = "SELECT kullaniciadi,sifre,usergroup FROM kullanici WHERE (kullaniciadi ='" + username + "') AND (sifre ='" + password + "')";

            MySqlCommand comm = new MySqlCommand(sql, conn);
            conn.Open();

            string text;
            text = (string)comm.ExecuteScalar();

            MySql.Data.MySqlClient.MySqlDataReader reader = null;
            reader = comm.ExecuteReader();
            while (reader.Read())
            {
                string level = reader["usergroup"].ToString();
            
            
            if(text != null)
            {
                Session["UserAuthentication"] = username;
                Session.Timeout = 1;
                HttpCookie myCookie = new HttpCookie("speaknlearn.com");
                myCookie["username"] = username;
                myCookie["sessionid"] = "1944";
                myCookie["level"] = level;
                myCookie.Expires = DateTime.Now.AddMinutes(90);
                Response.Cookies.Add(myCookie);
                Response.Redirect("Default.aspx");
            }
            else
            {
                Session["UserAuthentication"] = "";
            }
            conn.Close();
            }

        }
        
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