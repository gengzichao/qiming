using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Manager_killcustomer : System.Web.UI.Page
{
    CommDB mydb = new CommDB();
    DataSet myds = new DataSet();
    string mysql;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            mysql = "SELECT 学历 FROM Education";
            myds = mydb.ExecuteQuery(mysql, "Education");       //执行查询语句
            DataRow nrow = myds.Tables["Education"].NewRow();   //新建一个空行
            nrow["学历"] = "";
            myds.Tables["Education"].Rows.InsertAt(nrow, 0);
            DropDownList1.DataSource = myds.Tables["Education"];//设置学历下拉列表数据源
            DropDownList1.DataTextField = "学历";               //设置绑定字段
            DropDownList1.DataBind();                           //数据绑定


            mysql = "SELECT distinct 地区 FROM Area";
            myds = mydb.ExecuteQuery(mysql, "Area");
            DataRow nrow1 = myds.Tables["Area"].NewRow();
            nrow1["地区"] = "";
            myds.Tables["Area"].Rows.InsertAt(nrow1, 0);
            DropDownList2.DataSource = myds.Tables["Area"];//设置学历下拉列表数据源
            DropDownList2.DataTextField = "地区";

            DropDownList2.DataBind();
            DropDownList2.SelectedValue = "";
            DropDownList3.Enabled = false;
            DropDownList4.Enabled = false;
            DropDownList5.Enabled = false;
        }

    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList3.Enabled = true;
        mysql = "SELECT distinct 省份 FROM Area WHERE 地区 = '"
            + DropDownList2.SelectedValue.ToString().Trim() + "'";
        myds = mydb.ExecuteQuery(mysql, "Area");
        DataRow nrow = myds.Tables["Area"].NewRow();          //插入一个空行
        nrow["省份"] = "";
        myds.Tables["Area"].Rows.InsertAt(nrow, 0);
        DropDownList3.DataSource = myds.Tables["Area"];
        DropDownList3.DataTextField = "省份";
        DropDownList3.DataBind();
        DropDownList4.Items.Clear();
        DropDownList5.Items.Clear();
    }

    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList4.Enabled = true;
        mysql = "SELECT distinct 市 FROM Area WHERE 省份 = '"
            + DropDownList3.SelectedValue.ToString().Trim() + "'";
        myds = mydb.ExecuteQuery(mysql, "Area");
        DataRow nrow = myds.Tables["Area"].NewRow();          //插入一个空行
        nrow["市"] = "";
        myds.Tables["Area"].Rows.InsertAt(nrow, 0);
        DropDownList4.DataSource = myds.Tables["Area"];
        DropDownList4.DataTextField = "市";
        DropDownList4.DataBind();
        DropDownList5.Items.Clear();
    }

    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList5.Enabled = true;
        mysql = "SELECT distinct 县 FROM Area WHERE 市 = '"
            + DropDownList4.SelectedValue.ToString().Trim() + "'";
        myds = mydb.ExecuteQuery(mysql, "Area");
        DataRow nrow = myds.Tables["Area"].NewRow();          //插入一个空行
        nrow["县"] = "";
        myds.Tables["Area"].Rows.InsertAt(nrow, 0);
        DropDownList5.DataSource = myds.Tables["Area"];
        DropDownList5.DataTextField = "县";
        DropDownList5.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string condstr = "有效否 Like  '%%'"; //是否有效均查询

        if (usernameTextBox.Text != "")
            condstr = " AND 用户名 Like '" + usernameTextBox.Text.Trim() + "%'";
        if (usernameTextBox.Text != "")
            condstr += " AND 年龄 Like '" + usernameTextBox.Text.Trim() + "%'";
        if (DropDownList1.SelectedValue.ToString().Trim() != "")
            condstr += " AND 学历 = '"
                + DropDownList1.SelectedValue.ToString().Trim() + "'";
        if (DropDownList2.SelectedValue.ToString().Trim() != "")
            condstr += " AND 地区 = '"
                + DropDownList2.SelectedValue.ToString().Trim() + "'";
        if (DropDownList3.SelectedValue.ToString().Trim() != "")
            condstr += " AND 省份= '"
                + DropDownList3.SelectedValue.ToString().Trim() + "'";
        if (DropDownList4.SelectedValue.ToString().Trim() != "")
            condstr += " AND 市 = '"
                + DropDownList2.SelectedValue.ToString().Trim() + "'";
        if (DropDownList5.SelectedValue.ToString().Trim() != "")
            condstr += " AND 县 = '"
                + DropDownList2.SelectedValue.ToString().Trim() + "'";
        if (usernameTextBox.Text != "")
            condstr += " AND 邮箱 Like '" + usernameTextBox.Text.Trim() + "%'";
        if (usernameTextBox.Text != "")
            condstr += " AND 电话 Like '" + usernameTextBox.Text.Trim() + "%'";


        mysql = "SELECT * FROM Customers WHERE " + condstr;
        Session["sql"] = mysql;
        Response.Redirect("killcustomer1.aspx");

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/dispinfo.aspx?info=欢迎您，管理员!");
    }
}