<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="managermenu.aspx.cs" Inherits="managermenu" %>

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
                        <asp:TreeNode Text="用户(管理员/操作员)管理" Value="用户(管理员/操作员)管理"
                        NavigateUrl="dispinfo.aspx?info=欢迎使用本系统" Target="Iframe">
                            <asp:TreeNode Text="添加新用户信息" Value="添加新用户信息" 
                             NavigateUrl="~/Manager/adduser.aspx" Target="Iframe">
                            </asp:TreeNode>
                            <asp:TreeNode Text="编辑用户信息" Value="编辑用户信息" 
                             NavigateUrl="~/Manager/edituser.aspx" Target="Iframe">
                            </asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="顾客信息管理" Value="顾客信息管理" 
                        NavigateUrl="dispinfo.aspx?info=欢迎使用本系统" Target="Iframe">
                            <asp:TreeNode Text="查看顾客信息" Value="查看顾客信息"
                            NavigateUrl="~/Manager/dispcustomer.aspx" Target="Iframe">
                            </asp:TreeNode>
                             <asp:TreeNode Text="临时封杀顾客信息" Value="临时封杀顾客信息"
                            NavigateUrl="~/Manager/killcustomer.aspx" Target="Iframe">
                            </asp:TreeNode>
                             <asp:TreeNode Text="查看顾客订单信息" Value="查看顾客订单信息"
                            NavigateUrl="~/Manager/disOrderform.aspx" Target="Iframe">
                            </asp:TreeNode>
                        </asp:TreeNode>
                         <asp:TreeNode Text="商品销售统计管理" Value="商品销售统计管理" 
                        NavigateUrl="dispinfo.aspx?info=欢迎使用本系统" Target="Iframe">
                            <asp:TreeNode Text="按商品分类统计" Value="按商品分类统计"
                            NavigateUrl="~/Manager/Productst1.aspx" Target="Iframe">
                            </asp:TreeNode>
                              <asp:TreeNode Text="按商品子类统计" Value="按商品子类统计"
                            NavigateUrl="~/Manager/Productst2.aspx" Target="Iframe">
                            </asp:TreeNode>
                              <asp:TreeNode Text="按商品品牌统计" Value="按商品品牌统计"
                            NavigateUrl="~/Manager/Productst3.aspx" Target="Iframe">
                            </asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="我的密码管理" Value="我的密码管理" 
                        NavigateUrl="dispinfo.aspx?info=欢迎使用本系统" Target="Iframe">
                            <asp:TreeNode Text="更改我的密码" Value="更改我的密码"
                            NavigateUrl="~/Manager/updatemanagerpass.aspx" Target="Iframe">
                            </asp:TreeNode>
                        </asp:TreeNode>
                         <asp:TreeNode Text="系统操作" Value="系统操作" 
                        NavigateUrl="dispinfo.aspx?info=欢迎使用本系统" Target="Iframe">
                            <asp:TreeNode Text="系统初始化" Value="系统初始化"
                            NavigateUrl="~/Manager/systeminit.aspx" Target="Iframe">
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

