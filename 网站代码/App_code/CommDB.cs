using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// CommDB 的摘要说明
/// </summary>
public class CommDB
{
	public CommDB()
	{
	}
    //返回sql执行后记录的行数
    public int Rownum(String sql)
    {
        int i = 0;
        string mystr = System.Configuration.ConfigurationManager.ConnectionStrings["myconnstring"].ToString();
        //从web.config文件获取连接字符串
        SqlConnection myconn = new SqlConnection();
        myconn.ConnectionString = mystr;
        myconn.Open();
        SqlCommand mycmd = new SqlCommand(sql, myconn);
        SqlDataReader myreader = mycmd.ExecuteReader();
        while (myreader.Read())
        { i++; }
        myconn.Close();
        return i;
    }

    //执行sql语句，返回是否成功执行
    public Boolean ExecuteNonQuery(String sql)
    {
        string mystr = System.Configuration.ConfigurationManager.ConnectionStrings["myconnstring"].ToString();
        SqlConnection myconn = new SqlConnection();
        myconn.ConnectionString = mystr;
        myconn.Open();
        SqlCommand mycmd = new SqlCommand(sql, myconn);
        try
        {
            mycmd.ExecuteNonQuery();
            myconn.Close();
        }
        catch
        {
            myconn.Close();
            return false;
        }
        return true;
    }

    //执行SELECT语句，返回dataset对象
    public DataSet ExecuteQuery(string sql, string tname)
    {
        string mystr = System.Configuration.ConfigurationManager.ConnectionStrings["myconnstring"].ToString();
        SqlConnection myconn = new SqlConnection();
        myconn.ConnectionString = mystr;
        myconn.Open();
        SqlDataAdapter myda = new SqlDataAdapter(sql, myconn);
        DataSet myds = new DataSet();
        myda.Fill(myds, tname);
        myconn.Close();
        return myds;
    }

    //执行select语句，返回聚合函数结果
    public string ExecuteAggregateQuery(string sql)
    {
        string jg;
        string mystr = System.Configuration.ConfigurationManager.ConnectionStrings["myconnstring"].ToString();
        SqlConnection myconn = new SqlConnection();
        myconn.ConnectionString = mystr;
        myconn.Open();
        SqlCommand mycmd = new SqlCommand();
        mycmd.CommandText = sql;
        mycmd.Connection = myconn;
        jg = mycmd.ExecuteScalar().ToString();
        myconn.Close();
        return jg;
    }

    //实现随机验证码：返回生成的随机数 n为验证码的位数
    public string RandomNum(int n) 
    {
        string strchar = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,"+"I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,";
        string[] arry = strchar.Split(',');
        string num = "";
        int temp = -1;
        Random rand = new Random();
        for (int i = 1; i < n + 1; i++)
        {
            if (temp != -1)
            {
                rand = new Random(i * temp * unchecked((int)DateTime.Now.Ticks));
            }
            int t = rand.Next(35);//返回一个小于指定最大值的非负随机数
            if(temp!=-1&&temp == t)
                return RandomNum(n);
            temp = t;
            num += arry[t];
        }
        return num;
    }

}