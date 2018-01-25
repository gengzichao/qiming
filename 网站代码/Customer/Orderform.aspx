<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Orderform.aspx.cs" Inherits="Customer_Orderform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="text-align:center">
        <tr><td>你的订单</td>
        </tr>
         <tr>
             <td> <asp:TextBox ID="TextBox1" runat="server"  TextMode="MultiLine" Height="172px" Width="453px"></asp:TextBox><td>
         </tr>
        <tr><td><asp:Button ID="Button1" runat="server" Text="确认" OnClick="Button1_Click" />
            </td>
        </tr>
        </table>
    </div>
       
    </form>
</body>
</html>
