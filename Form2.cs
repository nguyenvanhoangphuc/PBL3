using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiGK
{
    public partial class Form2 : Form
    {
        public delegate void myDel(string hNC, string tt, string gvhd, string txt ="");
        public myDel d { get; set; }
        private QLDATN bll = new QLDATN();
        public string MaDT { get; set; }
        public Form2(string mdt)
        {
            InitializeComponent();
            MaDT = mdt;
            // dữ liệu trống nếu là add
            cbbHuongNC.Items.AddRange(bll.GetAllHuongNC().Distinct().ToArray());
            cbbNamBV.Items.AddRange(bll.GetAllNamBV().Distinct().ToArray());
            GUI();
        }
        private void GUI()
        {
            if (MaDT != "")
            {
                txtMaDT.Text = MaDT;
                txtMaDT.Enabled = false; 
                txtDT.Text = bll.GetDTByMaDT(MaDT).TenDT;
                txtSV.Text = bll.GetDTByMaDT(MaDT).SV; 
                rbutBV.Checked = bll.GetDTByMaDT(MaDT).TT;
                rbutCBV.Checked = !(bll.GetDTByMaDT(MaDT).TT);
                cbbHuongNC.Text = bll.GetDTByMaDT(MaDT).HuongNC;
                cbbGVHD.Text = bll.GetDTByMaDT(MaDT).GVHD;
                cbbNamBV.Text = bll.GetDTByMaDT(MaDT).NamBV.ToString();
            }
        }

        private void cbbHuongNC_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbGVHD.Items.Clear();
            cbbGVHD.Text = "";
            cbbGVHD.Items.AddRange(bll.GetGVHDByHuongNC(cbbHuongNC.Text).Distinct().ToArray());
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            if (txtMaDT.Text != "")
            {
                DATN dt = new DATN
                {
                    STT = 0,
                    MaDT = txtMaDT.Text,
                    TenDT = txtDT.Text,
                    SV = txtSV.Text,
                    HuongNC = cbbHuongNC.Text,
                    GVHD = cbbGVHD.Text,
                    TT = rbutBV.Checked,
                    NamBV = Convert.ToInt32(cbbNamBV.Text)
                };
                bll.ExecuteDB(dt);
                d("All", "All", "All");
            }
            this.Close();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
