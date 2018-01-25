<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updatecustomerpass.aspx.cs" Inherits="Customer_updatecustomerpass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="width:50%">
    <tr>
            <td class="auto-style1"></td>
            <td colspan="1" style="text-align:left" class="auto-style1">修改密码</td>
        </tr>
        <tr>
            <td style="text-align:right">原密码*</td>
            <td colspan="1"><asp:TextBox ID="passTextBox1" runat="server" TextMode="Password"></asp:TextBox></td>


        </tr>
        <tr>
            <td style="text-align:right">密码*</td>
            <td colspan="1"><asp:TextBox ID="passTextBox2" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="text-align:right">确认密码*</td>
            <td colspan="1"><asp:TextBox ID="passTextBox3" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
          <tr>
            <td></td>
            <td>
                 &nbsp<asp:Button ID="Button1" runat="server" Text="确定" OnClick="Button1_Click"/> &nbsp
                <asp:Button ID="Button2" runat="server" Text="返回" OnClick="Button2_Click"/>
                 
            </td>   
        </tr>
         
        <tr>
            <td></td>
            <td><asp:Label ID="Label1" runat="server"></asp:Label></td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
