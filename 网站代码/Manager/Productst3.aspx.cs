using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Manager_Productst3 : System.Web.UI.Page
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
        mysql = "SELECT 分类,子类,品牌,SUM(数量) AS 销售数量,SUM(金额) AS 销售金额 "
            + "FROM Sales "
            + "GROUP BY 分类,子类,品牌";
        myds = mydb.ExecuteQuery(mysql, "Sales");
        GridView1.DataSource = myds.Tables["Sales"];
        GridView1.DataBind();//在GridView1中显示
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/dispinfo.aspx?info=欢迎您，管理员!");
    }
    protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        bind();
    }
}