using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class passwordreset : System.Web.UI.Page
{
    static bool mailSent = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        Uri myReferrer = Request.UrlReferrer;
        string actual = myReferrer.ToString();
        string correct = "http://turkish.speaknlearn.com/register.aspx";
        string close2 = "http://turkish.speaknlearn.com/passreminder.aspx";

        if(actual == close2 || !(actual == correct))
        {
            string close = @"<script type='text/javascript'>
                                window.returnValue = true;
                                window.close();
                                </script>";
            base.Response.Write(close);
        }

        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string email = email1.Text;

        if(hack(email)== false)
        {

            SmtpClient smtpClient = new SmtpClient("webmail.speaknlearn.com", 25);

            smtpClient.Credentials = new System.Net.NetworkCredential("info@speaknlearn.com", "Kamilecem1944");
            smtpClient.UseDefaultCredentials = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = false;
            MailMessage mail = new MailMessage();

            mail.Subject = "The user with the e-mail address "+email+" has requested a password reset.";

            //Setting From , To and CC
            mail.From = new MailAddress("info@speaknlearn.com", "System Operator");
            mail.To.Add(new MailAddress("info@speaknlearn.com"));
            mail.CC.Add(new MailAddress("info@speaknlearn.com"));

            smtpClient.Send(mail);

            string close = @"<script type='text/javascript'>
                                window.returnValue = true;
                                window.close();
                                </script>";
            base.Response.Write(close);
        }
        else
        {
            Response.Write("Your e-mail has unacceptable characters. Sorry, you cannot use this service");
        }
    }

    public static bool hack(string str)
    {
        string specialCharacters = @"%!#$%^&*()?/><,:;'\|}]{[~`+=" + "\"";
        char[] specialCharactersArray = specialCharacters.ToCharArray();

        int index = str.IndexOfAny(specialCharactersArray);
        //index == -1 no special characters
        if (index == -1)
            return false;
        else
            return true;
    }

    
}