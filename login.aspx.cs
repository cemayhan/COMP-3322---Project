using System;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Web;

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if ((Request.QueryString["error"]) == "empty")
        {
            errormessage.Text = "Empty field(s) has been detected, please fill all form areas </br> Thank You";

        }
    }

    protected void Register1_Click1(object sender, EventArgs e)
    {
        var regexItem = new Regex("^[a-zA-Z0-9 -]*$");
        var regex2 = new Regex("^[a-zA-Z0-9@-_.]*$");


        string studentname = firstname.Text + " " + lastname.Text;
        string kullaniciadi = username.Text;
        string sifre = password.Text;
        string email = email1.Text;

        if (firstname.Text == "" || lastname.Text == "" || kullaniciadi == "" || sifre == "" || email == "")
        {
            Response.Redirect("login.aspx?error=empty");
        }
        else
        {


            if (!regexItem.IsMatch(studentname) || !regexItem.IsMatch(kullaniciadi) || !regexItem.IsMatch(sifre) || !regex2.IsMatch(email))
            {
               
                string data = null;
                string field = null;

                if (!regexItem.IsMatch(studentname) == true)
                {
                    data = studentname;
                    field = "First Name & Last Name  ";
                }
                if (!regexItem.IsMatch(kullaniciadi) == true)
                {
                    data += kullaniciadi + " ,";
                    field += "  Username  ";
                }
                if (!regexItem.IsMatch(sifre) == true)
                {
                    data += sifre + " ,";
                    field += "  Sifre ";
                }
                if (!regex2.IsMatch(email) == true)
                {
                    data += email + " ,";
                    field += " Email Address";
                }

                errormessage.Text = "<h2>Incorrectly entered data(s) is/are :<font color=red> " + data + " </font><br /> Please correctly input these <font color=red>" + field + "</font> field(s) to the registration form. <br /> Please, avoid using any special characters except <font color=green> space </font>and <font color=green>'-'</font>. <br /><br />";


                //Response.Write("<button onclick='goBack()'>Go Back </button> <script> function goBack() {window.history.back();} </script>");
                Response.Redirect("login.aspx#login");




            }
            else
            {

                string config = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
                MySqlConnection conn = new MySqlConnection(config);


                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = config;

                MySqlCommand checkusername = new MySqlCommand("SELECT COUNT(*) FROM kullanici WHERE kullaniciadi = @Username", conn);
                checkusername.Parameters.AddWithValue("@Username", kullaniciadi);
                conn.Open();
                int controlno = int.Parse(checkusername.ExecuteScalar().ToString());

                if (controlno > 0)
                {
                    wrongemail.Text = "<font color=red><i>Sorry, Username '" + kullaniciadi + "' already exists!</i></font>";
                    conn.Close();
                }
                else
                {

                    int usergroup = 1;
                    string sql = "INSERT INTO kullanici(studentname,kullaniciadi,sifre,usergroup,email) VALUES (@Studentname,@Kullaniciadi,@Sifre,@Usergroup,@Email)";

                    MySqlCommand comm = new MySqlCommand(sql, conn);

                    comm.Parameters.AddWithValue("@Studentname", studentname);
                    comm.Parameters.AddWithValue("@Kullaniciadi", kullaniciadi);
                    comm.Parameters.AddWithValue("@Sifre", EncryptDecrypt.Encrypt(sifre, true));
                    comm.Parameters.AddWithValue("@Usergroup", usergroup);
                    comm.Parameters.AddWithValue("@Email", email);
                    comm.ExecuteNonQuery();

                    MySqlCommand cmd3 = new MySqlCommand("INSERT INTO scores(kullaniciadi) VALUES (@Studentname)", conn);
                    cmd3.Parameters.AddWithValue("@Studentname", kullaniciadi);
                    cmd3.ExecuteNonQuery();
                    conn.Close();

                    cmd3 = new MySqlCommand("ALTER TABLE temp ADD " + kullaniciadi + " CHAR(128) COLLATE utf8_unicode_ci NOT NULL AFTER ID", conn);
                    conn.Open();
                    cmd3.ExecuteNonQuery();
                    conn.Dispose();
                    cmd3.Dispose();
                    conn.Close();

                    Session["UserAuthentication"] = username;
                    Session.Timeout = 1;
                    HttpCookie myCookie = new HttpCookie("speaknlearn.com");
                    myCookie["username"] = kullaniciadi;
                    myCookie["sessionid"] = EncryptDecrypt.Encrypt(sifre, true);
                    myCookie["password"] = EncryptDecrypt.Encrypt("1a5d8w6-@", true);
                    myCookie.Expires = DateTime.Now.AddMinutes(90);
                    Response.Cookies.Add(myCookie);
                    Response.Redirect("Default.aspx");
                }
            }

        }
    }

    protected void Login1_Click1(object sender, EventArgs e)
    {

        string username = email2.Text;
        string password = password2.Text;

        if (hack(username) == false && hack(password) == false)
        {
            string config = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(config);


            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = config;



            string giris = "SELECT sifre FROM kullanici WHERE kullaniciadi = @Kullaniciadi";
            MySqlCommand cmd = new MySqlCommand(giris, conn);
            cmd.Parameters.AddWithValue("@Kullaniciadi", username);
            conn.Open();

            string encryptedpass = EncryptDecrypt.Decrypt((cmd.ExecuteScalar().ToString()), true);

            conn.Close();

            if (password != encryptedpass)
            {
                answerback.Text = "Wrong Username/Password. Please try again";
            }
            else
            {
                Session["UserAuthentication"] = username;
                Session.Timeout = 1;
                HttpCookie myCookie = new HttpCookie("speaknlearn.com");
                myCookie["username"] = username;
                myCookie["sessionid"] = EncryptDecrypt.Encrypt(password, true);
                myCookie["password"] = EncryptDecrypt.Encrypt("1a5d8w6-@", true);
                myCookie.Expires = DateTime.Now.AddMinutes(90);
                Response.Cookies.Add(myCookie);
                Response.Redirect("Default.aspx");
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