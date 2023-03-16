
namespace Ramai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.labelRamai = new System.Windows.Forms.Label();
            this.btnPerkalian = new System.Windows.Forms.Button();
            this.btnPenjumlahan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRamai
            // 
            this.labelRamai.AutoSize = true;
            this.labelRamai.Font = new System.Drawing.Font("Superstar M54", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRamai.Location = new System.Drawing.Point(149, 31);
            this.labelRamai.Name = "labelRamai";
            this.labelRamai.Size = new System.Drawing.Size(208, 77);
            this.labelRamai.TabIndex = 0;
            this.labelRamai.Text = "RAMAI";
            // 
            // btnPerkalian
            // 
            this.btnPerkalian.BackColor = System.Drawing.Color.LightGreen;
            this.btnPerkalian.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerkalian.Location = new System.Drawing.Point(49, 127);
            this.btnPerkalian.Name = "btnPerkalian";
            this.btnPerkalian.Size = new System.Drawing.Size(190, 104);
            this.btnPerkalian.TabIndex = 1;
            this.btnPerkalian.Text = "Hitung Harga Dan Jumlah";
            this.btnPerkalian.UseVisualStyleBackColor = false;
            this.btnPerkalian.Click += new System.EventHandler(this.btnPerkalian_Click);
            // 
            // btnPenjumlahan
            // 
            this.btnPenjumlahan.BackColor = System.Drawing.Color.Wheat;
            this.btnPenjumlahan.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenjumlahan.Location = new System.Drawing.Point(269, 127);
            this.btnPenjumlahan.Name = "btnPenjumlahan";
            this.btnPenjumlahan.Size = new System.Drawing.Size(190, 104);
            this.btnPenjumlahan.TabIndex = 2;
            this.btnPenjumlahan.Text = "Hitung Total Transaksi";
            this.btnPenjumlahan.UseVisualStyleBackColor = false;
            this.btnPenjumlahan.Click += new System.EventHandler(this.btnPenjumlahan_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 293);
            this.Controls.Add(this.btnPenjumlahan);
            this.Controls.Add(this.btnPerkalian);
            this.Controls.Add(this.labelRamai);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Ramai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRamai;
        private System.Windows.Forms.Button btnPerkalian;
        private System.Windows.Forms.Button btnPenjumlahan;
    }
}