using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class study : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie myCookie = new HttpCookie("speaknlearn.com");
        myCookie = Request.Cookies["speaknlearn.com"];
        string user = null;
        string ssid = null;
        if (myCookie != null)
        {
            user = myCookie["username"];
            ssid = myCookie["sessionid"];

        }

        else
        {
            string jScript = "<script>window.close();</script>";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "keyClientBlock", jScript);
        }

        var regex2 = new Regex("^[']*$");
        if (regex2.IsMatch(user) || regex2.IsMatch(ssid))
        {
            string jScript = "<script>window.close();</script>";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "keyClientBlock", jScript);
        }
        else
        {



            string config7 = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
            MySqlConnection comm = new MySqlConnection(config7);
            comm = new MySql.Data.MySqlClient.MySqlConnection();
            comm.ConnectionString = config7;
            string check = "SELECT sifre FROM kullanici WHERE kullaniciadi = @Kullaniciadi";
            MySqlCommand cmd7 = new MySqlCommand(check, comm);
            cmd7.Parameters.AddWithValue("@Kullaniciadi", user);
            comm.Open();
            string encryptedpass2 = cmd7.ExecuteScalar().ToString();
            string encryptedpass = EncryptDecrypt.Decrypt(encryptedpass2, true);
            comm.Close();

            if (EncryptDecrypt.Decrypt(ssid, true) != encryptedpass)
            {
                string jScript = "<script>window.close();</script>";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "keyClientBlock", jScript);

            }
            else
            {

                string config2 = ConfigurationManager.ConnectionStrings["data2ConnectionString"].ConnectionString;
                MySqlConnection con3 = new MySqlConnection(config2);
                con3 = new MySql.Data.MySqlClient.MySqlConnection();
                con3.ConnectionString = config2;

                string sql3 = "SELECT * FROM unitnames";
                MySqlCommand cmd3 = new MySqlCommand(sql3, con3);
                con3.Open();
                cmd3.ExecuteNonQuery();

                string sql6 = "SELECT COUNT(kullaniciadi) FROM scores";
                MySqlCommand cmd4 = new MySqlCommand(sql6, con3);
                int sayi = int.Parse(cmd4.ExecuteScalar().ToString());

                string sql2 = "SELECT COUNT(unitname) FROM unitnames";
                cmd4 = new MySqlCommand(sql2, con3);
                int count = int.Parse(cmd4.ExecuteScalar().ToString());



                MySqlDataAdapter dt = new MySqlDataAdapter(cmd3);
                DataSet ds = new DataSet();

                int i = 0;

                dt.Fill(ds);
                string[] str = new string[count];
                string[] duedate = new string[count];
                string[] submitdate = new string[count];

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    str[i] = row["unitname"].ToString();
                    duedate[i] = row["duedate"].ToString();
                    submitdate[i] = row["submitdate"].ToString();
                    i++;
                }
                dt.Dispose();

                string[] grade = new string[sayi];
                double[] accuracy = new double[sayi];

                int roka = 0;

                for (int g = 0; g < count; g++)
                {

                    string sql1 = "SELECT " + str[g] + " FROM scores WHERE kullaniciadi = @User";
                    cmd4 = new MySqlCommand(sql1, con3);
                    cmd4.Parameters.AddWithValue("@User", user);
                    cmd4.ExecuteNonQuery();

                    MySqlDataAdapter det = new MySqlDataAdapter(cmd4);
                    DataSet des = new DataSet();


                    det.Fill(des);



                    foreach (DataRow rower in des.Tables[0].Rows)
                    {
                        grade[roka] = rower[(str[roka])].ToString();
                        accuracy[roka] = Math.Round((double.Parse(rower[(str[roka])].ToString())),2);
                        roka++;
                    }
                    det.Dispose();
                }

                con3.Close();


                var labels = new List<Label>()
                {
                    Label1, Label2, Label3, Label4, Label5, Label6, Label7, Label8, Label9, Label10, Label11, Label12, Label13, Label14, Label15, Label16, Label17, Label18,
                    Label19, Label20, Label21, Label22, Label23, Label24, Label25, Label26, Label27, Label28, Label29, Label30, Label31, Label32, Label33, Label34, Label35,
                    Label36, Label37, Label38, Label39, Label40, Label41, Label42, Label43, Label44, Label45, Label46, Label47, Label48, Label49, Label50, Label51, Label52,
                    Label53, Label54, Label55, Label56, Label57, Label58, Label59, Label60, Label61, Label62, Label63, Label64, Label65, Label66, Label67, Label68, Label69,
                    Label70, Label71, Label72, Label73, Label74, Label75, Label76, Label77, Label78, Label79, Label80
                };

                int ilk = 0;
                int iki = 0;
                int uc = 0;
                int dort = 0;
                int bes = 0;
                int alti = 0;
                int yedi = 0;

                string[] sonuc = new string[count];
                for (int a = 0; a < labels.Count; a++)
                {
                    if (a < 10)
                    {
                        labels[a].Text = (a + 1).ToString();
                    }
                    if (a > 9 && a < 20)
                    {
                        if (ilk < count)
                        {
                            labels[a].Text = str[ilk];
                            ilk++;
                        }
                        else
                        {
                            labels[a].Text = "";
                            ilk++;
                        }

                    }
                    if (a > 19 && a < 30)
                    {
                        if (iki < count)
                        {
                            labels[a].Text = "<a href ='exercises.aspx?unit=" + str[iki] + "' target=&#x22;_blank&#x22;>Unit " + (iki + 1) + "</a>";
                            iki++;
                        }
                        else
                        {
                            labels[a].Text = "";
                            iki++;
                        }


                    }
                    if (a > 29 && a < 40)
                    {
                        if (uc < count)
                        {
                            labels[a].Text = grade[uc].ToString();
                            sonuc[uc] = grade[uc];
                            uc++;
                        }
                        else
                        {
                            labels[a].Text = "";
                            uc++;
                        }

                    }
                    if (a > 39 && a < 50)
                    {
                        if (dort < count)
                        {
                            labels[a].Text = "%" + accuracy[dort].ToString();
                            dort++;
                        }
                        else
                        {
                            labels[a].Text = "";
                            dort++;
                        }

                    }
                    if (a > 49 && a < 60)
                    {
                        if (bes < count)
                        {
                            labels[a].Text = duedate[bes];
                            bes++;
                        }
                        else
                        {
                            labels[a].Text = "";
                            bes++;
                        }

                    }
                    if (a > 59 && a < 70)
                    {
                        if (alti < count)
                        {
                            labels[a].Text = submitdate[alti];
                            alti++;
                        }
                        else
                        {
                            labels[a].Text = "";
                            alti++;
                        }
                    }
                    if (a > 69 && a < 80)
                    {
                        string atrue = "<p class='right'>&#10004;";
                        string afalse = "<p class='wrong'>&#10006;";

                        if (yedi < count)
                        {
                            int skara = int.Parse(sonuc[yedi].ToString());
                            if(skara > 69)
                            {
                                labels[a].Text = atrue + " &#9786;</p><font color=black>";
                            }
                            else
                            {
                                labels[a].Text = afalse + " &#9785;</p><font color=black>";
                            }

                            /*
                            if (sonuc[yedi] != null)
                            {
                                labels[a].Text = atrue;
                            }
                            else
                            {
                                labels[a].Text = afalse;
                            }
                            */

                            yedi++;
                        }
                        else
                        {
                            labels[a].Text = "";
                            yedi++;
                        }
                    }
                }
            }
        }
    }
}