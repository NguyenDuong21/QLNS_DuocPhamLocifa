using QLNS_DuocPhamLocifa.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DuocPhamLocifa.BusinessLogicLayer
{
    public class DoiMatKhauBLL
    {
        DoiMatKhauDAL doiMatKhauDAL = new DoiMatKhauDAL();
        public bool changePassword(string tenTK, string matKhau)
        {
            return doiMatKhauDAL.changePassword(tenTK, matKhau);
        }
    }
}
