<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="operatormenu.aspx.cs" Inherits="operatormenu" %>

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
                        <asp:TreeNode Text="商品管理" Value="商品管理"
                        NavigateUrl="dispinfo.aspx?info=欢迎使用本系统" Target="Iframe">
                            <asp:TreeNode Text="添加新型号产品信息" Value="添加新型号产品信息" 
                             NavigateUrl="~/Operator/addnewProduct.aspx" Target="Iframe">
                            </asp:TreeNode>
                            <asp:TreeNode Text="更新老商品信息" Value="更新老商品信息" 
                             NavigateUrl="~/Operator/updateoldProduct.aspx" Target="Iframe">
                            </asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="订单管理" Value="订单管理" 
                        NavigateUrl="dispinfo.aspx?info=欢迎使用本系统" Target="Iframe">
                             <asp:TreeNode Text="新订单结算处理" Value="新订单结算处理"
                            NavigateUrl="~/Operator/receiptprocess.aspx" Target="Iframe">
                            </asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="我的密码管理" Value="我的密码管理"
                        NavigateUrl="dispinfo.aspx?info=欢迎使用本系统" Target="Iframe">
                            <asp:TreeNode Text="更改我的密码" Value="更改我的密码" 
                             NavigateUrl="~/Operator/updateoperatorpass.aspx" Target="Iframe">
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

