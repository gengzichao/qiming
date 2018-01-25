using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Customer_updatecustomerinfo : System.Web.UI.Page
{
    CommDB mydb = new CommDB();
    DataSet myds = new DataSet();
    string mysql;

    protected void Page_Init(object sender, EventArgs e)
    {

    }
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
        if (Page.IsValid)
        {

            mysql = "UPDATE Customers SET 姓名 = '" + xmTextBox.Text.Trim() + "',"
                + "年龄 = " + ageTextBox.Text + "," + "学历 = '" + DropDownList1.SelectedValue.ToString().Trim() + "',"
                + "地区 = '" + DropDownList2.SelectedValue.ToString().Trim() + "',"
                + "省份 = '" + DropDownList3.SelectedValue.ToString().Trim() + "',"
                + "市 = '" + DropDownList4.SelectedValue.ToString().Trim() + "',"
                + "县 = '" + DropDownList5.SelectedValue.ToString().Trim() + "',"
                + "住址 = '" + placeTextBox.Text.Trim() + "',"
                + "邮箱 = '" + EmailTextBox.Text.Trim() + "',"
                + "电话 = '" + TelTextBox.Text.Trim() + "', 有效否 =  '1'" 
                + " WHERE 用户名 = '" + Session["uname"] + "'";
                mydb.ExecuteNonQuery(mysql);
                Response.Redirect("~/dispinfo.aspx?info=更改信息成功!");
            
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/dispinfo.aspx?info=欢迎光临网站!");
    }

}