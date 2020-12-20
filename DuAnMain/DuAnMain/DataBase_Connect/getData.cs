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
        /// <summary>
        /// Đây là hàm lấy ghi chú theo mã 
        /// </summary>
        /// <param name="MaKH">Mã khách hàng</param>
        /// <returns>Hàm trả về một bảng</returns>
        public static DataTable getGhiChuKhachHangTheoMa(int MaKH)
        {
            DataTable r = dbc.Instance.get("Select * from GhiChuKhachHang where MaKhachhang=" + MaKH);
            return r;
        }
        /// <summary>
        /// Đây là hàm lấy nhân viên theo mã tài khoản
        /// </summary>
        /// <param name="MaTK">Mã Tài khoản</param>
        /// <returns>Hàm trả về một dòng duy nhất</returns>
        public static DataRow getNhanVienTheoMaTaiKhoan(int MaTK)
        {
            DataRow r = dbc.Instance.get("Select * from nhanvien where MaTaiKhoan=" + MaTK).Rows[0];
            return r;
        }
        /// <summary>
        /// Đây là hàm lấy đơn sửa theo mã khách hàng
        /// </summary>
        /// <param name="MaKH"> Mã khách hàng</param>
        /// <returns>Hàm trả về một bảng</returns>
        public static DataTable getDonSuaTheoMaKhachHang(int MaKH)
        {
            DataTable r = dbc.Instance.get("Select * from donsua where MaKhachHang=" + MaKH);
            return r; 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="MaCN"></param>
        /// <returns></returns>
        public static DataRow getChiNhanhTheoMaChiNhanh(int MaCN)
        {
            DataRow r = dbc.Instance.get("Select * from chinhanh where MaChiNhanh=" + MaCN).Rows[0];
            return r;
        }
        public static DataRow getQuyTrinhTheoMaQuyTrinh(int MaQT)
        {
            DataRow r = dbc.Instance.get("select * from QuyTrinhSuaMay where MaQuyTrinh=" + MaQT).Rows[0];
            return r;
        }
        public static DataTable getDonSuaKhaiQuatTheoMaKhachHang(int MaKH)
        {
            DataTable r = dbc.Instance.get(@"select MaDonSua, TenChiNhanh,NgaySua,NgayTra,TenNV,MaQuyTrinh
                                        from 
                                            donsuamay inner join chinhanh on donsuamay.MaChiNhanh=chinhanh.MaChiNhanh
                                            inner join nhanvien on nhanvien.MaNV=donsuamay.MaNV where MaKhachHang=" + MaKH);
            return r;
        }
    }
}
