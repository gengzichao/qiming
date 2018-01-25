<%@ Page Language="C#" AutoEventWireup="true" CodeFile="receiptprocess.aspx.cs" Inherits="Operator_receiptprocess" %>

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
            <td  colspan="2">顾客订单结算处理</td>
            
        </tr>
        <tr><td colspan="2" style="margin-left: 40px">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="true" AutoGenerateColumns="false"
        BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2"
        Font-Bold="true" Font-Size="10pt" ForeColor="Black" GridLines="None" 
        PageSize="5" width="100%" >
        <FooterStyle  BackColor="Tan" />
        <Columns>
             <asp:BoundField DataField="订单号" HeaderText="订单号">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
            <asp:BoundField DataField="日期" HeaderText="日期">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
            <asp:BoundField DataField="用户名" HeaderText="用户名">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
            <asp:BoundField DataField="姓名" HeaderText="姓名">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
            <asp:BoundField DataField="地区" HeaderText="地区">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
            <asp:BoundField DataField="省份" HeaderText="省份">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
             <asp:BoundField DataField="市" HeaderText="市">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
             <asp:BoundField DataField="县" HeaderText="县">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
             <asp:BoundField DataField="住址" HeaderText="住址">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
             <asp:BoundField DataField="邮箱" HeaderText="邮箱">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
             <asp:BoundField DataField="电话" HeaderText="电话">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
             <asp:BoundField DataField="总数量" HeaderText="总数量">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
             <asp:BoundField DataField="总金额" HeaderText="总金额">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
            <asp:TemplateField HeaderText="结算否">
                <ItemTemplate>
                    <asp:CheckBox ID ="CheckBox1" runat="server" Checked= '<% # DataBinder.Eval(Container.DataItem,"结算否") %>' />
                </ItemTemplate>
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            
            </asp:TemplateField>
        </Columns>
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center"/>
        <HeaderStyle BackColor="Tan" Font-Bold="true" />
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
    </asp:GridView>
    </td></tr>
        
    <tr>
         <td style="text-align:center"><asp:Button ID="Button1" runat="server" Text="确定" OnClick="Button1_Click" /> &nbsp&nbsp&nbsp
            <asp:Button ID="Button2" runat="server" Text="返回" OnClick="Button2_Click" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server"/>
        </td>
    </tr>
    </table>
    </div>
    </form>
</body>
</html>
