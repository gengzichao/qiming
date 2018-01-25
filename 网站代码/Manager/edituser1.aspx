<%@ Page Language="C#" AutoEventWireup="true" CodeFile="edituser1.aspx.cs" Inherits="Manager_edituser1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table style="text-align:center; width:100%;">
        <tr >
            <td  colspan="2">编辑用户信息</td>
            
        </tr>
        <tr><td colspan="2" style="margin-left: 40px">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="true" AutoGenerateColumns="false"
        BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2"
        Font-Bold="true" Font-Size="10pt" ForeColor="Black" GridLines="None" 
        PageSize="5" width="100%" OnRowEditing="GridView1_RowEditing" OnRowDeleting="GridView1_RowDeleting" >
        <FooterStyle  BackColor="Tan" />
        <Columns>
            <asp:BoundField DataField="用户名" HeaderText="用户名" >
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
            <asp:BoundField DataField="类型" HeaderText="类型">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
            <asp:BoundField DataField="有效否" HeaderText="有效否">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
            <asp:CommandField ShowEditButton="true" HeaderText="操作1" >
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:CommandField>
            <asp:CommandField ShowDeleteButton="true" HeaderText="操作2">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:CommandField>
        </Columns>
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center"/>
        <HeaderStyle BackColor="Tan" Font-Bold="true" />
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
    </asp:GridView>
    </td></tr>
        
    <tr>
        <td colspan="2"><asp:Button ID="Button1" runat="server" Text="退出编辑" OnClick="Button1_Click" /></td>
    </tr>

    </table>
    </div>
    </form>
</body>
</html>
