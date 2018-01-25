using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Manager_updatemanagerpass : System.Web.UI.Page
{
    CommDB mydb = new CommDB();
    DataSet myds = new DataSet();
    string mysql;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (check())
        {
            Label1.Text = "原密码有误请重新输入";
        }
        else if (check2())
        {
            Label1.Text = "两次密码不一致请重新输入";
        }
        else
        {

            mysql = "UPDATE Users SET 密码 = '" + passTextBox2.Text.ToString()
                               + "' WHERE 用户名 = '" + Session["uname"] + "'";
            mydb.ExecuteNonQuery(mysql);
            Response.Redirect("~/dispinfo.aspx?info=更改密码成功!");

        }

    }

    public bool check()
    {
        string str1, str2;
        mysql = "SELECT 密码 FROM Users WHERE 用户名 = '" + Session["uname"] + "'";
        myds = mydb.ExecuteQuery(mysql, "Users");
        str1 = myds.Tables[0].Rows[0][0].ToString().Trim();
        str2 = passTextBox1.Text.ToString();
        if (str1 != str2)
            return true;
        return false;
    }

    public bool check2()
    {
        string str1, str2;
        str1 = passTextBox2.Text.ToString();
        str2 = passTextBox3.Text.ToString();
        if (str1 != str2)
            return true;
        return false;
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/dispinfo.aspx?info=欢迎光临本系统!");
    }
}