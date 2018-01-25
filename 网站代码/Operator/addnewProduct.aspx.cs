using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Operator_addnewProduct : System.Web.UI.Page
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
       


            mysql = "SELECT distinct 分类 FROM ProdType";
            myds = mydb.ExecuteQuery(mysql, "ProdType");
            DataRow nrow1 = myds.Tables["ProdType"].NewRow();
            nrow1["分类"] = "";
            myds.Tables["ProdType"].Rows.InsertAt(nrow1, 0);
            DropDownList1.DataSource = myds.Tables["ProdType"];//设置学历下拉列表数据源
            DropDownList1.DataTextField = "分类";

            DropDownList1.DataBind();
            DropDownList1.SelectedValue = "";
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
        if (Page.IsValid)
        {
            int i;
            mysql = "SELECT * FROM Products WHERE 商品编号 = '" + bhTextBox.Text + "'";
            i = mydb.Rownum(mysql);
            if (i > 0)
                Label1.Text = "商品编号重复，不能添加该商品记录！";
            else
            {
                string filestr;
                if (FileUpload1.HasFile)
                {
                    filestr = Server.MapPath("/") + "Picture\\" + FileUpload1.FileName;
                    try
                    {
                        FileUpload1.SaveAs(filestr);
                        Label1.Text = "提示:文件成功上传";
                            
                    }
                    catch (Exception ex)
                    {
                        Label1.Text = "提示:文件上传失败," + ex.Message;
                    }
                }
                else
                {
                    Label1.Text = "提示:没有指定要上传的任何文件";
                }
                mysql = "INSERT INTO Products(商品编号,分类,子类,品牌,型号,单价,库存数量,图片,有效否,星数,评论数) VALUES('"
                    + bhTextBox.Text.Trim() + "','"
                    + DropDownList1.SelectedValue.ToString().Trim() + "','"
                    + DropDownList2.SelectedValue.ToString().Trim() + "','"
                    + DropDownList3.SelectedValue.ToString().Trim() + "','"
                    + xhTextBox.Text.Trim() + "',"
                    + priceTextBox.Text.Trim() + ","
                    + numTextBox.Text.Trim() + ",'"
                    + "~//Pictrue//" + FileUpload1.FileName.Trim() + "','"
                    + "1',0,0)";
                mydb.ExecuteNonQuery(mysql);
                Response.Redirect("~/dispinfo.aspx?info=新型号的商品已添加");
            }

        }
        else
        {
            Label1.Text = "提示：商品信息错误，不能添加";
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/dispinfo.aspx?info=欢迎您，操作员");
    }
}