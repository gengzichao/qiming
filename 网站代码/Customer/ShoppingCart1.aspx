<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShoppingCart1.aspx.cs" Inherits="Customer_ShoppingCart1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div>
     <table style="text-align:center; ">
        <tr >
            <td >选择商品放入购物车</td>
            
        </tr>
        <tr><td>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="true" AutoGenerateColumns="false"
        BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2"
        Font-Bold="true" Font-Size="10pt" ForeColor="Black" GridLines="None" 
        OnRowEditing="GridView1_RowEditing" PageSize="5" Width="1089px"  >
        <FooterStyle  BackColor="Tan" />
        <Columns>
            <asp:BoundField DataField="商品编号" HeaderText="商品编号">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
            <asp:BoundField DataField="分类" HeaderText="分类">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
            <asp:BoundField DataField="子类" HeaderText="子类">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
            <asp:BoundField DataField="品牌" HeaderText="品牌">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
            <asp:BoundField DataField="型号" HeaderText="型号">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
            <asp:BoundField DataField="单价" HeaderText="单价">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
            
            <asp:TemplateField HeaderText="图片">
               
                <ItemTemplate>
                    <asp:Image ID="image" runat="server" Height="50px" Width="50px"
                        ImageUrl= '<% # DataBinder.Eval(Container.DataItem,"图片").ToString().Trim() %>' />
                    
                </ItemTemplate>
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:TemplateField>
             <asp:BoundField DataField="星数" HeaderText="星数">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
             <asp:BoundField DataField="库存数量" HeaderText="库存数量">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
             <asp:TemplateField HeaderText="放入否" ShowHeader="false">
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </ItemTemplate>
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="数量" >
                <ItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="24px"/>
                </ItemTemplate>
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:TemplateField>
            <asp:CommandField ButtonType="Button" EditText="查看评价"
                ShowEditButton="true">
                
            </asp:CommandField>
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
