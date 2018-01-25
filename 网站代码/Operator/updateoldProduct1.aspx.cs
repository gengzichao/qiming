using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Operator_updateoldProduct1 : System.Web.UI.Page
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
                Label1.Text = "没有任何满足条件的商品信息";
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

        mysql = Session["sql"].ToString();
        myds = mydb.ExecuteQuery(mysql, "Products");
        GridView1.DataSource = myds.Tables["Products"];
        //GridView1.DataKeyNames = new string[] { "商品编号" };
        GridView1.DataBind();                               //在GridView1中显示满足查询条件的记录
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
    
        savedata();
        Response.Redirect("~/dispinfo.aspx?info=旧商品信息更新完毕!");
    }

   


    protected void savedata()
    {
        string spno;                //商品编号
        TextBox djtxt;              //单价文本框
        TextBox addkctxt;           //增加库存文本框
        int sl;

       

        int i;
        for (i = 0; i < GridView1.Rows.Count; i++)
        {
           
                spno = GridView1.Rows[i].Cells[0].Text.Trim();          //获取商品编号
                djtxt = GridView1.Rows[i].FindControl("TextBox1") as TextBox;
                addkctxt = GridView1.Rows[i].FindControl("TextBox2") as TextBox;
                Update(spno, djtxt.Text.Trim(), addkctxt.Text.Trim());
           
        }
    }

    public void Update(string spno ,string dj,string addkc)
    {
        mysql = "UPDATE Products SET 单价= " + dj + ",库存数量 = 库存数量 + " + addkc + " WHERE 商品编号 = '" + spno + "'";
        mydb.ExecuteNonQuery(mysql);
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        e.Cancel = true;
        string spbh = GridView1.DataKeys[e.NewEditIndex][0].ToString().Trim();
        Response.Redirect("dispcomment.aspx?spbh " + spbh);
    }



    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/dispinfo.aspx?info = 欢迎使用本系统!");
    }
}