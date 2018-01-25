using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Customer_Orderform : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string ndds = Session["ndds"].ToString().Trim();
        string zsl = Session["zsl"].ToString().Trim();
        string zjr = Session["zjr"].ToString().Trim();
        string name = Session["name"].ToString().Trim();
        string sjrdz = Session["sjrdz"].ToString().Trim();
        string th = Session["th"].ToString().Trim();
        TextBox1.Text = "订单信息\r\n"
            + "订单编号：" + ndds + "\r\n"
            + "购买商品：一共购买" + zsl + "件商品，总金额为" + zjr + "元\r\n"
            + "收 件 人：" + name + "\r\n"
            + "送货地址：" + sjrdz + "\r\n"
            + "你的电话：" + th;

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/dispinfo.aspx?info=你可以查找商品继续购物!");
    }
}