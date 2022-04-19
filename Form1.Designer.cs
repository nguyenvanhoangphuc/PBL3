namespace ThiGK
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butSea = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.txtSea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbHuongNC = new System.Windows.Forms.ComboBox();
            this.cbbTT = new System.Windows.Forms.ComboBox();
            this.cbbGVHD = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // butSea
            // 
            this.butSea.Location = new System.Drawing.Point(75, 337);
            this.butSea.Name = "butSea";
            this.butSea.Size = new System.Drawing.Size(94, 23);
            this.butSea.TabIndex = 0;
            this.butSea.Text = "SEARCH";
            this.butSea.UseVisualStyleBackColor = true;
            this.butSea.Click += new System.EventHandler(this.butSea_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(75, 262);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(94, 23);
            this.butAdd.TabIndex = 0;
            this.butAdd.Text = "ADD";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(207, 262);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(85, 23);
            this.butEdit.TabIndex = 0;
            this.butEdit.Text = "EDIT";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(335, 262);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(82, 23);
            this.butDel.TabIndex = 0;
            this.butDel.Text = "DELETE";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // txtSea
            // 
            this.txtSea.Location = new System.Drawing.Point(207, 337);
            this.txtSea.Name = "txtSea";
            this.txtSea.Size = new System.Drawing.Size(210, 22);
            this.txtSea.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hướng NC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tình trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "GVHD";
            // 
            // cbbHuongNC
            // 
            this.cbbHuongNC.FormattingEnabled = true;
            this.cbbHuongNC.Location = new System.Drawing.Point(728, 242);
            this.cbbHuongNC.Name = "cbbHuongNC";
            this.cbbHuongNC.Size = new System.Drawing.Size(241, 24);
            this.cbbHuongNC.TabIndex = 3;
            this.cbbHuongNC.SelectedIndexChanged += new System.EventHandler(this.cbbHuongNC_SelectedIndexChanged);
            // 
            // cbbTT
            // 
            this.cbbTT.FormattingEnabled = true;
            this.cbbTT.Location = new System.Drawing.Point(728, 288);
            this.cbbTT.Name = "cbbTT";
            this.cbbTT.Size = new System.Drawing.Size(241, 24);
            this.cbbTT.TabIndex = 3;
            this.cbbTT.SelectedIndexChanged += new System.EventHandler(this.cbb_SelectedIndexChanged);
            // 
            // cbbGVHD
            // 
            this.cbbGVHD.FormattingEnabled = true;
            this.cbbGVHD.Location = new System.Drawing.Point(728, 335);
            this.cbbGVHD.Name = "cbbGVHD";
            this.cbbGVHD.Size = new System.Drawing.Size(241, 24);
            this.cbbGVHD.TabIndex = 3;
            this.cbbGVHD.SelectedIndexChanged += new System.EventHandler(this.cbb_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 171);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 407);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbbGVHD);
            this.Controls.Add(this.cbbTT);
            this.Controls.Add(this.cbbHuongNC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSea);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.butSea);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSea;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.TextBox txtSea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbHuongNC;
        private System.Windows.Forms.ComboBox cbbTT;
        private System.Windows.Forms.ComboBox cbbGVHD;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

