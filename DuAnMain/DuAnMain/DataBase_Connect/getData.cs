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
        public static DataTable getDsKhachHang()
        {
            DataTable dt = dbc.Instance.get("Select * from khachhang");
            return dt;
        }

    }
}
