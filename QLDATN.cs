using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms; 

namespace ThiGK
{
    public class QLDATN
    {
        public List<DATN> GetAllDATN()
        {
            List<DATN> list = new List<DATN>();
            foreach (DataRow dr in DBDATN.Instance.DTDA.Rows)
            {
                list.Add(GetDATNByDataRow(dr));
            }
            return list;
        }
        private DATN GetDATNByDataRow(DataRow dr)
        {
            DATN DATN = new DATN
            {
                STT = Convert.ToInt32(dr["STT"].ToString()),
                MaDT = dr["MaDT"].ToString(),
                TenDT = dr["TenDT"].ToString(),
                SV = dr["SV"].ToString(),
                HuongNC = dr["HuongNC"].ToString(),
                GVHD= dr["GVHD"].ToString(),
                TT = Convert.ToBoolean(dr["TT"].ToString()),
                NamBV = Convert.ToInt32(dr["NamBV"].ToString())
            };
            return DATN;
        }
        public List<string> GetAllHuongNC()
        {
            List<string> list = new List<string>();
            foreach (DATN da in GetAllDATN())
            {
                list.Add(da.HuongNC.ToString());
            }
            return list;
        }
        public List<string> GetAllTT()
        {
            List<string> list = new List<string>();
            foreach (DATN da in GetAllDATN())
            {
                list.Add(da.TT.ToString());
            }
            return list;
        }
        public List<string> GetAllGVHD()
        {
            List<string> list = new List<string>();
            foreach (DATN da in GetAllDATN())
            {
                list.Add(da.GVHD.ToString());
            }
            return list;
        }
        public List<string> GetAllNamBV()
        {
            List<string> list = new List<string>();
            foreach (DATN da in GetAllDATN())
            {
                list.Add(da.NamBV.ToString());
            }
            return list;
        }
        public List<DATN> GetDATNByGT(string hNC, string tt, string gvhd, string txt = "")
        {
            List<DATN> data = new List<DATN>();
            List<DATN> dtHNC = new List<DATN>();
            if (hNC == "All")
            {
                foreach (DATN da in GetAllDATN())
                {
                    dtHNC.Add(da);
                }
            }
            else
            {
                foreach (DATN da in GetAllDATN())
                {
                    if (da.HuongNC == hNC)
                    {
                        dtHNC.Add(da);
                    }
                }
            }
            List<DATN> dtTT = new List<DATN>();

            if (tt == "All")
            {
                foreach (DATN da in dtHNC)
                {
                    dtTT.Add(da);
                }
            }
            else
            {
                foreach (DATN da in dtHNC)
                {
                    if (da.TT == Convert.ToBoolean(tt))
                    {
                        dtTT.Add(da);
                    }
                }
            }
            //gvhd
            if (gvhd == "All")
            {
                foreach (DATN da in dtTT)
                {
                    if (da.TenDT.Contains(txt))
                    data.Add(da);
                }
            }
            else
            {
                foreach (DATN da in dtTT)
                {
                    if (da.GVHD == gvhd && da.TenDT.Contains(txt))
                    {
                        data.Add(da);
                    }
                }
            }
            return data;
        }
        public List<string> GetGVHDByHuongNC(string hnc)
        {
            List<string> data = new List<string>();
            foreach (DATN da in GetAllDATN())
            {
                if (da.HuongNC == hnc)
                {
                    data.Add(da.GVHD); 
                }
            }
            return data;
        }
        private bool AddUpdate(string ma)
        {
            bool Add = true;
            foreach (DATN da in GetAllDATN())
            {
                if (da.MaDT == ma)
                {
                    Add = false;
                    break;
                }
            }
            return Add;
        }
        public void ExecuteDB(DATN dt)
        {
            if (AddUpdate(dt.MaDT))
            {
                DBDATN.Instance.AddRow(dt);
            }
            else
            {
                DBDATN.Instance.UpdateRow(dt);
            }
        }
        public DATN GetDTByMaDT(string MaDT)
        {
            DATN dt = new DATN();
            foreach (DATN da in GetAllDATN())
            {
                if (da.MaDT == MaDT)
                {
                    dt = da;
                    break; 
                }
            }
            return dt;
        }
        public void DelDA(List<string> data)
        {
            foreach (string s in data)
            {
                DBDATN.Instance.DeleteRow(s);
            }
        }
    }
}
