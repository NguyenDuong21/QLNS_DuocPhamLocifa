using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLNS_DuocPhamLocifa.BusinessLogicLayer;
using QLNS_DuocPhamLocifa.DataAccessLayer;
using System;

namespace UnitTestChangePass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_DoiMatKhau_Successfully()
        {
            DoiMatKhauDAL doiMatKhauDAL = new DoiMatKhauDAL();
            String tenTK = "duong";
            String matKhau = "1234567";
            bool expected = true;
            bool actual = doiMatKhauDAL.changePassword(tenTK, matKhau);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_DoiMatKhau_Does_Not_Exits()
        {
            DoiMatKhauDAL doiMatKhauDAL = new DoiMatKhauDAL();
            String tenTK = "hongphuc";
            String matKhau = "222222";
            bool expected = false;
            bool actual = doiMatKhauDAL.changePassword(tenTK, matKhau);
            Assert.AreEqual(expected, actual);
        }


    }
}
