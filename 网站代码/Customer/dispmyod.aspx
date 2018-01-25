<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dispmyod.aspx.cs" Inherits="Customer_dispmyod" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
 <style type="text/css">
        .auto-style1 {
            height: 27px;
        }
        .auto-style2 {
            width: 30%;
            height: 27px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="text-align:center; width:100%;">
        <tr >
            <td  colspan="2">查看我的订单信息</td>
            
        </tr>
        <tr><td colspan="2" style="margin-left: 40px">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="true" AutoGenerateColumns="false"
        BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2"
        Font-Bold="true" Font-Size="10pt" ForeColor="Black" GridLines="None" 
        PageSize="5" width="100%" OnRowEditing="GridView1_RowEditing"  >
        <FooterStyle  BackColor="Tan" />
        <Columns>
            <asp:BoundField DataField="订单号" HeaderText="订单号" >
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
            <asp:BoundField DataField="日期" HeaderText="日期">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
            <asp:BoundField DataField="总数量" HeaderText="商品总数量">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
            <asp:BoundField DataField="总金额" HeaderText="总金额">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
            <asp:BoundField DataField="处理否" HeaderText="处理否">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>

           
            <asp:CommandField ButtonType="Button" EditText="查看订单商品" ShowEditButton="true">
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
        <td colspan="2"><asp:Button ID="Button1" runat="server" Text="确认" OnClick="Button1_Click" /></td>
    </tr>

    </table>
    </div>
    </form>
</body>
</html>
