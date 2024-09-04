﻿using QuanLyNhaSach.DLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.BLL
{
    public class BLLBaoCao
    {

        DataAccessPlayer DLLCon = new DataAccessPlayer();
        public DataTable GetDataBaoCao()
        {
            string query = "SELECT CHITIETHOADON.MASACH, SACH.TENSACH, SUM(CHITIETHOADON.SOLUONG) AS [SỐ LƯỢNG BÁN RA],  SACH.GIANHAP, SACH.GIABAN \r\nFROM CHITIETHOADON JOIN SACH ON CHITIETHOADON.MASACH = SACH.MASACH \r\nGROUP BY CHITIETHOADON.MASACH, SACH.TENSACH, SACH.GIANHAP, SACH.GIABAN\r\n";
            return DLLCon.GetTable(query);
        }
    }
}
