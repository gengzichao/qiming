<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >
    <div style="text-align:center;width:100%;height:500px">
    


    
     <table style="height:172px; width: 522px;  margin-top:35%;margin-left:25%""     >
    <tr>
        <td></td>
        <td  style="text-align:center">
        用户登录
        </td>
    </tr>
     <tr>
        <td style="text-align:right">用户名</td>
        <td>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
     <tr>
        <td style="text-align:right">密码</td>
         <td>
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
     <tr>
        <td style="text-align:right">用户类型</td>
        <td>
        <asp:RadioButton ID="RadioButton1" runat="server" Text="顾客" GroupName="1"/>
        <asp:RadioButton ID="RadioButton2" runat="server" Text="操作员" GroupName="1"/>
        <asp:RadioButton ID="RadioButton3" runat="server" Text="管理员" GroupName="1"/>
        </td>
    </tr>
     <tr>
         <td style="text-align:right">验证码</td>
        <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
         <td>
             <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button3" runat="server" Text="看不清" OnClick="Button3_Click"/>
        </td>
    </tr>
    <tr>
        <td></td>
        <td style="text-align:center">&nbsp&nbsp
            <asp:Button ID="Button1" runat="server"  Text="登录" OnClick="Button1_Click"/> &nbsp&nbsp
           
        </td>
        <td style="text-align:center">
            
            <asp:Button ID="Button4" runat="server" Text="游客入口" OnClick="Button4_Click" />
        </td>
    </tr>
</table>
   
    


    
    
    </div>
    
    
    
</asp:Content>

