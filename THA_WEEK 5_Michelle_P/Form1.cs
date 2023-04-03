using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace THA_WEEK_5_Michelle_P
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int angkatertinggi = 0;
        int kode = 0;
        string abc = "";
        public int keep = 0;

        DataTable dtProduct = new DataTable();
        DataTable dtCategory = new DataTable();
        DataTable dtFilter = new DataTable();

        public static List<String> categories = new List<String>() { "Jas", "T-Shirt", "Rok", "Celana", "Cawat" };
        public static List<String> C = new List<String>() { "C1", "C2", "C3", "C4", "C5" };

        public void AddCategory()
        {
            foreach (var x in categories)
            {
                cmb_Category.Items.Add(x);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            btn_AddPro.BackColor = Color.Green;
            btn_Edit.BackColor = Color.Yellow;
            btn_RemovePro1.BackColor = Color.Red;
            btn_AddCategory.BackColor = Color.Green;
            btn_RemovePro2.BackColor = Color.Red;

            dtProduct.Columns.Add("ID Product");
            dtProduct.Columns.Add("Nama Product");
            dtProduct.Columns.Add("Harga");
            dtProduct.Columns.Add("Stock");
            dtProduct.Columns.Add("ID Category");
            dgv_Product.DataSource = dtProduct;

            dtProduct.Rows.Add("J001", "Jas Hitam", 100000, 10, "C1");
            dtProduct.Rows.Add("T001", "T-Shirt Black Pink", 70000, 20, "C2");
            dtProduct.Rows.Add("T002", "T-Shirt Obsessive", 75000, "16", "C2");
            dtProduct.Rows.Add("R001", "Rok Mini", 82000, 26, "C3");
            dtProduct.Rows.Add("J002", "Jeans Biru", 90000, 5, "C4");
            dtProduct.Rows.Add("C001", "Celana Pendek", 60000, 11, "C4");
            dtProduct.Rows.Add("C002", "Cawat Blink-Blink", 100000, 1, "C5");
            dtProduct.Rows.Add("R002", "Rocca Shirt", 50000, 8, "C2");

            dtCategory.Columns.Add("ID Category");
            dtCategory.Columns.Add("Nama Category");

            dtCategory.Rows.Add("C1", "Jas");
            dtCategory.Rows.Add("C2", "T-Shirt");
            dtCategory.Rows.Add("C3", "Rok");
            dtCategory.Rows.Add("C4", "Celana");
            dtCategory.Rows.Add("C5", "Cawat");
            dgv_Category.DataSource = dtCategory;
            dtFilter.Columns.Add("ID Product");
            dtFilter.Columns.Add("Nama Product");
            dtFilter.Columns.Add("Harga");
            dtFilter.Columns.Add("Stock");
            dtFilter.Columns.Add("ID Category");
            
            dgv_Product.DataSource = dtFilter;

            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                cmb_Filter.Items.Add(dtCategory.Rows[i][1].ToString());
            }
           
            cmb_Filter.Enabled = false;
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                cmb_Category.Items.Add(dtCategory.Rows[i][1].ToString());
            }

            for (int i = 0; i < dtProduct.Rows.Count; i++)
            {
                
            }
            dgv_Product.DataSource = dtProduct;
        }

        private void btn_AddPro_Click(object sender, EventArgs e) 
        {
            if (txt_Nama.Text == "" || cmb_Category.Text == "" || txt_Harga.Text == "" || txt_Stock.Text == "")
            {
                string errortext2 = "Harus diisi semua";
                MessageBox.Show(errortext2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bool beli = false;
                string ID = txt_Nama.Text.Substring(0, 1).ToUpper();

                abc = ID;
                kode = kode + 1;

                for (int a = 0; a < dtProduct.Rows.Count; a++)
                {
                    if (ID == dtProduct.Rows[a][0].ToString()[0].ToString())
                    {
                        if (kode <= Convert.ToInt32(dtProduct.Rows[a][0].ToString().Substring(1)))
                        {
                            kode = Convert.ToInt32(dtProduct.Rows[a][0].ToString().Substring(1));
                        }
                    }
                }
                for (int a = 0; a < 3 - kode.ToString().Length; a++)
                {
                    abc += "0";
                }
                abc += (kode + 1);
                string keep = "";

                for (int a = 0; a < dtCategory.Rows.Count; a++)
                {
                    if (cmb_Category.SelectedItem.ToString() == dtCategory.Rows[a][1].ToString())
                    {
                        keep = dtCategory.Rows[a][0].ToString();
                    }
                }

                foreach (DataRow a in dtProduct.Rows)
                {
                    if (a[0].ToString() == txt_Nama.Text)
                    {
                        beli = true;
                    }
                }

                if (beli == false)
                {
                    dtProduct.Rows.Add(abc, txt_Nama.Text, txt_Harga.Text, txt_Stock.Text, keep);
                    txt_Nama.Clear();
                    txt_Harga.Clear();
                    txt_Stock.Clear();
                }
                else
                {
                    string errortext2 = "Sudah ada";
                    MessageBox.Show(errortext2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_Product.SelectedCells.Count <= 0)
            {
                string errortext2 = "Harus diisi dulu";
                MessageBox.Show(errortext2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txt_Stock.Text == "0")
                {
                    dtProduct.Rows.RemoveAt(dgv_Product.SelectedCells[0].RowIndex);
                    dgv_Product.DataSource = dtProduct;
                    txt_Nama.Clear();
                    txt_Harga.Clear();
                    txt_Stock.Clear();
                }
                else
                {
                    dtProduct.Rows[keep][1] = txt_Nama.Text;
                    dtProduct.Rows[keep][2] = txt_Harga.Text;
                    dtProduct.Rows[keep][3] = txt_Stock.Text;

                    for (int i = 0; i < C.Count; i++)
                    {
                        if (cmb_Category.SelectedItem == categories[i])
                        {
                            dtProduct.Rows[keep][4] = C[i];
                        }
                    }
                    dgv_Product.DataSource = dtProduct;
                }
            }
        }

        private void btn_RemovePro1_Click(object sender, EventArgs e)
        {
            if (dgv_Product.SelectedCells.Count <= 0)
            {
                string errortext2 = "Pilih dulu";
                MessageBox.Show(errortext2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dtProduct.Rows.RemoveAt(dgv_Product.CurrentCell.RowIndex);
            }
        }

        private void btn_RemovePro2_Click(object sender, EventArgs e) 
        {
            int count = 0;
            if (dgv_Category.SelectedCells.Count <= 0)
            {
                string errortext2 = "Pilih dulu";
                MessageBox.Show(errortext2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cmb_Category.Items.Remove(dgv_Category.SelectedCells[0].Value.ToString());
                cmb_Filter.Items.Remove(dgv_Category.SelectedCells[0].Value.ToString());
                for (int i = dtProduct.Rows.Count - 1; i >= 0; i--)
                {
                    if (dtProduct.Rows[i][4].ToString() == dgv_Category.SelectedCells[0].Value.ToString())
                    {
                        dtProduct.Rows.RemoveAt(i);
                    }
                }
                if (dgv_Category.SelectedCells[0].Value.ToString().Substring(0) == count.ToString())
                {
                    count--;
                }
                foreach (DataRow a in dtCategory.Rows)
                {
                    if (a[1].ToString() == abc)
                    {

                        dtCategory.Rows.Remove(a);
                        break;
                    }
                    dgv_Category.Rows.RemoveAt(dgv_Category.CurrentCell.RowIndex);
                    break;
                }
            }
        }

        private void btn_AddCategory_Click(object sender, EventArgs e)
        {
            int hitung = 0;
            angkatertinggi = 0;
            if (txt_NamaCat.Text == "")
            {
                string errortext2 = "Harus diisi dulu";
                MessageBox.Show(errortext2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            foreach (DataRow a in dtCategory.Rows)
            {
                if (int.Parse(a[0].ToString().Substring(1)) >= angkatertinggi)
                {
                    angkatertinggi = int.Parse(a[0].ToString().Substring(1));
                }
            }

            if (txt_NamaCat.Text != "")
            {
                foreach (DataRow a in dtCategory.Rows)
                {
                    if (a[1].ToString() == txt_NamaCat.Text)
                    {
                        string errortext2 = "Sudah ada";
                        MessageBox.Show(errortext2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        hitung++;
                    }
                }
                if (hitung == 0)
                {
                    dtCategory.Rows.Add("C" + (angkatertinggi + 1), txt_NamaCat.Text);
                }

                cmb_Category.Items.Clear();
                for (int i = 0; i < dtCategory.Rows.Count; i++)
                {
                    cmb_Category.Items.Add(dtCategory.Rows[i][1].ToString());
                }
            }
        }

        private void txt_Harga_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_Stock_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cmb_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string keep = "";
            dtFilter.Rows.Clear();

            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                if (cmb_Filter.Text == dtCategory.Rows[i][1].ToString())
                {
                    keep = dtCategory.Rows[i][0].ToString();
                }
            }
            for (int a = 0; a < dtProduct.Rows.Count; a++)
            {
                if (keep == dtProduct.Rows[a][4].ToString())
                {
                    dtFilter.Rows.Add(dtProduct.Rows[a][0].ToString(), dtProduct.Rows[a][1].ToString(), dtProduct.Rows[a][2].ToString(), dtProduct.Rows[a][3].ToString(), dtProduct.Rows[a][4].ToString());
                }
            }
            dgv_Product.DataSource = dtFilter;
            
        }
    
        private void btn_Filter_Click(object sender, EventArgs e)
        {
            cmb_Filter.Enabled = true;
        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            cmb_Filter.Enabled = false;
            dgv_Product.DataSource = dtProduct;

        }
    }
}
