using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class race : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string config = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
        MySqlConnection conn = new MySqlConnection(config);

        conn = new MySql.Data.MySqlClient.MySqlConnection();
        conn.ConnectionString = config;

        MySqlConnection con2 = new MySqlConnection(config);
        con2 = new MySql.Data.MySqlClient.MySqlConnection();
        con2.ConnectionString = config;
        con2.Open();

        string sql2 = "SELECT * FROM kullanici";
        MySqlCommand cmd2 = new MySqlCommand(sql2, con2);
        // cmd2.Parameters.AddWithValue("@Unitname", test2);
        cmd2.ExecuteNonQuery();

        MySqlDataAdapter dt = new MySqlDataAdapter(cmd2);
        DataSet ds = new DataSet();

        int j = 0;

        dt.Fill(ds);

        string[] str = new string[20];
        string[] btr = new string[20];

        foreach (DataRow row in ds.Tables[0].Rows)
        {

            str[j] = row["studentname"].ToString();
            btr[j] = row["kullaniciadi"].ToString();

            j++;

        }
        var labels = new List<Label>
        {
            Label2,Label3,Label4,Label5,Label6,Label7,Label8,Label9,Label10,Label11,Label12,Label13,Label14,Label15,Label16,
            Label17,Label18,Label19,Label20,Label21,Label22,Label23,Label24,Label25,Label26,Label27,Label28,Label29,Label30,Label31,
            Label32,Label33,Label34,Label35,Label36,Label37,Label38,Label39,Label40,Label41
        };

        for( int i = 0; i < str.Length; i++)
        {
            labels[i].Text = str[i];
        }

        /*
        sql2 = "SELECT COUNT("+DropDownList1.Text+ ") FROM questions WHERE " + DropDownList1.Text + " <> '' ";
        cmd2 = new MySqlCommand(sql2, con2);
        int total;
        int.TryParse((cmd2.ExecuteNonQuery().ToString()), out total);
        */
        int total;
        for (int i = 0; i < str.Length-1; i++)
        {
            sql2 = "SELECT `GünlükAktivite1` FROM scores WHERE kullaniciadi = '"+btr[i]+"'";
            cmd2 = new MySqlCommand(sql2, con2);
            //cmd2.Parameters.AddWithValue("@Username", btr[i]);
            
            int.TryParse((cmd2.ExecuteNonQuery().ToString()), out total);

            if (total > 0)
            {
                for (int k = 0; k < total; k++)
                {
                    labels[i+21].Text += "=";
                }
            }
            else
            {
                labels[i + 21].Text = "*";
            }

            labels[i + 21].Text += ">";
        }
        cmd2.Dispose();
        con2.Close();

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        //Remove previous formatting, or the decimal check will fail 

        string value = String.Format("{0:0,0.00}", double.Parse(TextBox1.Text));
        // "12,345.87"


        decimal ul;
        //Check we are indeed handling a number 
        if (decimal.TryParse(value, out ul))
        {
            //Unsub the event so we don't enter a loop 
            TextBox1.TextChanged -= TextBox1_TextChanged;
            //Format the text as currency 
            TextBox1.Text = value.ToString();
            TextBox1.TextChanged += TextBox1_TextChanged;
        }
    }
}