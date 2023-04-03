namespace THA_WEEK_5_Michelle_P
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Product = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Category = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NamaCat = new System.Windows.Forms.TextBox();
            this.btn_AddCategory = new System.Windows.Forms.Button();
            this.btn_RemovePro2 = new System.Windows.Forms.Button();
            this.btn_All = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.cmb_Filter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Nama = new System.Windows.Forms.TextBox();
            this.txt_Harga = new System.Windows.Forms.TextBox();
            this.txt_Stock = new System.Windows.Forms.TextBox();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.btn_AddPro = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_RemovePro1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // dgv_Product
            // 
            this.dgv_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product.Location = new System.Drawing.Point(35, 81);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.RowHeadersWidth = 62;
            this.dgv_Product.RowTemplate.Height = 28;
            this.dgv_Product.Size = new System.Drawing.Size(597, 289);
            this.dgv_Product.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(688, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // dgv_Category
            // 
            this.dgv_Category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Category.Location = new System.Drawing.Point(693, 81);
            this.dgv_Category.Name = "dgv_Category";
            this.dgv_Category.RowHeadersWidth = 62;
            this.dgv_Category.RowTemplate.Height = 28;
            this.dgv_Category.Size = new System.Drawing.Size(277, 244);
            this.dgv_Category.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(693, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nama:";
            // 
            // txt_NamaCat
            // 
            this.txt_NamaCat.Location = new System.Drawing.Point(773, 347);
            this.txt_NamaCat.Name = "txt_NamaCat";
            this.txt_NamaCat.Size = new System.Drawing.Size(197, 26);
            this.txt_NamaCat.TabIndex = 5;
            // 
            // btn_AddCategory
            // 
            this.btn_AddCategory.Location = new System.Drawing.Point(773, 393);
            this.btn_AddCategory.Name = "btn_AddCategory";
            this.btn_AddCategory.Size = new System.Drawing.Size(100, 64);
            this.btn_AddCategory.TabIndex = 6;
            this.btn_AddCategory.Text = "Add\r\nCategory";
            this.btn_AddCategory.UseVisualStyleBackColor = true;
            this.btn_AddCategory.Click += new System.EventHandler(this.btn_AddCategory_Click);
            // 
            // btn_RemovePro2
            // 
            this.btn_RemovePro2.Location = new System.Drawing.Point(879, 393);
            this.btn_RemovePro2.Name = "btn_RemovePro2";
            this.btn_RemovePro2.Size = new System.Drawing.Size(91, 64);
            this.btn_RemovePro2.TabIndex = 7;
            this.btn_RemovePro2.Text = "Remove\r\nCategory";
            this.btn_RemovePro2.UseVisualStyleBackColor = true;
            this.btn_RemovePro2.Click += new System.EventHandler(this.btn_RemovePro2_Click);
            // 
            // btn_All
            // 
            this.btn_All.Location = new System.Drawing.Point(385, 45);
            this.btn_All.Name = "btn_All";
            this.btn_All.Size = new System.Drawing.Size(51, 30);
            this.btn_All.TabIndex = 8;
            this.btn_All.Text = "All";
            this.btn_All.UseVisualStyleBackColor = true;
            this.btn_All.Click += new System.EventHandler(this.btn_All_Click);
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(442, 45);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(61, 29);
            this.btn_Filter.TabIndex = 9;
            this.btn_Filter.Text = "Filter:";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // cmb_Filter
            // 
            this.cmb_Filter.FormattingEnabled = true;
            this.cmb_Filter.Location = new System.Drawing.Point(509, 46);
            this.cmb_Filter.Name = "cmb_Filter";
            this.cmb_Filter.Size = new System.Drawing.Size(123, 28);
            this.cmb_Filter.TabIndex = 10;
            this.cmb_Filter.SelectedIndexChanged += new System.EventHandler(this.cmb_Filter_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nama:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Category:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Harga:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 563);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Stock:";
            // 
            // txt_Nama
            // 
            this.txt_Nama.Location = new System.Drawing.Point(128, 437);
            this.txt_Nama.Name = "txt_Nama";
            this.txt_Nama.Size = new System.Drawing.Size(504, 26);
            this.txt_Nama.TabIndex = 16;
            // 
            // txt_Harga
            // 
            this.txt_Harga.Location = new System.Drawing.Point(128, 521);
            this.txt_Harga.Name = "txt_Harga";
            this.txt_Harga.Size = new System.Drawing.Size(134, 26);
            this.txt_Harga.TabIndex = 17;
            this.txt_Harga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Harga_KeyPress_1);
            // 
            // txt_Stock
            // 
            this.txt_Stock.Location = new System.Drawing.Point(128, 563);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(134, 26);
            this.txt_Stock.TabIndex = 18;
            this.txt_Stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Stock_KeyPress_1);
            // 
            // cmb_Category
            // 
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(129, 480);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(133, 28);
            this.cmb_Category.TabIndex = 19;
            // 
            // btn_AddPro
            // 
            this.btn_AddPro.Location = new System.Drawing.Point(296, 521);
            this.btn_AddPro.Name = "btn_AddPro";
            this.btn_AddPro.Size = new System.Drawing.Size(86, 62);
            this.btn_AddPro.TabIndex = 20;
            this.btn_AddPro.Text = "Add\r\nProduct\r\n";
            this.btn_AddPro.UseVisualStyleBackColor = true;
            this.btn_AddPro.Click += new System.EventHandler(this.btn_AddPro_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(388, 521);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(89, 62);
            this.btn_Edit.TabIndex = 21;
            this.btn_Edit.Text = "Edit\r\nProduct";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_RemovePro1
            // 
            this.btn_RemovePro1.Location = new System.Drawing.Point(483, 521);
            this.btn_RemovePro1.Name = "btn_RemovePro1";
            this.btn_RemovePro1.Size = new System.Drawing.Size(85, 62);
            this.btn_RemovePro1.TabIndex = 22;
            this.btn_RemovePro1.Text = "Remove\r\nProduct\r\n";
            this.btn_RemovePro1.UseVisualStyleBackColor = true;
            this.btn_RemovePro1.Click += new System.EventHandler(this.btn_RemovePro1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1035, 609);
            this.Controls.Add(this.btn_RemovePro1);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_AddPro);
            this.Controls.Add(this.cmb_Category);
            this.Controls.Add(this.txt_Stock);
            this.Controls.Add(this.txt_Harga);
            this.Controls.Add(this.txt_Nama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Filter);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.btn_All);
            this.Controls.Add(this.btn_RemovePro2);
            this.Controls.Add(this.btn_AddCategory);
            this.Controls.Add(this.txt_NamaCat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_Category);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Product);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Blink Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NamaCat;
        private System.Windows.Forms.Button btn_AddCategory;
        private System.Windows.Forms.Button btn_RemovePro2;
        private System.Windows.Forms.Button btn_All;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.ComboBox cmb_Filter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Nama;
        private System.Windows.Forms.TextBox txt_Harga;
        private System.Windows.Forms.TextBox txt_Stock;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Button btn_AddPro;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_RemovePro1;
    }
}

