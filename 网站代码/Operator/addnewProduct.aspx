<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addnewProduct.aspx.cs" Inherits="Operator_addnewProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table>
        <tr>
            <td colspan ="2" style="text-align:center">添加商品</td>
        </tr>
        <tr>
            <td>商品编号</td>
            <td><asp:TextBox ID="bhTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>分类</td>
            <td><asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true"  OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList></td>
        </tr>
         <tr>
            <td>子类</td>
            <td><asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="true"  OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList></td>
        </tr>
         <tr>
            <td>品牌
             </td>
            <td><asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="true" ></asp:DropDownList>
             </td>
        </tr>
        <tr>
            <td>型号</td>
            <td> <asp:TextBox ID="xhTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>单价</td>
            <td> <asp:TextBox ID="priceTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>入库数量</td>
            <td> <asp:TextBox ID="numTextBox" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td colspan="2"> <asp:FileUpload ID="FileUpload1" runat="server" /></td>
        </tr>
           <tr>
            <td colspan="2" style="text-align:center"> 
                 <asp:Button ID="Button1" runat="server" Text="确定" OnClick="Button1_Click"/> &nbsp
                 <asp:Button ID="Button2" runat="server" Text="返回" OnClick="Button2_Click" style="height: 27px"/>
                 
            </td>
        </tr>
        <tr style="text-align:center">
            <td><asp:Label ID="Label1" runat="server"></asp:Label></td>
            
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
