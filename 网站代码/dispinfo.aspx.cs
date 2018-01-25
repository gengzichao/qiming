using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class dispinfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Request.QueryString["info"];//其他调用他的网页向它传递info字符串，然后在Label1中显示
    }
}

//例如：dispinfo.aspx?info="欢迎本系统"