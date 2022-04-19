namespace ThiGK
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaDT = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtSV = new System.Windows.Forms.TextBox();
            this.cbbHuongNC = new System.Windows.Forms.ComboBox();
            this.cbbNamBV = new System.Windows.Forms.ComboBox();
            this.cbbGVHD = new System.Windows.Forms.ComboBox();
            this.butOK = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.rbutBV = new System.Windows.Forms.RadioButton();
            this.rbutCBV = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã DATN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên DATN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "SV thực hiện";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hướng NC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "GVHD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tình trạng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Năm bảo vệ";
            // 
            // txtMaDT
            // 
            this.txtMaDT.Location = new System.Drawing.Point(193, 48);
            this.txtMaDT.Name = "txtMaDT";
            this.txtMaDT.Size = new System.Drawing.Size(159, 22);
            this.txtMaDT.TabIndex = 1;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(193, 97);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(159, 22);
            this.txtDT.TabIndex = 1;
            // 
            // txtSV
            // 
            this.txtSV.Location = new System.Drawing.Point(193, 146);
            this.txtSV.Name = "txtSV";
            this.txtSV.Size = new System.Drawing.Size(159, 22);
            this.txtSV.TabIndex = 1;
            // 
            // cbbHuongNC
            // 
            this.cbbHuongNC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHuongNC.FormattingEnabled = true;
            this.cbbHuongNC.Location = new System.Drawing.Point(193, 188);
            this.cbbHuongNC.Name = "cbbHuongNC";
            this.cbbHuongNC.Size = new System.Drawing.Size(159, 24);
            this.cbbHuongNC.TabIndex = 2;
            this.cbbHuongNC.SelectedIndexChanged += new System.EventHandler(this.cbbHuongNC_SelectedIndexChanged);
            // 
            // cbbNamBV
            // 
            this.cbbNamBV.FormattingEnabled = true;
            this.cbbNamBV.Location = new System.Drawing.Point(193, 340);
            this.cbbNamBV.Name = "cbbNamBV";
            this.cbbNamBV.Size = new System.Drawing.Size(159, 24);
            this.cbbNamBV.TabIndex = 2;
            // 
            // cbbGVHD
            // 
            this.cbbGVHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGVHD.FormattingEnabled = true;
            this.cbbGVHD.Location = new System.Drawing.Point(193, 240);
            this.cbbGVHD.Name = "cbbGVHD";
            this.cbbGVHD.Size = new System.Drawing.Size(159, 24);
            this.cbbGVHD.TabIndex = 2;
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(106, 403);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(75, 23);
            this.butOK.TabIndex = 3;
            this.butOK.Text = "OK";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(293, 403);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 3;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // rbutBV
            // 
            this.rbutBV.AutoSize = true;
            this.rbutBV.Location = new System.Drawing.Point(15, 21);
            this.rbutBV.Name = "rbutBV";
            this.rbutBV.Size = new System.Drawing.Size(90, 20);
            this.rbutBV.TabIndex = 4;
            this.rbutBV.TabStop = true;
            this.rbutBV.Text = "Đã bảo vệ";
            this.rbutBV.UseVisualStyleBackColor = true;
            // 
            // rbutCBV
            // 
            this.rbutCBV.AutoSize = true;
            this.rbutCBV.Location = new System.Drawing.Point(123, 21);
            this.rbutCBV.Name = "rbutCBV";
            this.rbutCBV.Size = new System.Drawing.Size(104, 20);
            this.rbutCBV.TabIndex = 4;
            this.rbutCBV.TabStop = true;
            this.rbutCBV.Text = "Chưa bảo vệ";
            this.rbutCBV.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbutCBV);
            this.groupBox1.Controls.Add(this.rbutBV);
            this.groupBox1.Location = new System.Drawing.Point(193, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 51);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.cbbGVHD);
            this.Controls.Add(this.cbbNamBV);
            this.Controls.Add(this.cbbHuongNC);
            this.Controls.Add(this.txtSV);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.txtMaDT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaDT;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.TextBox txtSV;
        private System.Windows.Forms.ComboBox cbbHuongNC;
        private System.Windows.Forms.ComboBox cbbNamBV;
        private System.Windows.Forms.ComboBox cbbGVHD;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.RadioButton rbutBV;
        private System.Windows.Forms.RadioButton rbutCBV;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}