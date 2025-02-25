using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DTO_QLBanHang;
using DAL_QLBanHang;

namespace UnittestQLBH
{
    [TestClass]
    public class UnitTest_QLBanHang : DBConnect
    {
        [TestMethod]
        public void NhanVienLogin_TC01()
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien login = new DAL_NhanVien();
            nv.EmailNV = "fpoly@fe.edu.vn";
            nv.MatKhau = "ABC";
            bool result = login.NhanVienDangNhap(nv);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void NhanVienLogin_TC02()
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien login = new DAL_NhanVien();
            nv.EmailNV = "fpoly@fe.edu.vn";
            nv.MatKhau = "23315424196402035621";
            bool result = login.NhanVienDangNhap(nv);
            Assert.IsTrue(result);
        }
    }
}