using System;
using System.Web;
using System.Runtime.InteropServices;
using System.IO;

public partial class practice : System.Web.UI.Page
{
    [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);
    string user = null;
    string ssid = null;
    string nickname;
    string path;
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
            ssid = myCookie["sessionid"];
            // string AssemblyPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString();
            // Response.Write(AssemblyPath.ToString());
            path = @"C:\Inetpub\vhosts\speaknlearn.com\turkish.speaknlearn.com\records\" + user.ToLower() + ".txt";
            //File.Create(path);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        StreamWriter tw = new StreamWriter(path, true);

        if (!File.Exists(path))
        {

            

            // TextWriter tw = new StreamWriter(path);
            tw.WriteLine("-----------------------------------Text1---------------------------");
            tw.WriteLine(TextBox1.Text);
            tw.WriteLine("-----------------------------------Text2---------------------------");
            tw.WriteLine(TextBox2.Text);
            tw.WriteLine("-----------------------------------Text3---------------------------");
            tw.WriteLine(TextBox3.Text);
            tw.Close();
            Label2.Text = "Text Submitted";
            Label3.Text = "Text Submitted";
            Label4.Text = "Text Submitted";
        }
        else if (File.Exists(path))
        {
            
                //StreamWriter tw = new StreamWriter(path, true);
                tw.WriteLine("-----------------------------------Text1---------------------------");
                tw.WriteLine(TextBox1.Text);
                tw.WriteLine("-----------------------------------Text2---------------------------");
                tw.WriteLine(TextBox2.Text);
                tw.WriteLine("-----------------------------------Text3---------------------------");
                tw.WriteLine(TextBox3.Text);
                tw.Close();
                Label2.Text = "Text Submitted";
                Label3.Text = "Text Submitted";
                Label4.Text = "Text Submitted";
            
        }
    }



}