
namespace Ramai
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.labelTotal = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.dgvPembelian = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnVoid = new System.Windows.Forms.Button();
            this.labelOutTotalTrans = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTotalTrans = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembelian)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(72, 34);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(39, 16);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "Total";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(24, 67);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(4);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(144, 20);
            this.tbTotal.TabIndex = 2;
            this.tbTotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTotal_KeyDown);
            this.tbTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTotal_KeyPress);
            // 
            // dgvPembelian
            // 
            this.dgvPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPembelian.Location = new System.Drawing.Point(194, 34);
            this.dgvPembelian.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPembelian.Name = "dgvPembelian";
            this.dgvPembelian.Size = new System.Drawing.Size(231, 339);
            this.dgvPembelian.TabIndex = 9;
            this.dgvPembelian.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPembelian_CellClick);
            this.dgvPembelian.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPembelian_CellValueChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Orange;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(12, 110);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(173, 96);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Lime;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrint.Location = new System.Drawing.Point(12, 329);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(173, 96);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnVoid
            // 
            this.btnVoid.BackColor = System.Drawing.Color.Red;
            this.btnVoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoid.Location = new System.Drawing.Point(12, 221);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(173, 96);
            this.btnVoid.TabIndex = 16;
            this.btnVoid.Text = "VOID";
            this.btnVoid.UseVisualStyleBackColor = false;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
            // 
            // labelOutTotalTrans
            // 
            this.labelOutTotalTrans.AutoSize = true;
            this.labelOutTotalTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutTotalTrans.Location = new System.Drawing.Point(326, 394);
            this.labelOutTotalTrans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOutTotalTrans.Name = "labelOutTotalTrans";
            this.labelOutTotalTrans.Size = new System.Drawing.Size(45, 16);
            this.labelOutTotalTrans.TabIndex = 21;
            this.labelOutTotalTrans.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(296, 390);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "=";
            // 
            // labelTotalTrans
            // 
            this.labelTotalTrans.AutoSize = true;
            this.labelTotalTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTrans.Location = new System.Drawing.Point(192, 394);
            this.labelTotalTrans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalTrans.Name = "labelTotalTrans";
            this.labelTotalTrans.Size = new System.Drawing.Size(105, 16);
            this.labelTotalTrans.TabIndex = 19;
            this.labelTotalTrans.Text = "Total Transaksi ";
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.labelOutTotalTrans);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelTotalTrans);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnVoid);
            this.Controls.Add(this.dgvPembelian);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.tbTotal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembelian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.DataGridView dgvPembelian;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.Label labelOutTotalTrans;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTotalTrans;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}