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
    public partial class Form1 : Form
    {
        private QLDATN bll = new QLDATN();
        public Form1()
        {
            InitializeComponent();
            cbbHuongNC.Items.Add("All");
            cbbGVHD.Items.Add("All");
            cbbTT.Items.Add("All");
            cbbHuongNC.Items.AddRange(bll.GetAllHuongNC().Distinct().ToArray());
            cbbTT.Items.AddRange(bll.GetAllTT().Distinct().ToArray());
            cbbHuongNC.SelectedIndex = 0;
            cbbTT.SelectedIndex = 0;
            ShowDTG("All", "All", "All"); 
            dataGridView1.Columns[0].HeaderText = "Số thứ tự";
            dataGridView1.Columns[1].HeaderText = "Mã đồ án";
            dataGridView1.Columns[2].HeaderText = "Tên đề tài";
            dataGridView1.Columns[3].HeaderText = "SV thực hiện";
            dataGridView1.Columns[4].HeaderText = "Hướng NC";
            dataGridView1.Columns[5].HeaderText = "GVHD";
            dataGridView1.Columns[6].HeaderText = "Tình trạng";
            dataGridView1.Columns[7].HeaderText = "Năm bảo vệ";
            dataGridView1.Columns[1].Visible = false;
        }
        public void ShowDTG(string hNC,string tt, string gvhd,string txt = "")
        {
            dataGridView1.DataSource = bll.GetDATNByGT(hNC,tt,gvhd,txt);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["STT"].Value = (i + 1);
            }
        }
        private void cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbHuongNC.Text != "" && cbbTT.Text != ""&& cbbGVHD.Text != "")
            {
                ShowDTG(cbbHuongNC.Text, cbbTT.Text, cbbGVHD.Text);
            }
        }
        private void cbbHuongNC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbHuongNC.Text == "All")
            {
                cbbGVHD.Items.Clear();
                cbbGVHD.Text = "All";
                cbbGVHD.Items.AddRange(bll.GetAllGVHD().Distinct().ToArray());
            }
            else
            {
                cbbGVHD.Items.Clear();
                cbbGVHD.Text = "All";
                cbbGVHD.Items.AddRange(bll.GetGVHDByHuongNC(cbbHuongNC.Text).Distinct().ToArray());
            }
            if (cbbHuongNC.Text != "" && cbbTT.Text != "" && cbbGVHD.Text != "")
                ShowDTG(cbbHuongNC.Text, cbbTT.Text, cbbGVHD.Text);
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2("");
            f.d = new Form2.myDel(ShowDTG); 
            f.Show(); 
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count ==1)
            {
                Form2 f = new Form2(dataGridView1.SelectedRows[0].Cells["MaDT"].Value.ToString());
                f.d = new Form2.myDel(ShowDTG);
                f.Show();
            }
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count >0)
            {
                DialogResult drl = MessageBox.Show("Bạn có muốn xóa DATN", "Thông báo", MessageBoxButtons.OKCancel);
                if (drl == DialogResult.OK)
                {
                    List<string> data = new List<string>();
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        data.Add(row.Cells["MaDT"].Value.ToString());
                    }
                    bll.DelDA(data);
                    cbbHuongNC.SelectedIndex = 0;
                    cbbTT.SelectedIndex = 0;
                    cbbGVHD.SelectedIndex = 0;
                    ShowDTG(cbbHuongNC.Text, cbbTT.Text, cbbGVHD.Text);
                }
                else if (drl == DialogResult.Cancel)
                {
                }
            }
        }

        private void butSea_Click(object sender, EventArgs e)
        {
            string search = txtSea.Text;
            ShowDTG(cbbHuongNC.Text,cbbTT.Text,cbbGVHD.Text,search); 
        }
    }
}
