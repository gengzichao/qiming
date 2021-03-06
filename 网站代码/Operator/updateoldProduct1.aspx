﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updateoldProduct1.aspx.cs" Inherits="Operator_updateoldProduct1" %>

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
            <td >更新商品单价和库存信息</td>
            
        </tr>
        <tr><td>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="true" AutoGenerateColumns="false"
        BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2"
        Font-Bold="true" Font-Size="10pt" ForeColor="Black" GridLines="None" 
        OnRowEditing="GridView1_RowEditing" PageSize="5" Width="1089px" >
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
               <asp:TemplateField HeaderText="图片">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Image ID="image1" runat="server" Height="50px" Width="50px"
                        ImageUrl= '<% # DataBinder.Eval(Container.DataItem,"图片").ToString().Trim() %>' />
                </ItemTemplate>
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:TemplateField>
             <asp:BoundField DataField="库存数量" HeaderText="库存数量">
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:BoundField>
            <asp:TemplateField HeaderText="单价">
                <ItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server"  Width="48px" Height="16px"
                        Text= '<% # DataBinder.Eval(Container.DataItem,"单价").ToString().Trim() %>' />
                </ItemTemplate>
                <HeaderStyle Font-Bold="true" Font-Size="18px" Font-Names="隶书" ForeColor="Blue"/>
                <ItemStyle HorizontalAlign="Center"/>
            </asp:TemplateField>
         
            <asp:TemplateField HeaderText="增加库存" >
                <ItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="24px"/>
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
        <td style="text-align:center"><asp:Button ID="Button1" runat="server" Text="保存" OnClick="Button1_Click" /> &nbsp&nbsp&nbsp
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
