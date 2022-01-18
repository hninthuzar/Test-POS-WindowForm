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
    public partial class FormSale : Form
    {
        public static List<Sale> salelist = new List<Sale>();
        List<SaleDetail> saledetaillist = new List<SaleDetail>();

        Sale sale = new WindowsFormsPos.Sale();
        SaleDetail saldetail = new SaleDetail();

        public FormSale()
        {
            InitializeComponent();
        }

        private void FormSale_Load(object sender, EventArgs e)
        {
            //dataGridView1.Columns[""].HeaderText = "ID";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == this.icon.Index)
            {

                frmItemList frmitmList = new WindowsFormsPos.frmItemList();
                 frmitmList.ShowDialog();                

                if (frmitmList.selectedRow)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[this.itmid.Index].Value = frmitmList.dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
                    dataGridView1.Rows[e.RowIndex].Cells[this.id.Index].Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[this.id.Index].Value)+1;
                    dataGridView1.Rows[e.RowIndex].Cells[this.itemcode.Index].Value = frmitmList.dataGridView1.SelectedRows[0].Cells["code"].Value;
                    dataGridView1.Rows[e.RowIndex].Cells[this.itemname.Index].Value = frmitmList.dataGridView1.SelectedRows[0].Cells["name"].Value;
                    dataGridView1.Rows[e.RowIndex].Cells[this.price.Index].Value = frmitmList.dataGridView1.SelectedRows[0].Cells["price"].Value;

                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[this.qty.Index].Value.ToString() != null && dataGridView1.Rows[e.RowIndex].Cells[this.qty.Index].Value.ToString() != "")
            {
                dataGridView1.Rows[e.RowIndex].Cells[this.totalamt.Index].Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[this.price.Index].Value) * Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[this.qty.Index].Value);

                int tAmt = 0;
                for (var i=0;i<dataGridView1.Rows.Count; i++)
                {
                    tAmt += Convert.ToInt32(dataGridView1.Rows[i].Cells[this.totalamt.Index].Value);                    
                }

                txtamt.Text = tAmt.ToString();
            }
            
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                sale.date = dateTimePicker1.Value;
                sale.saleid = DateTime.Now.ToString();
                sale.totalamt = Convert.ToInt32(txtamt.Text);
                sale.custname = txtcustname.Text;

                salelist.Add(sale);
                
                for(int i=0; i< dataGridView1.RowCount-1; i ++)
                {
                    SaleDetail det = new WindowsFormsPos.SaleDetail();
                    det.saleid = sale.saleid;
                    det.itemcode = dataGridView1.Rows[i].Cells[this.itemcode.Index].Value.ToString();
                    det.itemid = dataGridView1.Rows[i].Cells[this.itmid.Index].Value.ToString();
                    det.itemname = dataGridView1.Rows[i].Cells[this.itemname.Index].Value.ToString();
                    //...
                    //...

                    saledetaillist.Add(det);

                }

                MessageBox.Show("Saving is completed.");
                clearData();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearData()
        {
            txtcustname.Text = txtamt.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            dataGridView1.Rows.Clear();
        }

        private void btncust_Click(object sender, EventArgs e)
        {
            frmCustomerList customerList = new frmCustomerList();
            customerList.ShowDialog();

            if (customerList.selectedRow)
            {
                sale.custid = customerList.dataGridView1.SelectedRows[0].Cells["name"].Value.ToString();
                txtcustname.Text = customerList.dataGridView1.SelectedRows[0].Cells["name"].Value.ToString();
            }
        }

        private void btnsalelist_Click(object sender, EventArgs e)
        {
            frmSaleList saleplist = new frmSaleList();
            saleplist.ShowDialog();

            if (saleplist.selectedRow)
            {
                sale = new Sale();
                sale.saleid = saleplist.dataGridViewSale.SelectedRows[0].Cells["saleid"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(saleplist.dataGridViewSale.SelectedRows[0].Cells["date"].Value);
                txtcustname.Text = saleplist.dataGridViewSale.SelectedRows[0].Cells["custname"].Value.ToString();
                txtamt.Text = saleplist.dataGridViewSale.SelectedRows[0].Cells["totalamt"].Value.ToString();

                var detail = saledetaillist.Where(x => x.saleid == sale.saleid);
                dataGridView1.Rows.Clear();
                int _rowIndex = 0;
                foreach(var c in detail)
                {
                    dataGridView1.Rows.Add(++_rowIndex,c.itemid, c.itemcode,null, c.itemname, c.price, c.qty,"","", c.totalamt);
                }

            }
        }
    }
}
