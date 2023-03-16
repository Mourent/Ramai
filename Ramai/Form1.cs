using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Ramai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dtPembelian = new DataTable();
        DataColumn dtColumn;
        DataRow dtRow;
        double totalTransaksi = 0;

        private void tbHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void tbJumlah_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && tbJumlah.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelOutTotal.Text = "";
            labelOutTotalTrans.Text = "";

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "Harga";
            dtColumn.Caption = "Harga";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;

            dtPembelian.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "Jumlah";
            dtColumn.Caption = "Jumlah";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;

            dtPembelian.Columns.Add(dtColumn);


            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "Total";
            dtColumn.Caption = "Total";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;

            dtPembelian.Columns.Add(dtColumn);

            dgvPembelian.DataSource = dtPembelian;
        }

        private void tbHarga_TextChanged(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            double jumlah= 0;
            double harga = 0;
            if (tbJumlah.Text.Length > 0 && tbHarga.Text.Length > 0)
            {
                jumlah = double.Parse(tbJumlah.Text, provider);
                harga = double.Parse(tbHarga.Text);
                labelOutTotal.Text = (jumlah * harga).ToString();
            }
        }

        private void tbJumlah_TextChanged_1(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            double jumlah = 0;
            double harga = 0;
            if (tbJumlah.Text.Length > 0 && tbHarga.Text.Length > 0)
            {
                jumlah = double.Parse(tbJumlah.Text, provider);
                harga = double.Parse(tbHarga.Text);
                labelOutTotal.Text = (jumlah * harga).ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            NumberFormatInfo rupiah = new CultureInfo("id-ID", false).NumberFormat;
            rupiah.CurrencyDecimalDigits = 0;
            if (tbHarga.Text.Length > 0 && tbJumlah.Text.Length > 0)
            {
                int harga = int.Parse(tbHarga.Text);
                double jumlah = double.Parse(tbJumlah.Text, provider);
                int total = int.Parse(labelOutTotal.Text);
                dtRow = dtPembelian.NewRow();
                dtRow["Harga"] = harga;
                dtRow["Jumlah"] = jumlah;
                dtRow["Total"] = total.ToString("C", rupiah);
                dtPembelian.Rows.Add(dtRow);

                totalTransaksi = totalTransaksi + double.Parse(labelOutTotal.Text);
                tbHarga.Text = "";
                tbJumlah.Text = "";
                labelOutTotal.Text = "";
                labelOutTotalTrans.Text = totalTransaksi.ToString("C", rupiah);
                tbHarga.Focus();
            }
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            totalTransaksi = 0;
            labelOutTotalTrans.Text = "";
            dtPembelian.Rows.Clear();

            tbHarga.Focus();
        }

        private void dgvPembelian_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            double hargaTotal = 0;
            double totalTrans = 0;
            int cariUrutan = dgvPembelian.CurrentCell.RowIndex;
            int cariColumn = dgvPembelian.CurrentCell.ColumnIndex;
            NumberFormatInfo rupiah = new CultureInfo("id-ID", false).NumberFormat;
            rupiah.CurrencyDecimalDigits = 0;

            if (cariColumn == 1 && dtPembelian.Rows[cariUrutan][cariColumn].ToString() == "0")
            {
                DataRow dr = dtPembelian.Rows[cariUrutan];
                dr.Delete();
                for (int i = 0; i < dtPembelian.Rows.Count; i++)
                {
                    totalTrans = totalTrans + double.Parse(dtPembelian.Rows[i][0].ToString()) * double.Parse(dtPembelian.Rows[i][1].ToString(), provider);
                }
                totalTransaksi = totalTrans;
                labelOutTotalTrans.Text = totalTransaksi.ToString("C", rupiah);
            }
            else
            {
                hargaTotal = double.Parse(dtPembelian.Rows[cariUrutan][0].ToString(), provider) * double.Parse(dtPembelian.Rows[cariUrutan][1].ToString(), provider);
                dtPembelian.Rows[cariUrutan]["Total"] = hargaTotal.ToString("C", rupiah);
                for (int i = 0; i < dtPembelian.Rows.Count; i++)
                {
                    totalTrans = totalTrans + double.Parse(dtPembelian.Rows[i][0].ToString()) * double.Parse(dtPembelian.Rows[i][1].ToString(), provider);
                }
                totalTransaksi = totalTrans;
                labelOutTotalTrans.Text = totalTransaksi.ToString("C", rupiah);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printdialog1 = new PrintDialog();
            printdialog1.Document = printDocument1;

            DialogResult result = printdialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                int tambahanBaris = 0;
                for (int i = 0; i < dtPembelian.Rows.Count; i++)
                {
                    tambahanBaris += 20;
                }
                printPreviewDialog1.Document = printDocument1;
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 255, 240 + tambahanBaris);
                printPreviewDialog1.ShowDialog();
            }

            totalTransaksi = 0;
            labelOutTotalTrans.Text = "";
            dtPembelian.Rows.Clear();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("RAMAI", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(95, 5));
            e.Graphics.DrawString("Jl. Gajah Mada 53 Rambipuji", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(43, 27));
            e.Graphics.DrawString("0331-711158 / 081234571117", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(46, 42));
            e.Graphics.DrawString("Tanggal : " + DateTime.Now.ToString("dd MMMM yyyy              HH:mm:ss"), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(15, 60));

            e.Graphics.DrawString("---------------------------------------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(10, 80));
            e.Graphics.DrawString("Harga", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(15, 100));
            e.Graphics.DrawString("Jumlah", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(100, 100));
            e.Graphics.DrawString("Total", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(190, 100));
            e.Graphics.DrawString("---------------------------------------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(10, 120));

            int baris = 140;
            int ambilData = 0;
            string gantiRupiah = "";
            for (int i = 0; i < dtPembelian.Rows.Count; i++)
            {
                NumberFormatInfo rupiah = new CultureInfo("id-ID", false).NumberFormat;
                rupiah.CurrencyDecimalDigits = 0;
                ambilData = int.Parse(dtPembelian.Rows[i][0].ToString());
                gantiRupiah = ambilData.ToString("C", rupiah);
                e.Graphics.DrawString(gantiRupiah + "  x  ", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(15, baris));
                e.Graphics.DrawString(dtPembelian.Rows[i][1].ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(105, baris));
                e.Graphics.DrawString(dtPembelian.Rows[i][2].ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(170, baris));
                baris = baris + 20;
            }
            e.Graphics.DrawString("---------------------------------------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(10, baris));
            baris += 20;

            e.Graphics.DrawString("Total Transaksi : ", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(70, baris));
            e.Graphics.DrawString(labelOutTotalTrans.Text, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(170, baris));
            baris += 40;
            e.Graphics.DrawString("THANKYOU FOR PURCHASING!", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(45, baris));
            baris += 40;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void tbHarga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NumberFormatInfo provider = new NumberFormatInfo();
                provider.NumberDecimalSeparator = ".";
                NumberFormatInfo rupiah = new CultureInfo("id-ID", false).NumberFormat;
                rupiah.CurrencyDecimalDigits = 0;
                if (tbHarga.Text.Length > 0 && tbJumlah.Text.Length > 0)
                {
                    int harga = int.Parse(tbHarga.Text);
                    double jumlah = double.Parse(tbJumlah.Text, provider);
                    int total = int.Parse(labelOutTotal.Text);
                    dtRow = dtPembelian.NewRow();
                    dtRow["Harga"] = harga;
                    dtRow["Jumlah"] = jumlah;
                    dtRow["Total"] = total.ToString("C", rupiah);
                    dtPembelian.Rows.Add(dtRow);

                    totalTransaksi = totalTransaksi + double.Parse(labelOutTotal.Text);
                    tbHarga.Text = "";
                    tbJumlah.Text = "";
                    labelOutTotal.Text = "";
                    labelOutTotalTrans.Text = totalTransaksi.ToString("C", rupiah);
                    tbHarga.Focus();
                }
                else
                {
                    tbJumlah.Focus();
                }
            }
        }

        private void tbJumlah_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NumberFormatInfo provider = new NumberFormatInfo();
                provider.NumberDecimalSeparator = ".";
                NumberFormatInfo rupiah = new CultureInfo("id-ID", false).NumberFormat;
                rupiah.CurrencyDecimalDigits = 0;
                if (tbHarga.Text.Length > 0 && tbJumlah.Text.Length > 0)
                {
                    int harga = int.Parse(tbHarga.Text);
                    double jumlah = double.Parse(tbJumlah.Text, provider);
                    int total = int.Parse(labelOutTotal.Text);
                    dtRow = dtPembelian.NewRow();
                    dtRow["Harga"] = harga;
                    dtRow["Jumlah"] = jumlah;
                    dtRow["Total"] = total.ToString("C", rupiah);
                    dtPembelian.Rows.Add(dtRow);

                    totalTransaksi = totalTransaksi + double.Parse(labelOutTotal.Text);
                    tbHarga.Text = "";
                    tbJumlah.Text = "";
                    labelOutTotal.Text = "";
                    labelOutTotalTrans.Text = totalTransaksi.ToString("C", rupiah);
                    tbHarga.Focus();
                }
                else
                {
                    tbHarga.Focus();
                }
            }
        }
    }
}
