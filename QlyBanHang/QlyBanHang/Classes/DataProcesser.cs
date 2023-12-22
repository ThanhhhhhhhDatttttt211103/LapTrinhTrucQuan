using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyBanHang.Classes
{
    internal class DataProcesser
    {
        string connectStr = "Data Source=(local);Initial Catalog=LTTQ_BanHang;Integrated Security=True";
        SqlConnection sqlconn = null;

        //PT Mở kết  nối
        void OpenConnect()
        {
            sqlconn = new SqlConnection(connectStr);
            if(sqlconn.State != ConnectionState.Open)
            {
                sqlconn.Open();
            }
        }
        //PT dong ket noii
        void CloseConnect()
        {
            if (sqlconn.State != ConnectionState.Closed)
            {
                sqlconn.Close();
                sqlconn.Dispose();
            }
        }

        //Pt dọc dữ liệu
        public DataTable ReadData(string sqlSelect)
        {
            DataTable dt = new DataTable();
            OpenConnect();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlSelect, sqlconn);
            dataAdapter.Fill(dt);
            CloseConnect();
            dataAdapter.Dispose();
            return dt;
        }
        //PT cập nhật (thêm, sửa xóa dữ liệu)
        public void ChangeData(string sql)
        {
            OpenConnect();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlconn;
            sqlCommand.CommandText = sql;
            sqlCommand.ExecuteNonQuery();
            CloseConnect();
            sqlCommand.Dispose();
        }
    }
}
