using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMain.DataBase_Connect
{
    
    class dbc
    {
        private static dbc instance;
        public static string cnn = @"Data Source =.; Initial Catalog = QL_TT_TOEIC_MY; Integrated Security = True";
        public static SqlConnection sql = null;
        public static dbc Instance
        {
            get { if (instance == null) instance = new dbc(); return dbc.instance; }
            private set { dbc.Instance = value; }
        }
        /// <summary>
        /// Hàm khởi tạo kết nối
        /// </summary>
        /// <returns>True/False</returns>
        public bool Con()
        {
            try
            {
                
                sql = new SqlConnection(cnn);
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
                return false;
            }
        }
        /// <summary>
        /// Đây là hàm trả về DataTable(Bảng) từ câu lệnh query(câu lệnh sql)
        /// </summary>
        /// <param name="query"> Đây là câu lệnh truy vấn</param>
        /// <returns>Hàm trả về một bảng</returns>
        public DataTable get(string query)
        {
            try
            {
                Clipboard.SetText(query);
                sql.Open();
                SqlDataAdapter sqld = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sqld.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
                return null;

            }
            finally
            {
                sql.Close();
            }
        }

        /// <summary>
        /// Đây là hàm trả về DataTable(Bảng) từ câu lệnh query(câu lệnh sql) nhưng có nhiều tham số
        /// </summary>
        /// <param name="query"> câu lệnh truy vấn</param>
        /// <param name="s"> không giới hạn tham số truyền vào , kiểu object</param>
        /// <returns>Hàm trả về một bảng</returns>
        public DataTable getParam(string query, params object[] s)
        {
            try
            {
                sql.Open();
                query += " ";
                string p = " , ";
                foreach (object c in s)
                {
                    if (c.ToString() != "")
                        query = query + " N' " + c + " ' " + p;
                    else
                        query = query + " null " + p;
                }
                query = query.Remove(query.LastIndexOf(","), 1);
                Clipboard.SetText(query);
                SqlDataAdapter sqld = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sqld.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
                return null;

            }
            finally
            {
                sql.Close();
            }
        }
        /// <summary>
        /// Hàm complie một câu truy vấn
        /// </summary>
        /// <param name="query"> câu truy vấn</param>
        /// <returns>Hàm trả về true ,false, true là thực hiện được và false là ngược lại</returns>
        public bool excute(string query)
        {
            try
            {
                sql.Open();
                Clipboard.SetText(query);
                SqlCommand cmd = new SqlCommand(query, sql);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
            finally
            {
                sql.Close();
            }
        }
        /// <summary>
        /// Hàm complie một câu truy vấn không giới hạn tham số
        /// </summary>
        /// <param name="query">Câu truy vấn</param>
        /// <param name="s">Không giới hạn tham số, kiểu object</param>
        /// <returns>Thực hiện một câu lệnh truy vấn, trả về true nếu thực hiện được, false nếu không</returns>
        public bool excuteParam(string query, params object[] s)
        {
            try
            {
                query += " ";
                sql.Open();
                string p = " , ";
                foreach (object c in s)
                {
                    if (c.ToString() != "")
                        query = query + " N' " + c + " ' " + p;
                    else
                        query = query + " null " + p;
                }
                query = query.Remove(query.LastIndexOf(","), 1);
                Clipboard.SetText(query);
                SqlCommand cmd = new SqlCommand(query, sql);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
            finally
            {
                sql.Close();
            }
        }
    }
}
