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
    public partial class frmCustomerList : Form
    {
        public bool selectedRow = false;
        public frmCustomerList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = true;
            this.Close();
        }

        private void frmCustomerList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FormCustomer.customerList;
            gridProperties(dataGridView1);
        }

        private void gridProperties(DataGridView grid)
        {
            grid.Columns["id"].HeaderText = "ID";
            grid.Columns["code"].HeaderText = "Customer Code";
            grid.Columns["name"].HeaderText = "Customer Name";
            grid.Columns["phone"].HeaderText = "Contact No";



            grid.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            grid.Columns["code"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid.Columns["phone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
