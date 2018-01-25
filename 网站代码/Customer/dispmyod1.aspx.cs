using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Customer_dispmyod1 : System.Web.UI.Page
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
        mysql = "SELECT 日期,商品编号,分类,子类,品牌,型号,单价,数量,金额 FROM Sales "
            + " WHERE 用户名 = '" + Session["uname"] + "' "
            + " AND 订单号 = '" + Session["ddh"] + "'";
        myds = mydb.ExecuteQuery(mysql, "Sales");
        GridView1.DataSource = myds.Tables["Sales"];
        GridView1.DataKeyNames = new string[] { "商品编号" };
        GridView1.DataBind();
    }


    protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        bind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/dispinfo.aspx?info=欢迎您继续选购!");
    }
}