using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Manager_disOrderform1 : System.Web.UI.Page
{
    string mysql;
    CommDB mydb = new CommDB();
    DataSet myds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            bind();
        }
    }

    public void bind()
    {
        mysql = Session["sql"].ToString();
        myds = mydb.ExecuteQuery(mysql, "Customers");
        GridView1.DataSource = myds.Tables["Customers"];
        GridView1.DataKeyNames = new string[] { "用户名" };
        GridView1.DataBind();
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        e.Cancel = true;
        string cname = GridView1.DataKeys[e.NewEditIndex][0].ToString();//记录订单号
        Session["cname"] = cname;
        Response.Redirect("disOrderform2.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/dispinfo.aspx?info=欢迎您，管理员!");
    }
}