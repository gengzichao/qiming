using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Customer_dispmyod : System.Web.UI.Page
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
        mysql = "SELECT * FROM OrderForm WHERE 用户名 = '" + Session["uname"] + "'";
        myds = mydb.ExecuteQuery(mysql, "OrderForm");
        GridView1.DataSource = myds.Tables["OrderForm"];
        GridView1.DataKeyNames = new string[] { "订单号" };
        GridView1.DataBind();
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        e.Cancel = true;
        string ddh = GridView1.DataKeys[e.NewEditIndex][0].ToString();//记录订单号
        Session["ddh"] = ddh;
        Response.Redirect("dispmyod1.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/dispinfo.aspx?info=欢迎您继续选购!");
    }
}