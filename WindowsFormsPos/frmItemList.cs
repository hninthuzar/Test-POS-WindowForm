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
    public partial class frmItemList : Form
    {
        public bool selectedRow = false;
        public frmItemList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = true;
            this.Close();
        }

        private void gridProperties(DataGridView grid1)
        {
            grid1.Columns["id"].HeaderText = "DateTime";
            grid1.Columns["code"].HeaderText = "Code";
            grid1.Columns["name"].HeaderText = "Name";
            grid1.Columns["unit"].HeaderText = "Unit";
            grid1.Columns["price"].HeaderText = "Price";
            grid1.Columns["remark"].HeaderText = "Remark";
        }

        private void frmItemList_Load(object sender, EventArgs e)
        {
         
            dataGridView1.DataSource = FormItem.itemList;
            gridProperties(dataGridView1);
         
        }
    }
}
