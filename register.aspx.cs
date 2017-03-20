using System;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Configuration;

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        var regexItem = new Regex("^[a-zA-Z0-9 -]*$");

        string studentname = TextBox1.Text;
        string kullaniciadi = TextBox2.Text;
        string sifre = TextBox3.Text;

        if (!regexItem.IsMatch(studentname) || !regexItem.IsMatch(kullaniciadi) || !regexItem.IsMatch(sifre))
        {
            Response.Write("<center><h1><br /><br /><br /><br />Your input data has forbidden characters, please correct them below <br /><br /></h1></center)");
            string data = null;
            string field = null;

            if(!regexItem.IsMatch(studentname) == true)
            {
                data = studentname;
                field = "Full Name  ";
            }
            if(!regexItem.IsMatch(kullaniciadi)== true)
            {
                data += kullaniciadi + " ,";
                field += "  Username  ";
            }
            if(!regexItem.IsMatch(sifre)== true)
            {
                data += sifre + " ,";
                field += "  Sifre";
            }

            Response.Write("<h2>Incorrectly entered data(s) are : " + data + " <br /> Please correctly input these <font color=red>" + field + "</font> field(s) to the registration form. <br /> Please, avoid using any special characters except <font color=green> space </font>and <font color=green>'-'</font>. <br /><br />");
        }
        else
        {

            string config = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(config);


            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = config;



            int usergroup = int.Parse(DropDownList1.SelectedValue);
            string sql = "INSERT INTO kullanici(studentname,kullaniciadi,sifre,usergroup) VALUES ('" + studentname + "','" + kullaniciadi + "','" + sifre + "','" + usergroup + "')";

            MySqlCommand comm = new MySqlCommand(sql, conn);
            conn.Open();
            comm.ExecuteNonQuery();

            MySqlCommand cmd3 = new MySqlCommand("INSERT INTO scores(kullaniciadi) VALUES ('" + kullaniciadi + "')", conn);
            cmd3.ExecuteNonQuery();

            conn.Close();
            Response.Write("Congratulations, Your Account has been created");
            Response.Redirect("login.aspx");
        }
    }

   

}