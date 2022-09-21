
namespace HocExtensionMethod
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
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.txxtn = new System.Windows.Forms.TextBox();
            this.lbnTinhTong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChuoi1 = new System.Windows.Forms.TextBox();
            this.txtChuoi2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNoi = new System.Windows.Forms.Button();
            this.lblKetQuaNoiChuoi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(71, 69);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(75, 23);
            this.btnTinhTong.TabIndex = 0;
            this.btnTinhTong.Text = "button1";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // txxtn
            // 
            this.txxtn.Location = new System.Drawing.Point(71, 43);
            this.txxtn.Name = "txxtn";
            this.txxtn.Size = new System.Drawing.Size(100, 20);
            this.txxtn.TabIndex = 1;
            // 
            // lbnTinhTong
            // 
            this.lbnTinhTong.AutoSize = true;
            this.lbnTinhTong.Location = new System.Drawing.Point(71, 99);
            this.lbnTinhTong.Name = "lbnTinhTong";
            this.lbnTinhTong.Size = new System.Drawing.Size(35, 13);
            this.lbnTinhTong.TabIndex = 2;
            this.lbnTinhTong.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chuỗi 1:";
            // 
            // txtChuoi1
            // 
            this.txtChuoi1.Location = new System.Drawing.Point(259, 47);
            this.txtChuoi1.Name = "txtChuoi1";
            this.txtChuoi1.Size = new System.Drawing.Size(100, 20);
            this.txtChuoi1.TabIndex = 4;
            // 
            // txtChuoi2
            // 
            this.txtChuoi2.Location = new System.Drawing.Point(259, 76);
            this.txtChuoi2.Name = "txtChuoi2";
            this.txtChuoi2.Size = new System.Drawing.Size(100, 20);
            this.txtChuoi2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chuỗi 2:";
            // 
            // btnNoi
            // 
            this.btnNoi.Location = new System.Drawing.Point(259, 111);
            this.btnNoi.Name = "btnNoi";
            this.btnNoi.Size = new System.Drawing.Size(75, 23);
            this.btnNoi.TabIndex = 7;
            this.btnNoi.Text = "Nối Chuỗi";
            this.btnNoi.UseVisualStyleBackColor = true;
            this.btnNoi.Click += new System.EventHandler(this.btnNoi_Click);
            // 
            // lblKetQuaNoiChuoi
            // 
            this.lblKetQuaNoiChuoi.AutoSize = true;
            this.lblKetQuaNoiChuoi.Location = new System.Drawing.Point(218, 145);
            this.lblKetQuaNoiChuoi.Name = "lblKetQuaNoiChuoi";
            this.lblKetQuaNoiChuoi.Size = new System.Drawing.Size(35, 13);
            this.lblKetQuaNoiChuoi.TabIndex = 8;
            this.lblKetQuaNoiChuoi.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Test SinhVien";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 309);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblKetQuaNoiChuoi);
            this.Controls.Add(this.btnNoi);
            this.Controls.Add(this.txtChuoi2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChuoi1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbnTinhTong);
            this.Controls.Add(this.txxtn);
            this.Controls.Add(this.btnTinhTong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.TextBox txxtn;
        private System.Windows.Forms.Label lbnTinhTong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChuoi1;
        private System.Windows.Forms.TextBox txtChuoi2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNoi;
        private System.Windows.Forms.Label lblKetQuaNoiChuoi;
        private System.Windows.Forms.Button button1;
    }
}

