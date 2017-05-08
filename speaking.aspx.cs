using System;
using System.Collections.Generic;
using System.Web;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Text;
using System.Web.UI.WebControls;

public partial class speaking : System.Web.UI.Page
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

          
            
        }
}