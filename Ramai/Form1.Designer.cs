
namespace Ramai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelOutTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPembelian = new System.Windows.Forms.DataGridView();
            this.labelTotalTrans = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelOutTotalTrans = new System.Windows.Forms.Label();
            this.btnVoid = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tbJumlah = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembelian)).BeginInit();
            this.SuspendLayout();
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(41, 70);
            this.tbHarga.Margin = new System.Windows.Forms.Padding(4);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(132, 22);
            this.tbHarga.TabIndex = 0;
            this.tbHarga.TextChanged += new System.EventHandler(this.tbHarga_TextChanged);
            this.tbHarga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbHarga_KeyDown);
            this.tbHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHarga_KeyPress);
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.Location = new System.Drawing.Point(83, 37);
            this.labelHarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(46, 16);
            this.labelHarga.TabIndex = 1;
            this.labelHarga.Text = "Harga";
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlah.Location = new System.Drawing.Point(316, 37);
            this.labelJumlah.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(51, 16);
            this.labelJumlah.TabIndex = 3;
            this.labelJumlah.Text = "Jumlah";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(539, 37);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(39, 16);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "Total";
            // 
            // labelOutTotal
            // 
            this.labelOutTotal.AutoSize = true;
            this.labelOutTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutTotal.Location = new System.Drawing.Point(539, 73);
            this.labelOutTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOutTotal.Name = "labelOutTotal";
            this.labelOutTotal.Size = new System.Drawing.Size(45, 16);
            this.labelOutTotal.TabIndex = 5;
            this.labelOutTotal.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(207, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(459, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "=";
            // 
            // dgvPembelian
            // 
            this.dgvPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPembelian.Location = new System.Drawing.Point(41, 145);
            this.dgvPembelian.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPembelian.Name = "dgvPembelian";
            this.dgvPembelian.Size = new System.Drawing.Size(579, 295);
            this.dgvPembelian.TabIndex = 8;
            this.dgvPembelian.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPembelian_CellValueChanged);
            // 
            // labelTotalTrans
            // 
            this.labelTotalTrans.AutoSize = true;
            this.labelTotalTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTrans.Location = new System.Drawing.Point(272, 469);
            this.labelTotalTrans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalTrans.Name = "labelTotalTrans";
            this.labelTotalTrans.Size = new System.Drawing.Size(105, 16);
            this.labelTotalTrans.TabIndex = 9;
            this.labelTotalTrans.Text = "Total Transaksi ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(459, 462);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "=";
            // 
            // labelOutTotalTrans
            // 
            this.labelOutTotalTrans.AutoSize = true;
            this.labelOutTotalTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutTotalTrans.Location = new System.Drawing.Point(533, 468);
            this.labelOutTotalTrans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOutTotalTrans.Name = "labelOutTotalTrans";
            this.labelOutTotalTrans.Size = new System.Drawing.Size(45, 16);
            this.labelOutTotalTrans.TabIndex = 11;
            this.labelOutTotalTrans.Text = "label9";
            // 
            // btnVoid
            // 
            this.btnVoid.BackColor = System.Drawing.Color.Red;
            this.btnVoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoid.Location = new System.Drawing.Point(235, 519);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(173, 96);
            this.btnVoid.TabIndex = 12;
            this.btnVoid.Text = "VOID";
            this.btnVoid.UseVisualStyleBackColor = false;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Lime;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrint.Location = new System.Drawing.Point(447, 519);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(173, 96);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(521, 106);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // tbJumlah
            // 
            this.tbJumlah.Location = new System.Drawing.Point(275, 70);
            this.tbJumlah.Margin = new System.Windows.Forms.Padding(4);
            this.tbJumlah.Name = "tbJumlah";
            this.tbJumlah.Size = new System.Drawing.Size(132, 22);
            this.tbJumlah.TabIndex = 2;
            this.tbJumlah.TextChanged += new System.EventHandler(this.tbJumlah_TextChanged_1);
            this.tbJumlah.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbJumlah_KeyDown);
            this.tbJumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbJumlah_KeyPress_1);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Orange;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(41, 519);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(173, 96);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 645);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbJumlah);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnVoid);
            this.Controls.Add(this.labelOutTotalTrans);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelTotalTrans);
            this.Controls.Add(this.dgvPembelian);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelOutTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelJumlah);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.tbHarga);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembelian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelJumlah;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelOutTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvPembelian;
        private System.Windows.Forms.Label labelTotalTrans;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelOutTotalTrans;
        private System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnAdd;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox tbJumlah;
        private System.Windows.Forms.Button btnBack;
    }
}

