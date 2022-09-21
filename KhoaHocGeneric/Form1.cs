using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhoaHocGeneric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsInt = new List<int>();

        private void BtnTao_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                int x = rd.Next(100);
                dsInt.Add(x);

            }
            dsInt.AddRange(new int[] { 113, 114 });
            LstSo.Items.Clear();
            for (int i = 0; i < dsInt.Count; i++)
            {
                LstSo.Items.Add(dsInt[i]);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if(LstSo.SelectedIndex!=-1)
            {
                dsInt[LstSo.SelectedIndex] = int.Parse(txtGiaTri.Text);
                LstSo.Items[LstSo.SelectedIndex] = dsInt[LstSo.SelectedIndex];
            }
        }

        private void LstSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LstSo.SelectedIndex!=-1)
            {
                txtGiaTri.Text = dsInt[LstSo.SelectedIndex] + "";
            }

        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (LstSo.SelectedIndex != -1)
            {
                dsInt.RemoveAt(LstSo.SelectedIndex);
                LstSo.Items.Clear();
                for (int i = 0; i < dsInt.Count; i++)
                {
                    LstSo.Items.Add(dsInt[i]);
                }

            }
            else
            {
                MessageBox.Show("Chưa chọn chưa xoá được");
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        Dictionary<int, string> dicSV = new Dictionary<int, string>();
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            int maSv = int.Parse(txtMa.Text);
            string tenSv = txtTen.Text;

            dicSV.Add(maSv, tenSv);
            txtMa.Text = "";
            txtTen.Text = "";

            HienThiSinhVien();
        }

        private void HienThiSinhVien()
        {
            lvSinhVien.Items.Clear();
            foreach (KeyValuePair<int,string> item in dicSV)
            {
                ListViewItem lvi = new ListViewItem(item.Key + "");
                lvi.SubItems.Add(item.Value);
                lvSinhVien.Items.Add(lvi);
            }
        }

        private void LvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
                return;
            ListViewItem lvi = lvSinhVien.SelectedItems[0];
            int ma = int.Parse(lvi.SubItems[0].Text);
            string ten = dicSV[ma];
            txtMa.Text = ma + "";
            txtTen.Text = ten;
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMa.Text);
            dicSV.Remove(ma);
            HienThiSinhVien();
        }
    }
}
