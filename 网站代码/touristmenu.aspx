<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="touristmenu.aspx.cs" Inherits="touristmenu" %>

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
                        <asp:TreeNode Text="注册管理" Value="注册管理"
                        NavigateUrl="dispinfo.aspx?info=欢迎使用本系统" Target="Iframe">
                            <asp:TreeNode Text="用户注册" Value="用户注册" 
                             NavigateUrl="~/Tourist/Registered.aspx" Target="Iframe">
                            </asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="商品管理" Value="购物管理" 
                        NavigateUrl="dispinfo.aspx?info=欢迎使用本系统" Target="Iframe">
                            <asp:TreeNode Text="查看(浏览)商品" Value="查看(浏览)商品"
                            NavigateUrl="~/Tourist/QueryProduct.aspx" Target="Iframe">
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

