using System;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
public partial class editor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        HttpCookie newcookie = new HttpCookie("speaknlearn.com");
        newcookie = Request.Cookies["speaknlearn.com"];
        string config = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
        MySqlConnection con = new MySqlConnection(config);
        MySqlCommand cmd = new MySqlCommand();
        con.ConnectionString = config;

        string sql = "SELECT * FROM scores";

        con.Open();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
        con.Close();
        DataTable dt = new DataTable();

        for (int i = dt.Rows.Count - 1; i >= 0; i += -1)
        {
            DataRow row = dt.Rows[i];
            if (row[0] == null)
            {
                dt.Rows.Remove(row);
            }
            else if (string.IsNullOrEmpty(row[0].ToString()))
            {
                dt.Rows.Remove(row);
            }
        }
    }
}