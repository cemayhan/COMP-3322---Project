<%@ Page Language="C#" AutoEventWireup="true" CodeFile="study.aspx.cs" Inherits="study" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1100px;
            height: 571px;
        }

        .auto-style3 {
            height: 64px;
            width: 68px;
            text-align: center;
        }

        .auto-style5 {
            height: 64px;
            width: 191px;
            text-align: center;
        }

        .auto-style9 {
            height: 64px;
            width: 102px;
            text-align: center;
        }

        .auto-style10 {
            height: 64px;
            width: 130px;
            text-align: center;
        }

        .auto-style12 {
            height: 64px;
            width: 160px;
            text-align: center;
        }

        .auto-style15 {
            height: 64px;
            width: 160px;
            text-align: center;
            font-size: large;
        }

        .auto-style16 {
            height: 64px;
            width: 102px;
            text-align: center;
            font-size: large;
        }

        .auto-style17 {
            height: 64px;
            width: 130px;
            text-align: center;
            font-size: large;
        }

        .auto-style18 {
            height: 64px;
            width: 191px;
            text-align: center;
            font-size: large;
        }

        .auto-style19 {
            height: 64px;
            width: 297px;
            text-align: center;
        }

        .auto-style20 {
            height: 64px;
            width: 68px;
            text-align: center;
            font-size: large;
        }
        .auto-style21 {
            height: 64px;
            width: 159px;
            text-align: center;
            font-size: large;
        }
        .auto-style22 {
            height: 64px;
            width: 159px;
            text-align: center;
        }
        .auto-style23 {
            height: 64px;
            width: 139px;
            text-align: center;
            font-size: large;
        }
        .auto-style24 {
            height: 64px;
            width: 139px;
            text-align: center;
        }
        .auto-style25 {
            height: 64px;
            width: 297px;
            text-align: center;
        }
    </style>
</head>
<body><div id="studyframepage">
    <table class="auto-style1" style="padding: inherit; margin: auto; font-family: Tahoma; font-size: large; font-weight: lighter; font-style: normal; font-variant: normal; color: #0000FF; border: thin groove #800080">
        <tr>
            <td class="auto-style20" style="background-color: #CCFFFF; border: 1px dotted #800080">No</td>
            <td class="auto-style25" style="background-color: #CCFFFF; border: 1px dotted #800080">Assignment Name</td>
            <td class="auto-style18" style="background-color: #CCFFFF; border: 1px dotted #800080">Assignment Link</td>
            <td class="auto-style17" style="background-color: #CCFFFF; border: 1px dotted #800080">Grade</td>
            <td class="auto-style16" style="background-color: #CCFFFF; border: 1px dotted #800080">Avg. Accuracy</td>
            <td class="auto-style15" style="background-color: #CCFFFF; border: 1px dotted #800080">Due Date</td>
            <td class="auto-style23" style="background-color: #CCFFFF; border: 1px dotted #800080">Date Submitted</td>
            <td class="auto-style21" style="background-color: #CCFFFF; border: 1px dotted #800080">Success</td>
        </tr>
        <tr>
            <td class="auto-style3" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label1" runat="server"></asp:Label></td>
            <td class="auto-style19" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label11" runat="server"></asp:Label></td>
            <td class="auto-style5" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label21" runat="server"></asp:Label></td>
            <td class="auto-style10" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label31" runat="server"></asp:Label></td>
            <td class="auto-style9" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label41" runat="server"></asp:Label></td>
            <td class="auto-style12" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label51" runat="server"></asp:Label></td>
            <td class="auto-style24" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label61" runat="server"></asp:Label></td>
            <td class="auto-style22" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label71" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="auto-style3" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label2" runat="server"></asp:Label></td>
            <td class="auto-style19" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label12" runat="server"></asp:Label></td>
            <td class="auto-style5" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label22" runat="server"></asp:Label></td>
            <td class="auto-style10" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label32" runat="server"></asp:Label></td>
            <td class="auto-style9" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label42" runat="server"></asp:Label></td>
            <td class="auto-style12" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label52" runat="server"></asp:Label></td>
            <td class="auto-style24" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label62" runat="server"></asp:Label></td>
            <td class="auto-style22" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label72" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="auto-style3" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label3" runat="server"></asp:Label></td>
            <td class="auto-style19" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label13" runat="server"></asp:Label></td>
            <td class="auto-style5" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label23" runat="server"></asp:Label></td>
            <td class="auto-style10" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label33" runat="server"></asp:Label></td>
            <td class="auto-style9" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label43" runat="server"></asp:Label></td>
            <td class="auto-style12" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label53" runat="server"></asp:Label></td>
            <td class="auto-style24" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label63" runat="server"></asp:Label></td>
            <td class="auto-style22" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label73" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="auto-style3" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label4" runat="server"></asp:Label></td>
            <td class="auto-style19" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label14" runat="server"></asp:Label></td>
            <td class="auto-style5" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label24" runat="server"></asp:Label></td>
            <td class="auto-style10" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label34" runat="server"></asp:Label></td>
            <td class="auto-style9" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label44" runat="server"></asp:Label></td>
            <td class="auto-style12" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label54" runat="server"></asp:Label></td>
            <td class="auto-style24" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label64" runat="server"></asp:Label></td>
            <td class="auto-style22" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label74" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="auto-style3" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label5" runat="server"></asp:Label></td>
            <td class="auto-style19" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label15" runat="server"></asp:Label></td>
            <td class="auto-style5" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label25" runat="server"></asp:Label></td>
            <td class="auto-style10" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label35" runat="server"></asp:Label></td>
            <td class="auto-style9" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label45" runat="server"></asp:Label></td>
            <td class="auto-style12" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label55" runat="server"></asp:Label></td>
            <td class="auto-style24" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label65" runat="server"></asp:Label></td>
            <td class="auto-style22" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label75" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="auto-style3" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label6" runat="server"></asp:Label></td>
            <td class="auto-style19" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label16" runat="server"></asp:Label></td>
            <td class="auto-style5" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label26" runat="server"></asp:Label></td>
            <td class="auto-style10" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label36" runat="server"></asp:Label></td>
            <td class="auto-style9" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label46" runat="server"></asp:Label></td>
            <td class="auto-style12" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label56" runat="server"></asp:Label></td>
            <td class="auto-style24" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label66" runat="server"></asp:Label></td>
            <td class="auto-style22" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label76" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="auto-style3" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label7" runat="server"></asp:Label></td>
            <td class="auto-style19" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label17" runat="server"></asp:Label></td>
            <td class="auto-style5" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label27" runat="server"></asp:Label></td>
            <td class="auto-style10" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label37" runat="server"></asp:Label></td>
            <td class="auto-style9" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label47" runat="server"></asp:Label></td>
            <td class="auto-style12" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label57" runat="server"></asp:Label></td>
            <td class="auto-style24" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label67" runat="server"></asp:Label></td>
            <td class="auto-style22" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label77" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="auto-style3" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label8" runat="server"></asp:Label></td>
            <td class="auto-style19" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label18" runat="server"></asp:Label></td>
            <td class="auto-style5" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label28" runat="server"></asp:Label></td>
            <td class="auto-style10" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label38" runat="server"></asp:Label></td>
            <td class="auto-style9" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label48" runat="server"></asp:Label></td>
            <td class="auto-style12" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label58" runat="server"></asp:Label></td>
            <td class="auto-style24" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label68" runat="server"></asp:Label></td>
            <td class="auto-style22" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label78" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="auto-style3" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label9" runat="server"></asp:Label></td>
            <td class="auto-style19" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label19" runat="server"></asp:Label></td>
            <td class="auto-style5" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label29" runat="server"></asp:Label></td>
            <td class="auto-style10" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label39" runat="server"></asp:Label></td>
            <td class="auto-style9" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label49" runat="server"></asp:Label></td>
            <td class="auto-style12" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label59" runat="server"></asp:Label></td>
            <td class="auto-style24" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label69" runat="server"></asp:Label></td>
            <td class="auto-style22" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label79" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="auto-style3" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label10" runat="server"></asp:Label></td>
            <td class="auto-style19" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label20" runat="server"></asp:Label></td>
            <td class="auto-style5" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label30" runat="server"></asp:Label></td>
            <td class="auto-style10" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label40" runat="server"></asp:Label></td>
            <td class="auto-style9" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label50" runat="server"></asp:Label></td>
            <td class="auto-style12" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label60" runat="server"></asp:Label></td>
            <td class="auto-style24" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label70" runat="server"></asp:Label></td>
            <td class="auto-style22" style="background-color: #CCFFFF; border: 1px dotted #800080; text-align: center; vertical-align: middle;">
                <asp:Label ID="Label80" runat="server"></asp:Label></td>
        </tr>
    </table>
    </div>
    <script type="text/javascript">
    function theFunction() {
        window.opener.location.href = window.opener.location.href;
        window.parent.location.reload();
        return true;
    }
</script>
</body>
</html>
