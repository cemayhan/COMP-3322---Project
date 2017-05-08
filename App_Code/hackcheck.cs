using System;
using System.Web;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
/// <summary>
/// Summary description for hackcheck
/// </summary>
public class hackcheck
{
    public Boolean Hacker()
    {
        

        HttpCookie myCookie = new HttpCookie("speaknlearn.com");
        myCookie = HttpContext.Current.Request.Cookies.Get("speaknlearn.com");
        string user = null;
        string ssid = null;
        if (myCookie == null)
        {
            return false;
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
            return false;
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
                return false;
            }
            else
            {
                string test2;
                var regexItem = new Regex("^[a-zA-Z0-9]*$");
                test2 = HttpContext.Current.Request.QueryString["unit"];

                if (test2 == null && regexItem.IsMatch(test2))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
