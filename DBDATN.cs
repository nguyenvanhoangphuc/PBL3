using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms; 

namespace ThiGK
{
    public class DBDATN
    {
        private static DBDATN _Instance;
        public static DBDATN Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DBDATN();
                }
                return _Instance;
            }
            private set { }
        }
        public DataTable DTDA { get; set; }
        private DBDATN()
        {
            DTDA = new DataTable();
            DTDA.Columns.AddRange(new DataColumn[]
            {
                new DataColumn{ColumnName = "STT",DataType = typeof(int)},
                new DataColumn{ColumnName = "MaDT",DataType = typeof(string)},
                new DataColumn{ColumnName = "TenDT",DataType = typeof(string) },
                new DataColumn{ColumnName = "SV",DataType = typeof(string) },
                new DataColumn{ColumnName = "HuongNC",DataType = typeof(string) },
                new DataColumn{ColumnName = "GVHD",DataType = typeof(string) },
                new DataColumn{ColumnName = "TT",DataType = typeof(bool) },
                new DataColumn{ColumnName = "NamBV",DataType = typeof(int) }
            }
            );
            DTDA.Rows.Add(0, "000", "DTA", "Nguyên", "TCA", "Phương", true, 2018);
            DTDA.Rows.Add(0, "111", "DTA", "Thọ", "TCA", "Quân", true, 2018);
            DTDA.Rows.Add(0, "222", "DTB", "Phúc", "TCB", "Phương", false, 2022);
            DTDA.Rows.Add(0, "333", "DTC", "Sang", "TCC", "Thắng", false, 2021);
            DTDA.Rows.Add(0, "444", "DTD", "Bình", "TCD", "Hoàng", false, 2019);
            DTDA.Rows.Add(0, "555", "DTE", "Tính", "TCE", "Thắng", true, 2019);
            DTDA.Rows.Add(0, "666", "DTB", "Lộc", "TCB", "Phương", false, 2022);
            DTDA.Rows.Add(0, "777", "DTC", "Nam", "TCC", "Thắng", false, 2021);
            DTDA.Rows.Add(0, "888", "DTD", "Nhân", "TCD", "Hoàng", false, 2019);
            DTDA.Rows.Add(0, "999", "DTE", "Hồng", "TCE", "Thắng", true, 2019);
        }
        public void AddRow(DATN s)
        {
            DTDA.Rows.Add(s.STT, s.MaDT, s.TenDT, s.SV, s.HuongNC, s.GVHD, s.TT, s.NamBV);
        }
        public void UpdateRow(DATN s)
        {
            foreach (DataRow dr in DTDA.Rows)
            {
                if (s.MaDT == dr["MaDT"].ToString())
                {
                    DTDA.Rows.Remove(dr);
                    break;
                }
            }
            DTDA.Rows.Add(s.STT, s.MaDT, s.TenDT, s.SV, s.HuongNC, s.GVHD, s.TT, s.NamBV);
        }
        public void DeleteRow(string s)
        {
            foreach (DataRow dr in DTDA.Rows)
            {
                if (s == dr["MaDT"].ToString())
                {
                    DTDA.Rows.Remove(dr);
                    break;
                }
            }
        }
    }
}
