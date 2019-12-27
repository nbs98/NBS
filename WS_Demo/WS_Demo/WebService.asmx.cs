using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace WS_Demo
{

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class WebService : System.Web.Services.WebService
    {
        public static SqlConnection connect;
        public static string link = @"Data Source=XNBS\SQLEXPRESS;Initial Catalog=Webservice_Demo;Integrated Security=True";
        public static SqlCommand command;
        public static DataTable dt = new DataTable("Show TT");
        public static SqlDataAdapter adapter = new SqlDataAdapter();
        [WebMethod]
        public DataTable ShowTT()
        {
            connect = new SqlConnection(link);
            connect.Open();
            command = connect.CreateCommand();
            command.CommandText = "SELECT * FROM SinhVien";
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            connect.Close();
            adapter.Dispose();
            return dt;
        }
        [WebMethod]
        public void themsuaxoa(string sql)
        {
            connect = new SqlConnection(link);
            connect.Open();
            command = connect.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery();
            connect.Close();
        }
        [WebMethod]
        public DataTable TimKiem(string msv)
        {
            connect = new SqlConnection(link);
            connect.Open();
            command = connect.CreateCommand();
            command.CommandText = "SELECT * FROM SinhVien WHERE masv = '"+msv+"'";
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            connect.Close();
            adapter.Dispose();
            return dt;
        }
    }
}
