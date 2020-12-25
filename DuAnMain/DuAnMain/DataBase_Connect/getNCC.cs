using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnMain.DataBase_Connect
{
    class getNCC
    {
        public static DataTable getDsNCC()
        {
            DataTable dt = dbc.Instance.get("Select * from nhacungcap");
            return dt;
        }
    }
}
