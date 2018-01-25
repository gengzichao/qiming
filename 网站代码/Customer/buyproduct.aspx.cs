using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Customer_buyproduct : System.Web.UI.Page
{
    CommDB mydb = new CommDB();
    DataSet myds = new DataSet();
    string mysql;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            bind();
            if (GridView1.Rows.Count == 0) //数据行数为0
            {
                Label1.Text = "购物车无任何商品信息";
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
        int i;
        int zsl = 0;
        int zjr = 0;
        //更新Products表的数量
        for (i = 0; i < GridView1.Rows.Count; i++)
        {
            string spno = GridView1.Rows[i].Cells[0].Text.Trim();            //商品编号
            string gwsl = GridView1.Rows[i].Cells[7].Text.Trim();            //购物数量
            string money = GridView1.Rows[i].Cells[8].Text.Trim();
            Label1.Text = "数量" + gwsl;
            mysql = "UPDATE Products SET 库存数量 = 库存数量 - " + gwsl
                + "WHERE 商品编号 = '" + spno + "'";
            mydb.ExecuteNonQuery(mysql);

            zsl += int.Parse(gwsl);
            zjr += int.Parse(money);

        }
        Session["zsl"] = zsl;
        Session["zjr"] = zjr;
        //求订单编号
        mysql = "SELECT COUNT( * ) FROM (SELECT distinct 订单号 FROM Sales) tmp";
        string dds = mydb.ExecuteAggregateQuery(mysql);                     //求订单数
        string ndds = (int.Parse(dds) + 1).ToString();                      //新订单编号
        Session["ndds"] = ndds;
        //将订单的顾客信息插入OrderForm(顾客信息)表
        string name, dq, sf, cs, xm, dz, yx, th;
        mysql = "SELECT 姓名,地区,省份,市,县,住址,邮箱,电话 FROM Customers " +
            "WHERE 用户名 = '" + Session["uname"] + "'";
        myds = mydb.ExecuteQuery(mysql, "Customers");
        DataRow mydr = myds.Tables["Customers"].Rows[0];//获取查询结果第一行
        name = mydr["姓名"].ToString().Trim();
        dq = mydr["地区"].ToString().Trim();
        sf = mydr["省份"].ToString().Trim();
        cs = mydr["市"].ToString().Trim();
        xm = mydr["县"].ToString().Trim();
        dz = mydr["住址"].ToString().Trim();
        yx = mydr["邮箱"].ToString().Trim();
        th = mydr["电话"].ToString().Trim();
        Session["name"] = name;                        //收件人姓名
        Session["sjrdz"] = sf + cs + xm + dz;          //收件人地址
        Session["th"] = th;
        mysql = "INSERT INTO OrderForm(订单号,日期,用户名,姓名,地区,省份,市,县,住址,邮箱,电话,总数量,总金额,处理否,结算否) VALUES("
            + ndds + ",'" + DateTime.Now + "','" + Session["uname"] + "','"
            + name + "','" + dq + "','" + sf + "','" + cs + "','"
            + xm + "','" + dz + "','" + yx + "','" + th + "',"
            + Session["zsl"] + "," + Session["zjr"] + ",0,0)";
        Label1.Text = mysql;
        mydb.ExecuteNonQuery(mysql);
        //将购物车全部信息移动到Sales中
        for (i = 0; i < GridView1.Rows.Count; i++)
        {
            mysql = "INSERT INTO Sales(订单号,日期,用户名,商品编号,分类,子类,品牌,型号,单价,数量,金额) "
                + "VALUES ( " + ndds + ",'"
                + DateTime.Now + "','"
                + Session["uname"] + "','"
                + GridView1.Rows[i].Cells[0].Text.Trim() + "','"
                + GridView1.Rows[i].Cells[1].Text.Trim() + "','"
                + GridView1.Rows[i].Cells[2].Text.Trim() + "','"
                + GridView1.Rows[i].Cells[3].Text.Trim() + "','"
                + GridView1.Rows[i].Cells[4].Text.Trim() + "',"
                + GridView1.Rows[i].Cells[5].Text.Trim() + ","
                + GridView1.Rows[i].Cells[7].Text.Trim() + ","
                + GridView1.Rows[i].Cells[8].Text.Trim() + ")";
                mydb.ExecuteNonQuery(mysql);
        }
        mysql = "DELETE ShoppingCart  WHERE 用户名 = '" + Session["uname"] + "'";
        mydb.ExecuteNonQuery(mysql);
        Response.Redirect("Orderform.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/dispinfo.aspx?info=购物车快空了快去转转吧");

    }
}