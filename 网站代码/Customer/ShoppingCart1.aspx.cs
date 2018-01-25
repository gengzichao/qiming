using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Customer_ShoppingCart1 : System.Web.UI.Page
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
        if (checkerror())
        {
            Label1.Text = "错误提示：你选择的商品数量不正确，重新输入";
            return;
        }
        savedata();
        Response.Redirect("~/dispinfo.aspx?info=你选择的商品已经保存在购物车中!");
    }

    protected bool checkerror()
    {
        CheckBox xzBox;      //复选框对象
        TextBox slBox;
        int i, sl, kcsl;
        for (i = 0; i < GridView1.Rows.Count; i++)
        {
            xzBox = GridView1.Rows[i].FindControl("CheckBox1") as CheckBox;//寻找CheckBox1控件
            slBox = GridView1.Rows[i].FindControl("TextBox1") as TextBox;  //寻找TextBox1控件
            if (xzBox.Checked)
            {
                sl = int.Parse(slBox.Text.Trim());                         //提取输入的数量
                Label1.Text = sl.ToString();
                kcsl = int.Parse(GridView1.Rows[i].Cells[8].Text.Trim());  //提取库存数量
                if (sl <= 0)
                    return true;
                if (sl > kcsl)
                    return true;
            }
        }
        return false;   
    }

    protected void savedata()
    {
        string spno;
        CheckBox xzBox;
        TextBox slBox;
        Image imgBox;

        int i;
        for (i = 0; i < GridView1.Rows.Count; i++)
        {

            xzBox = GridView1.Rows[i].FindControl("CheckBox1") as CheckBox;//寻找CheckBox1控件
            slBox = GridView1.Rows[i].FindControl("TextBox1") as TextBox;  //寻找TextBox1控件
            if (xzBox.Checked)
            { 
                spno = GridView1.Rows[i].Cells[0].Text.Trim();          //获取商品编号
                imgBox = GridView1.Rows[i].FindControl("Image") as Image;
                if (inCart(spno))
                {
                    mysql = "UPDATE ShoppingCart SET 数量 = 数量 + "
                        + slBox.Text.Trim()
                        + "WHERE 用户名 = '" + Session["uname"]
                        + "'AND 商品编号 = '" + spno + "'";
                }
                else 
                {
                    string f1 = GridView1.Rows[i].Cells[1].Text.Trim();
                    string f2 = GridView1.Rows[i].Cells[2].Text.Trim();
                    string f3 = GridView1.Rows[i].Cells[3].Text.Trim();
                    string f4 = GridView1.Rows[i].Cells[4].Text.Trim();
                    string f5 = GridView1.Rows[i].Cells[5].Text.Trim();
                    string f6 = imgBox.ImageUrl;
                    string f7 = slBox.Text.Trim();
                    mysql = "INSERT INTO ShoppingCart(用户名,商品编号,分类,子类,品牌,型号,单价,图片,数量) VALUES('" + Session["uname"] + "','"
                        + spno + "','" + f1 + "','" + f2 + "','"
                        + f3 + "','" + f4 + "','" + f5 + "','"
                        + f6 + "'," + f7 + ")";
                    
                }
                mydb.ExecuteNonQuery(mysql);
                mysql = "UPDATE ShoppingCart SET 金额 = 数量 * 单价 "
                    + "WHERE 用户名 = '" + Session["uname"]
                    + "' AND 商品编号 = '" + spno + "'";
                mydb.ExecuteNonQuery(mysql); 
            }
        }
    }

    protected bool inCart(string spno)
    {
        int i;
        mysql = "SELECT * FROM ShoppingCart WHERE 用户名 = '"
            + Session["uname"] + "'AND 商品编号 = '" + spno + "'";
        i = mydb.Rownum(mysql);
        if(i>0)
            return true;
        else
            return false;

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