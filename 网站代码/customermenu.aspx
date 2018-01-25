<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="customermenu.aspx.cs" Inherits="customermenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <table style="width:100%;height:100%">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TreeView ID="TreeView1" runat="server" style="text-align:center;
                    font-family:FangSong;font-weight:bold;font-size:16px">
                    <Nodes>
                        <asp:TreeNode Text="购物管理" Value="购物管理"
                        NavigateUrl="dispinfo.aspx?info=欢迎使用本系统" Target="Iframe">
                            <asp:TreeNode Text="选购商品放入购物车" Value="选购商品放入购物车" 
                             NavigateUrl="~/Customer/ShoppingCart.aspx" Target="Iframe">
                            </asp:TreeNode>
                             <asp:TreeNode Text="编辑我的购物车" Value="编辑我的购物车" 
                             NavigateUrl="~/Customer/editShoppingCart.aspx" Target="Iframe">
                            </asp:TreeNode>
                             <asp:TreeNode Text="购物车结算" Value="购物车结算" 
                             NavigateUrl="~/Customer/buyproduct.aspx" Target="Iframe">
                            </asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="我的订单管理" Value="我的订单管理" 
                        NavigateUrl="dispinfo.aspx?info=欢迎使用本系统" Target="Iframe">
                            <asp:TreeNode Text="查看我的订单" Value="查看我的订单"
                            NavigateUrl="~/Customer/dispmyod.aspx" Target="Iframe">
                            </asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="我的信息管理" Value="我的信息管理" 
                        NavigateUrl="dispinfo.aspx?info=欢迎使用本系统" Target="Iframe">
                            <asp:TreeNode Text="更改我的信息" Value="更改我的信息"
                            NavigateUrl="~/Customer/updatecustomerinfo.aspx" Target="Iframe">
                            </asp:TreeNode>
                             <asp:TreeNode Text="更改我的密码" Value="更改我的密码" 
                             NavigateUrl="~/Customer/updatecustomerpass.aspx" Target="Iframe">
                            </asp:TreeNode>
                        </asp:TreeNode>
                    </Nodes>
                </asp:TreeView>

                 <asp:HyperLink ID="HyperLink1" runat="server" style="font-family:黑体;font-weight:bold;font-size:16px;color:#009900"
                NavigateUrl="~/Default.aspx" Target="_self">退出本系统</asp:HyperLink>
            </td>

            <td>
                 <iframe name ="Iframe" id="Iframe"
                style="height:500px;width:1000px;text-align:center"
                src ="dispinfo.aspx?info=欢迎使用本系统">
                </iframe>
            </td>
        </tr>
    </table>
</asp:Content>

