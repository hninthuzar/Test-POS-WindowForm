using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPos
{
    public partial class frmSaleList : Form
    {
        public bool selectedRow = false;
        public frmSaleList()
        {
            InitializeComponent();
        }

        private void frmSaleList_Load(object sender, EventArgs e)
        {
            dataGridViewSale.DataSource = FormSale.salelist;
            gridProperties(dataGridViewSale);
        }

        private void gridProperties(DataGridView grid1)
        {
            grid1.Columns["saleid"].HeaderText = "Sale Id";
            grid1.Columns["date"].HeaderText = "DateTime";
            grid1.Columns["custname"].HeaderText = "Customer Name";
            grid1.Columns["totalamt"].HeaderText = "Total Amount";

            grid1.Columns["saleid"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            grid1.Columns["date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid1.Columns["custname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid1.Columns["totalamt"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridViewSale_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = true;
            this.Close();
        }
    }
}
