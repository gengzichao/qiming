using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Manager_edituser : System.Web.UI.Page
{
    CommDB mydb = new CommDB();
    DataSet myds = new DataSet();
    string mysql;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
       
        }

    }
   

  

    protected void Button1_Click(object sender, EventArgs e)
    {
        string condstr = null;
        if (CheckBox1.Checked)
            condstr = "有效否 Like '1'";
        else
            condstr = "有效否 Like '0'";
        
        
        if (usernameTextBox.Text != "")
            condstr += " AND 用户名 Like '" + usernameTextBox.Text.Trim() + "'";
        if (RadioButton1.Checked)
            condstr += " AND 类型 Like '管理员'";
        if (RadioButton2.Checked)
            condstr += " AND 类型 Like '操作员'";
       

        
        mysql = "SELECT * FROM Users WHERE " + condstr ;
        Session["sql"] = mysql;
        Response.Redirect("edituser1.aspx");

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/dispinfo.aspx?info=欢迎您，管理员!");
    }
}