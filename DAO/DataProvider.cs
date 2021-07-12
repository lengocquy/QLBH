using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanXe.DAO
{
    public class DataProvider
    {
        SqlConnection connection;
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance;
            }
            private set
            {
                DataProvider.instance = value;
            }
        }
        public DataProvider() {
            connection = new SqlConnection(connectionStr);
        }
        public void Connect()
        {
            try
            {
                if (connection != null && connection.State == ConnectionState.Closed)
                    connection.Open();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void Disconnect()
        {

            if (connection != null && connection.State == ConnectionState.Open)
                connection.Close();

        }

        // thay chuỗi này nếu chạy ở máy khác
        private string connectionStr = @"Data Source=.\SQLEXPRESSR;Initial Catalog=QuanLyBanXeOTO;Integrated Security=True";

        

        /*---------------------------------lỗi phát sinh---------------
         câu Query phải , . đàng hoàng
             */

        // trả ra Nguyên 1 Table
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {

            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);


                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }


                SqlDataAdapter adapter = new SqlDataAdapter(command);
                
                    

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }

        // trả về số lượng này nọ. trả ra số dòng thành công khi Inser,update,delete
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);


                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        // trả về cái dòng đầu tiên VD như select count(*)
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);


                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
        public SqlDataReader myExecuteReader(string query)
        {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                Connect();
                try
                {
                    return cmd.ExecuteReader();
                }
                catch (SqlException ex)
                {

                    throw ex;
                }
                
                
            
        }
    }
}
