using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Manager_systeminit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        deltable("Area");
        deltable("Comment");
        deltable("Customers");
        deltable("Education");
        deltable("OrderForm");
        deltable("ProdType");
        deltable("Products");
        deltable("Sales");
        deltable("ShoppingCart");
        delusertable("Users");
        delpicture();
        Response.Redirect("~/dispinfo.aspx?info=系统初始化完毕!下次以system/manager管理员身份登录");
    }

    public void deltable(string tname)
    {
        CommDB mydb = new CommDB();
        string mysql;
        mysql = "DELETE " + tname;
        mydb.ExecuteNonQuery(mysql);
    }

    public void delusertable(string tname)
    {
        CommDB mydb = new CommDB();
        string mysql;
        mysql = "DELETE " + tname;
        mydb.ExecuteNonQuery(mysql);
        mysql = "INSERT INTO Users(用户名,密码,类型,有效否) VALUES('system','manager','管理员','1')";
        mydb.ExecuteNonQuery(mysql);
    }
    
    public void delpicture()
    {
        string path = Server.MapPath("~/Picture");
        if (Directory.GetFileSystemEntries(path).Length > 0)
        {
            foreach (string file in Directory.GetFiles(path))
            {
                if (File.Exists(file))
                    File.Delete(file);
            }
        }
    }



    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/dispinfo.aspx?info=欢迎您，管理员");
    }
}