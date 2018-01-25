<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registered.aspx.cs" Inherits="Registered" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%">
        <tr>
            <td colspan="3" style="text-align:center">顾客注册</td>
        </tr>
        <tr>
            <td>用户名*</td>
            <td><asp:TextBox ID="usernameTextBox" runat="server"></asp:TextBox></td>

        </tr>
        <tr>
            <td>密码*</td>
            <td><asp:TextBox ID="passTextBox1" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>确认密码*</td>
            <td><asp:TextBox ID="passTextBox2" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>姓名*</td>
            <td><asp:TextBox ID="xmTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>年龄*</td>
            <td><asp:TextBox ID="ageTextBox" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>学历*</td>
            <td><asp:DropDownList ID="DropDownList1" runat="server" ></asp:DropDownList></td>
        </tr>
        <tr>
            <td rowspan="6">地址</td>
        </tr>
        <tr>
            <td>地区*</td>
            <td><asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList></td>
        </tr>
         <tr>
            <td>省份*</td>
            <td><asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged"></asp:DropDownList></td>
        </tr>
         <tr>
            <td>市*</td>
            <td><asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged"></asp:DropDownList></td>
        </tr>
         <tr>
            <td>县*</td>
            <td><asp:DropDownList ID="DropDownList5" runat="server" ></asp:DropDownList></td>
        </tr>
         <tr>
            <td>住址*</td>
            <td><asp:TextBox ID="placeTextBox" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>邮箱*</td>
            <td><asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>电话*</td>
            <td><asp:TextBox ID="TelTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="确定" OnClick="Button1_Click"/> &nbsp
                <asp:Button ID="Button2" runat="server" Text="重置" OnClick="Button2_Click"/>
            </td>   
        </tr>

    </table>
</asp:Content>

