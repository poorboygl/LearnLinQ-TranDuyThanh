
namespace HocDelegate_ListBox
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
            this.lstSo = new System.Windows.Forms.ListBox();
            this.btnToSoChan = new System.Windows.Forms.Button();
            this.btnToSoLe = new System.Windows.Forms.Button();
            this.btnToNguyenTo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSo
            // 
            this.lstSo.FormattingEnabled = true;
            this.lstSo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.lstSo.Location = new System.Drawing.Point(55, 35);
            this.lstSo.Name = "lstSo";
            this.lstSo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstSo.Size = new System.Drawing.Size(143, 186);
            this.lstSo.TabIndex = 0;
            // 
            // btnToSoChan
            // 
            this.btnToSoChan.Location = new System.Drawing.Point(251, 35);
            this.btnToSoChan.Name = "btnToSoChan";
            this.btnToSoChan.Size = new System.Drawing.Size(75, 23);
            this.btnToSoChan.TabIndex = 1;
            this.btnToSoChan.Text = "Tô số chẵn";
            this.btnToSoChan.UseVisualStyleBackColor = true;
            this.btnToSoChan.Click += new System.EventHandler(this.btnToSoChan_Click);
            // 
            // btnToSoLe
            // 
            this.btnToSoLe.Location = new System.Drawing.Point(251, 64);
            this.btnToSoLe.Name = "btnToSoLe";
            this.btnToSoLe.Size = new System.Drawing.Size(75, 23);
            this.btnToSoLe.TabIndex = 2;
            this.btnToSoLe.Text = "Tô số Lẽ";
            this.btnToSoLe.UseVisualStyleBackColor = true;
            this.btnToSoLe.Click += new System.EventHandler(this.btnToSoLe_Click);
            // 
            // btnToNguyenTo
            // 
            this.btnToNguyenTo.Location = new System.Drawing.Point(251, 93);
            this.btnToNguyenTo.Name = "btnToNguyenTo";
            this.btnToNguyenTo.Size = new System.Drawing.Size(75, 38);
            this.btnToNguyenTo.TabIndex = 3;
            this.btnToNguyenTo.Text = "Tô Số Nguyên tố";
            this.btnToNguyenTo.UseVisualStyleBackColor = true;
            this.btnToNguyenTo.Click += new System.EventHandler(this.btnToNguyenTo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToNguyenTo);
            this.Controls.Add(this.btnToSoLe);
            this.Controls.Add(this.btnToSoChan);
            this.Controls.Add(this.lstSo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstSo;
        private System.Windows.Forms.Button btnToSoChan;
        private System.Windows.Forms.Button btnToSoLe;
        private System.Windows.Forms.Button btnToNguyenTo;
    }
}

