<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updatecustomerinfo.aspx.cs" Inherits="Customer_updatecustomerinfo" %>

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
            <td colspan="3" style="text-align:center">修改我的信息</td>
        </tr>
        <tr>
            <td class="auto-style1" style="text-align:right">姓名*</td>
            <td class="auto-style1" colspan="2"><asp:TextBox ID="xmTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="text-align:right">年龄*</td>
            <td colspan="2"><asp:TextBox ID="ageTextBox" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td style="text-align:right">学历*</td>
            <td colspan="2"><asp:DropDownList ID="DropDownList1" runat="server" ></asp:DropDownList></td>
        </tr>
        <tr>
            <td rowspan="6" style="text-align:right" >地址*</td>
        </tr>
        <tr>
            <td class="auto-style2" style="width:15%;text-align:right" >地区*</td>
            <td style="text-align:left" class="auto-style1"><asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList></td>
        </tr>
         <tr>
            <td style="width:15%;text-align:right">省份*</td>
            <td style="text-align:left "><asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged"></asp:DropDownList></td>
        </tr>
         <tr>
            <td style="width:15%;text-align:right">市*</td>
            <td style="text-align:left "><asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged"></asp:DropDownList></td>
        </tr>
         <tr>
            <td class="auto-style2" style="width:15%;text-align:right">县*</td>
            <td style="text-align:left " class="auto-style1"><asp:DropDownList ID="DropDownList5" runat="server" ></asp:DropDownList></td>
        </tr>
         <tr>
            <td style="width:15%;text-align:center">住址*</td>
            <td><asp:TextBox ID="placeTextBox" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td style="text-align:right">邮箱*</td>
            <td><asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td style="text-align:right">电话*</td>
            <td><asp:TextBox ID="TelTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td>
                 &nbsp<asp:Button ID="Button1" runat="server" Text="确定" OnClick="Button1_Click"/> &nbsp
                <asp:Button ID="Button2" runat="server" Text="返回" OnClick="Button2_Click"/>
            </td>   
        </tr>

    </table>
    </div>
    </form>
</body>
</html>
