using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    CommDB mydb = new CommDB();                          //创建CommDB对象
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)                            //在网页首发时执行
            Label1.Text = mydb.RandomNum(4);
        else                                             //回传时应保存密码
            TextBox2.Attributes.Add("value", TextBox2.Text);

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string mysql;
        int i;
        if (TextBox1.Text.Trim() == "" || TextBox2.Text.Trim() == "")
        {
            Response.Write("<script>alert('用户名和密码不能为空!')</script>");
            return;
        }
        if (TextBox3.Text.ToUpper().Trim() != Label1.Text.Trim())
            Response.Write("<script>alert('你的验证码输入错误," + "请重新输入')</script>");
        else                         //若验证码输入正确
        {
            if(RadioButton1.Checked) //顾客登录
            {
                mysql ="SELECT 用户名 FROM Customers WHERE 用户名 = '"+ TextBox1.Text +"'AND 密码 = '" + TextBox2.Text + "'AND 有效否 = '1'";
                i = mydb.Rownum(mysql);
                if(i>0)             //合法用户
                {
                    Session["uname"] = TextBox1.Text.Trim();
                    Server.Transfer("~/customermenu.aspx");
                }
                else                //非法用户
                    Response.Write("<script>alert('对不起,你输入的"+"用户名/密码错误或者已无效,请查实!')</script>");
            }
            else if(RadioButton2.Checked)        //操作员登录
            {
                mysql = "SELECT 用户名 FROM Users WHERE 用户名 = '" + TextBox1.Text + "'AND 密码 = '" + TextBox2.Text + "'AND 类型 = '操作员'";
                i = mydb.Rownum(mysql);          //执行SQL语句并返回行数
                if(i>0)
                {
                    Session["uname"]=TextBox1.Text.Trim();
                    Server.Transfer("~/operatormenu.aspx");
                }
                else
                    Response.Write("<script>alert('对不起,你输入的"+"用户名/密码错误或者已无效,请查实!')</script>");
            }
            else if(RadioButton3.Checked)      //管理员登录
            {
                 mysql ="SELECT 用户名 FROM Users WHERE 用户名 = '"+ TextBox1.Text +"' AND 密码 = '" + TextBox2.Text + "'AND 类型 = '管理员' AND 有效否='1'";
                i = mydb.Rownum(mysql);          //执行SQL语句并返回行数
                if(i>0)
                {                              //合法管理员用户
                    Session["uname"]=TextBox1.Text.Trim();
                    Server.Transfer("~/managermenu.aspx");
                }
                else
                    Response.Write("<script>alert('对不起,你输入的"+"用户名/密码错误或者已无效,请查实!')</script>");
            }
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Label1.Text = mydb.RandomNum(4);          //获取验证码并显示在Label控件中
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Session["uname"] = "游客";               //保存游客用户名
        Server.Transfer("~/touristmenu.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}