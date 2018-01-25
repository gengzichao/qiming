using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Customer_editShopping : System.Web.UI.Page
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

        mysql = "SELECT * FROM ShoppingCart WHERE 用户名 = '" + Session["uname"] + "'";
        myds = mydb.ExecuteQuery(mysql, "ShoppingCart");
        GridView1.DataSource = myds.Tables["ShoppingCart"];
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
        
        TextBox slBox;
        int i, sl, kcsl;
        for (i = 0; i < GridView1.Rows.Count; i++)
        {

            slBox = GridView1.Rows[i].FindControl("TextBox1") as TextBox;  //寻找TextBox1控件
            sl = int.Parse(slBox.Text.Trim());                         //提取输入的数量
            
            

   
            mysql = "SELECT 库存数量 FROM Products WHERE 商品编号 = " + GridView1.Rows[i].Cells[0].Text.ToString();
            myds = mydb.ExecuteQuery(mysql, "Products");
            kcsl = int.Parse(myds.Tables[0].Rows[0][0].ToString());
            if (sl < 0 || sl > kcsl)
                return true;
            
        }
        return false;
    }
                

    protected void savedata()
    {
        string spno;
        TextBox slBox;
        Image imgBox;
        int sl;

        mysql = "DELETE FROM ShoppingCart WHERE 用户名 = '" + Session["uname"] + "'";
        mydb.ExecuteNonQuery(mysql);

        int i;
        for (i = 0; i < GridView1.Rows.Count; i++)
        {
            slBox = GridView1.Rows[i].FindControl("TextBox1") as TextBox;  //寻找TextBox1控件
            sl = int.Parse(slBox.Text.Trim());
            if(sl > 0)
            {
                spno = GridView1.Rows[i].Cells[0].Text.Trim();          //获取商品编号
                imgBox = GridView1.Rows[i].FindControl("Image1") as Image;
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
                mydb.ExecuteNonQuery(mysql);
                mysql = "UPDATE ShoppingCart SET 金额 = 数量 * 单价 "
                    + "WHERE 用户名 = '" + Session["uname"]
                    + "'AND 商品编号 = '" + spno + "'";
                mydb.ExecuteNonQuery(mysql);
            }
        }
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