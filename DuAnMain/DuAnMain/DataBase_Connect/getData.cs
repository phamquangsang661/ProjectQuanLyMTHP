using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnMain.DataBase_Connect
{
    class getData
    {
        /// <summary>
        /// Đây là hàm lấy toàn bộ danh sách khách hàng
        /// </summary>
        /// <returns></returns>
        public static DataTable getDsKhachHang()
        {
            DataTable dt = dbc.Instance.get("Select * from khachhang");
            return dt;
        }
        /// <summary>
        /// Đây là hàm lấy một khách hàng theo mã
        /// </summary>
        /// <param name="MaKH"> Mã khách hàng </param>
        /// <returns>hàm trả về một dòng duy nhất </returns>
        public static DataRow getKhachHangTheoMa(int MaKH)
        {
            DataRow r = dbc.Instance.get("select * from khachhang where MaKhachHang=" + MaKH).Rows[0];
            return r;
        }
        
    }
}
