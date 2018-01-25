<%@ Page Language="C#" AutoEventWireup="true" CodeFile="systeminit.aspx.cs" Inherits="Manager_systeminit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="text-align:center;margin-top:15%;margin-left:15%" >
        <tr>
            <td>网站会删除所有数据库中记录，仅保存初始管理员信息请谨慎使用</td>
        </tr>
        <tr>
            <td>  &nbsp<asp:Button ID="Button1" runat="server" Text="确定" OnClick="Button1_Click"/> &nbsp
                <asp:Button ID="Button2" runat="server" Text="返回" OnClick="Button2_Click"/></td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
