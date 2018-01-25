<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adduser.aspx.cs" Inherits="Manager_adduser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table style="width:50%">
        <tr>
            <td colspan="2" style="text-align:center">顾客注册</td>
        </tr>
        <tr>
            <td style="text-align:right">用户名*</td>
            <td><asp:TextBox ID="usernameTextBox" runat="server"></asp:TextBox></td>

        </tr>
        <tr>
            <td style="text-align:right">密码*</td>
            <td><asp:TextBox ID="passTextBox1" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
        <td style="text-align:right">用户类型*</td>

        <td>
        <asp:RadioButton ID="RadioButton1" runat="server" Text="管理员" GroupName="1" Checked="true"/>
        <asp:RadioButton ID="RadioButton2" runat="server" Text="操作员" GroupName="1"/>
        </td>
         </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="确定" OnClick="Button1_Click"/> &nbsp
                <asp:Button ID="Button2" runat="server" Text="返回" OnClick="Button2_Click"/>
            </td>   
        </tr>

    </table>
    </div>
    </form>
</body>
</html>
