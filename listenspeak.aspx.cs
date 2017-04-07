using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Web;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public partial class listenspeak : System.Web.UI.Page
{
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
            }
        }
    }
    public string questions(int pos)
    {
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
        string test2 = Request.QueryString["unit"];

        foreach (DataRow row in ds.Tables[0].Rows)
        {
            str[i] = row[test2].ToString();

            i++;
        }

        dt.Dispose();
        con2.Close();

        return str[pos];
    }
    

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Write("<embed height='0' width='0' src='https://code.responsivevoice.org/getvoice.php?t="+questions(0)+"&tl=tr&sv=&vn=&pitch=0.5&rate=0.5&vol=1' />");
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Write("<embed height='0' width='0' src='https://code.responsivevoice.org/getvoice.php?t="+questions(1)+"&tl=tr&sv=&vn=&pitch=0.5&rate=0.5&vol=1' />");
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Response.Write("<embed height='0' width='0' src='https://code.responsivevoice.org/getvoice.php?t="+questions(2)+"&tl=tr&sv=&vn=&pitch=0.5&rate=0.5&vol=1' />");
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        Response.Write("<embed height='0' width='0' src='https://code.responsivevoice.org/getvoice.php?t="+questions(3)+"&tl=tr&sv=&vn=&pitch=0.5&rate=0.5&vol=1' />");
    }
    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        Response.Write("<embed height='0' width='0' src='https://code.responsivevoice.org/getvoice.php?t="+questions(4)+"&tl=tr&sv=&vn=&pitch=0.5&rate=0.5&vol=1' />");
    }
    protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
    {
        Response.Write("<embed height='0' width='0' src='https://code.responsivevoice.org/getvoice.php?t="+questions(5)+"&tl=tr&sv=&vn=&pitch=0.5&rate=0.5&vol=1' />");
    }
    protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
    {
        Response.Write("<embed height='0' width='0' src='https://code.responsivevoice.org/getvoice.php?t="+questions(6)+"&tl=tr&sv=&vn=&pitch=0.5&rate=0.5&vol=1' />");
    }
    protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
    {
        Response.Write("<embed height='0' width='0' src='https://code.responsivevoice.org/getvoice.php?t="+questions(7)+"&tl=tr&sv=&vn=&pitch=0.5&rate=0.5&vol=1' />");
    }
    protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
    {
        Response.Write("<embed height='0' width='0' src='https://code.responsivevoice.org/getvoice.php?t="+questions(8)+"&tl=tr&sv=&vn=&pitch=0.5&rate=0.5&vol=1' />");
    }
    protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
    {
        Response.Write("<embed height='0' width='0' src='https://code.responsivevoice.org/getvoice.php?t="+questions(9)+"&tl=tr&sv=&vn=&pitch=0.5&rate=0.5&vol=1' />");
    }
    protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
    {

    }
}