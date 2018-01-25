using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Operator_receiptprocess : System.Web.UI.Page
{
    string mysql;
    CommDB mydb = new CommDB();
    DataSet myds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            bind();
            if (GridView1.Rows.Count == 0) //数据行数为0
            {
                Label1.Text = "没有订单信息";
                Button1.Visible = false;
            }
            else
            {
                Button2.Visible = false;
            }
        }
    }

    public void bind()
    {
        mysql = "SELECT * FROM OrderForm";
        myds = mydb.ExecuteQuery(mysql, "OrderForm");
        GridView1.DataSource = myds.Tables["OrderForm"];
        GridView1.DataBind();//在GridView1中显示记录
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        savedata();
        Response.Redirect("~/dispinfo.aspx?info=订单结算信息已经保存!");
    }

    protected void savedata()
    {

        CheckBox chBox;
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            string f1 = GridView1.Rows[i].Cells[0].Text.Trim();
            chBox = GridView1.Rows[i].FindControl("CheckBox1") as CheckBox;
            bool b1 = chBox.Checked;

            mysql = "UPDATE OrderForm SET 结算否 =  '" + b1 + "'"
                    + "WHERE 用户名 = '" + f1 + "'";
            mydb.ExecuteNonQuery(mysql);

        }
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/dispinfo.aspx?info = 欢迎使用本系统!");
    }



}