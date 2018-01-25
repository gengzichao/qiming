using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Tourist_QueryProduct1 : System.Web.UI.Page
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
        myds = mydb.ExecuteQuery(mysql, "Products");
        GridView1.DataSource = myds.Tables["Products"];
        GridView1.DataKeyNames = new string[] { "商品编号" };
        GridView1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/dispinfo.aspx?info=欢迎使用本系统!");
    }
    protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        bind();
    }


}