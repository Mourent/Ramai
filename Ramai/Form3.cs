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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        DataTable dtPembelian = new DataTable();
        DataColumn dtColumn;
        DataRow dtRow;
        int totalTransaksi = 0;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            labelOutTotalTrans.Text = "";

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "Total";
            dtColumn.Caption = "Total";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;

            dtPembelian.Columns.Add(dtColumn);

            dgvPembelian.DataSource = dtPembelian;
        }

        private void tbTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NumberFormatInfo rupiah = new CultureInfo("id-ID", false).NumberFormat;
                rupiah.CurrencyDecimalDigits = 0;
                if (tbTotal.Text.Length > 0)
                {
                    int total = int.Parse(tbTotal.Text);
                    dtRow = dtPembelian.NewRow();
                    dtRow["Total"] = total.ToString("C", rupiah);
                    dtPembelian.Rows.Add(dtRow);

                    totalTransaksi = totalTransaksi + int.Parse(tbTotal.Text);
                    tbTotal.Text = "";
                    labelOutTotalTrans.Text = totalTransaksi.ToString("C", rupiah);
                    tbTotal.Focus();
                }
            }
        }

        private void tbTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            totalTransaksi = 0;
            labelOutTotalTrans.Text = "";
            dtPembelian.Rows.Clear();

            tbTotal.Focus();
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
            e.Graphics.DrawString("Harga", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(110, 100));
            e.Graphics.DrawString("---------------------------------------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(10, 120));

            int baris = 140;
            NumberFormatInfo rupiah = new CultureInfo("id-ID", false).NumberFormat;
            rupiah.CurrencyDecimalDigits = 0;
            for (int i = 0; i < dtPembelian.Rows.Count; i++)
            {
                e.Graphics.DrawString(dtPembelian.Rows[i][0].ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(100, baris));
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

        int cariUrutanTabel;

        private void dgvPembelian_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            NumberFormatInfo rupiah = new CultureInfo("id-ID", false).NumberFormat;
            rupiah.CurrencyDecimalDigits = 0;

            string data = dtPembelian.Rows[cariUrutanTabel][0].ToString();
            if (data.StartsWith("Rp") == false)
            {
                int dataHarga = int.Parse(dtPembelian.Rows[cariUrutanTabel][0].ToString());
                dtPembelian.Rows[cariUrutanTabel][0] = dataHarga.ToString("C", rupiah);
            }

            int cariUrutan = dgvPembelian.CurrentCell.RowIndex;
            int cariColumn = dgvPembelian.CurrentCell.ColumnIndex;
            int totalTrans = 0;
            if (cariColumn == 0 && dtPembelian.Rows[cariUrutan][cariColumn].ToString() == "Rp0")
            {
                DataRow dr = dtPembelian.Rows[cariUrutan];
                dr.Delete();
            }
            for (int i = 0; i < dtPembelian.Rows.Count; i++)
            {
                string dataTotal = "";
                string[] pisah = dtPembelian.Rows[i][cariColumn].ToString().Split('.');
                for (int j = 0; j < pisah.Length; j++)
                {
                     dataTotal = dataTotal + pisah[j];
                }
                dataTotal = dataTotal.Substring(2);
                totalTrans = totalTrans + int.Parse(dataTotal);
            }
            totalTransaksi = totalTrans;
            labelOutTotalTrans.Text = totalTransaksi.ToString("C", rupiah);
        }

        private void dgvPembelian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cariUrutanTabel = dgvPembelian.CurrentCell.RowIndex;
        }
    }
}
