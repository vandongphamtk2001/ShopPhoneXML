﻿using ShopPhone.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopPhone.Class
{
    class DoiMatKhau
    {

        DangNhap dn = new DangNhap();
        public bool KiemTraMK(string matKhauCu)
        {
            dn.kiemtraTTDN("TaiKhoan.xml", frmMain.tenDNMain, matKhauCu);
            return true;

        }
        public void Doi(string matKhauMoi)
        {

            dn.DoiMatKhau(frmMain.tenDNMain, matKhauMoi);
        }
    }
}
