using System;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using System.Net;

public partial class editor : System.Web.UI.Page
{

    [DllImport("Iphlpapi.dll")]
    private static extern int SendARP(Int32 dest, Int32 host, ref Int64 mac, ref Int32 length);
    [DllImport("Ws2_32.dll")]
    private static extern Int32 inet_addr(string ip);
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string userip = Request.UserHostAddress;
            string strClientIP = Request.UserHostAddress.ToString().Trim();
            Int32 ldest = inet_addr(strClientIP);
            Int32 lhost = inet_addr("");
            Int64 macinfo = new Int64();
            Int32 len = 6;
            int res = SendARP(ldest, 0, ref macinfo, ref len);
            string mac_src = macinfo.ToString("X");
            if (mac_src == "0")
            {
                if (userip == "127.0.0.1")
                    Response.Write("visited Localhost!");
                else
                    Response.Write("the IP from" + userip + "" + "<br>");
                return;
            }

            while (mac_src.Length < 12)
            {
                mac_src = mac_src.Insert(0, "0");
            }

            string mac_dest = "";

            for (int i = 0; i < 11; i++)
            {
                if (0 == (i % 2))
                {
                    if (i == 10)
                    {
                        mac_dest = mac_dest.Insert(0, mac_src.Substring(i, 2));
                    }
                    else
                    {
                        mac_dest = "-" + mac_dest.Insert(0, mac_src.Substring(i, 2));
                    }
                }
            }

            Response.Write("welcome" + userip + "<br>" + ",the mac address is" + mac_dest + "."

             + "<br>");
        }
        catch (Exception err)
        {
            Response.Write(err.Message);
        }

        Response.Write(GetMAC());
        Response.Write("<br /> " + GetMacAddress("76.30.36.138"));
    }

    private string GetMAC()
    {
        string macAddresses = "";

        foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
        {
            if (nic.OperationalStatus == OperationalStatus.Up)
            {
                macAddresses += nic.GetPhysicalAddress().ToString();
                break;
            }
        }
        return macAddresses;
    }

    [DllImport("iphlpapi.dll", ExactSpelling = true)]
    public static extern int SendARP(int DestIP, int SrcIP, [Out] byte[] pMacAddr, ref int PhyAddrLen);
    public string GetMacAddress(string sName)
    {
        string s = string.Empty;
        System.Net.IPHostEntry Tempaddr = null;
        Tempaddr = (System.Net.IPHostEntry)Dns.GetHostEntry(sName);
        System.Net.IPAddress[] TempAd = Tempaddr.AddressList;
        string[] Ipaddr = new string[3];
        foreach (IPAddress TempA in TempAd)
        {
            Ipaddr[1] = TempA.ToString();
            byte[] ab = new byte[6];
            int len = ab.Length;
            int r = SendARP((int)TempA.Address, 0, ab, ref len);
            string sMAC = BitConverter.ToString(ab, 0, 6);
            Ipaddr[2] = sMAC;
            s = sMAC;
        }
        return s;
    }
}