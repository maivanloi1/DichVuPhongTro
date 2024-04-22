using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BD10_DichVuPhongTro
{
    public static class DBClass
    {
        public static SqlConnection OpenConn()
        {
            SqlConnection myCon = new SqlConnection(ConfigurationManager.ConnectionStrings["localConnection"].ConnectionString);
            myCon.Open();
            return myCon;
        }
    }
}