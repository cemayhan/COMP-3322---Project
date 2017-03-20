using System;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Configuration;
public partial class input : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string config = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
        MySqlConnection con = new MySqlConnection(config);
        con = new MySql.Data.MySqlClient.MySqlConnection();
        con.ConnectionString = config;

        string unitname = TextBox11.Text;

        
        MySqlCommand cmd = new MySqlCommand("ALTER TABLE questions ADD "+unitname+ " VARCHAR(128) COLLATE utf8_unicode_ci AFTER ID ", con);
        con.Open();
        cmd.ExecuteNonQuery();

        cmd = new MySqlCommand("INSERT INTO unitnames(unitname) VALUES ('" + unitname + "')", con);
        cmd.ExecuteNonQuery();

        cmd = new MySqlCommand("ALTER TABLE scores ADD "+unitname+ " INT(3) COLLATE utf8_unicode_ci", con);
        cmd.ExecuteNonQuery();
        con.Close();

        string[] si = new string[10];
        si[0] = TextBox1.Text;
        si[1] = TextBox2.Text;
        si[2] = TextBox3.Text;
        si[3] = TextBox4.Text;
        si[4] = TextBox5.Text;
        si[5] = TextBox6.Text;
        si[6] = TextBox7.Text;
        si[7] = TextBox8.Text;
        si[8] = TextBox9.Text;
        si[9] = TextBox10.Text;
        for (int i = 0; i < 10; i++)
        {

            con.Open();

            MySqlCommand cmd2 = new MySqlCommand("update questions Set " + unitname + " = @Unitname where sira=@Sira", con);

            cmd2.Parameters.AddWithValue("@Unitname", si[i]);
            cmd2.Parameters.AddWithValue("@Sira", (i+1).ToString());
            
            cmd2.ExecuteNonQuery();
            cmd2.Dispose();
            con.Close();
        }


        

        Response.Write("<script>alert('Kelimeler basari ile gonderildi')</script>");
    }

    /*
    public static string HtmlEncode(string text)
    {
        string result;
        using (StringWriter sw = new StringWriter())
        {
            var x = new HtmlTextWriter(sw);
            x.WriteEncodedText(text);
            result = sw.ToString();
        }
        return result;

    }
    */

}