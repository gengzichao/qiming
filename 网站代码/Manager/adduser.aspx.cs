using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Manager_adduser : System.Web.UI.Page
{
    CommDB mydb = new CommDB();
    DataSet myds = new DataSet();
    string mysql;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            int i;
            mysql = "SELECT * FROM Customers WHERE 用户名 = '"
                + usernameTextBox.Text.Trim() + "'";
            i = mydb.Rownum(mysql);
            if (i > 0)
                Response.Write("<script>alert('对不起，你输入的用户名" + "已经注册了!')</script>");
            else
            {
                string sf = "管理员";
                if (RadioButton2.Checked)
                    sf = "操作员";

                mysql = "INSERT INTO Users (用户名,密码,类型,有效否) "
                    + "VALUES('" + usernameTextBox.Text.Trim() + "','"
                    + passTextBox1.Text.Trim() + "','" 
                    + sf + "','1')";
                mydb.ExecuteNonQuery(mysql);
                Response.Redirect("~/dispinfo.aspx?info=欢迎您，管理员!");
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/dispinfo.aspx?info=欢迎您，管理员!");
    }
}