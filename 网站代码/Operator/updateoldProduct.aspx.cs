using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Operator_updateoldProduct : System.Web.UI.Page
{
    CommDB mydb = new CommDB();
    DataSet myds = new DataSet();
    string mysql;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            mysql = "SELECT distinct 分类 FROM ProdType";
            myds = mydb.ExecuteQuery(mysql, "ProdType");
            DataRow nrow = myds.Tables["ProdType"].NewRow();
            nrow["分类"] = "";
            myds.Tables["ProdType"].Rows.InsertAt(nrow, 0);
            DropDownList1.DataSource = myds.Tables["ProdType"];
            DropDownList1.DataTextField = "分类";
            DropDownList1.DataBind();
            DropDownList2.Enabled = false;
            DropDownList3.Enabled = false;
        }

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList2.Enabled = true;
        mysql = "SELECT distinct 子类 FROM ProdType WHERE 分类 = '"
            + DropDownList1.SelectedValue.ToString().Trim() + "'";
        myds = mydb.ExecuteQuery(mysql, "ProdType");
        DataRow nrow = myds.Tables["ProdType"].NewRow();          //插入一个空行
        nrow["子类"] = "";
        myds.Tables["ProdType"].Rows.InsertAt(nrow, 0);
        DropDownList2.DataSource = myds.Tables["ProdType"];
        DropDownList2.DataTextField = "子类";
        DropDownList2.DataBind();
        DropDownList3.Items.Clear();
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList3.Enabled = true;
        mysql = "SELECT distinct 品牌 FROM ProdType WHERE 子类 = '"
            + DropDownList2.SelectedValue.ToString().Trim() + "'";
        myds = mydb.ExecuteQuery(mysql, "ProdType");
        DataRow nrow = myds.Tables["ProdType"].NewRow();          //插入一个空行
        nrow["品牌"] = "";
        myds.Tables["ProdType"].Rows.InsertAt(nrow, 0);
        DropDownList3.DataSource = myds.Tables["ProdType"];
        DropDownList3.DataTextField = "品牌";
        DropDownList3.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string condstr = "有效否 = '1'"; //只查找有效商品
        if (bhTextBox.Text != "")
            condstr = "商品编号 Like '" + bhTextBox.Text.Trim() + "%'";
        if (DropDownList1.SelectedValue.ToString().Trim() != "")
            condstr += " AND 分类 = '"
                + DropDownList1.SelectedValue.ToString().Trim() + "'";
        if (DropDownList2.SelectedValue.ToString().Trim() != "")
            condstr += " AND 子类 = '"
                + DropDownList2.SelectedValue.ToString().Trim() + "'";
        if (DropDownList3.SelectedValue.ToString().Trim() != "")
            condstr += " AND 品牌 = '"
                + DropDownList3.SelectedValue.ToString().Trim() + "'";
        float p1 = 0, p2 = 0;
        if (priceTextBox1.Text.Trim() != "")
            p1 = float.Parse(priceTextBox1.Text.Trim());
        if (priceTextBox2.Text.Trim() != "")
            p2 = float.Parse(priceTextBox2.Text.Trim());
        if (p1 != 0.0)
        {
            if (p1 <= p2)
                condstr += " AND 单价>= " + p1.ToString().Trim()
                    + " AND 单价<= " + p2.ToString().Trim();
            else
            {
                Label1.Text = "错误提示：单价段输入错误.";
                return;
            }
        }
        mysql = "SELECT * FROM Products WHERE " + condstr + " ORDER BY 商品编号";
        Session["sql"] = mysql;
        Response.Redirect("updateoldProduct1.aspx");

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/dispinfo.aspx?info=欢迎您访问本系统");
    }

}