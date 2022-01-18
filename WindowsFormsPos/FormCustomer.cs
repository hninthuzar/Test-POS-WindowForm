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
    public partial class FormCustomer : Form
    {
        public static List<Customer> customerList = new List<Customer>();
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                Customer cus = new WindowsFormsPos.Customer();
                cus.id = DateTime.Now.ToString();
                cus.code = txtcustcode.Text;
                cus.name = txtname.Text;
                cus.phone = txtphoneno.Text;

                customerList.Add(cus);
                //save to db // 

                MessageBox.Show("Saving is completed");
                
                clearData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void clearData()
        {
            txtcustcode.Text = txtname.Text = txtphoneno.Text = string.Empty;
        }

        private string selectedId = string.Empty;
        private void customerlistbtn_Click(object sender, EventArgs e)
        {
            frmCustomerList frmList = new WindowsFormsPos.frmCustomerList();
            //frmList.dataGridView1.DataSource = customerList;
            //gridProperties(frmList.dataGridView1);
            frmList.ShowDialog();

            if(frmList.selectedRow)
            {
                selectedId =  frmList.dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
                txtcustcode.Text = frmList.dataGridView1.SelectedRows[0].Cells["code"].Value.ToString();
                txtname.Text = frmList.dataGridView1.SelectedRows[0].Cells["name"].Value.ToString();
                txtphoneno.Text = frmList.dataGridView1.SelectedRows[0].Cells["phone"].Value.ToString();
            }
        }

        //private void gridProperties(DataGridView grid)
        //{
        //    grid.Columns["id"].HeaderText = "ID";
        //    grid.Columns["code"].HeaderText = "Customer Code";
        //    grid.Columns["name"].HeaderText = "Customer Name";
        //    grid.Columns["phone"].HeaderText = "Contact No";



        //    grid.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        //    grid.Columns["code"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    grid.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    grid.Columns["phone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //}

        private void updatebtn_Click(object sender, EventArgs e)
        {
            var match = customerList.Where(x => x.id == selectedId).SingleOrDefault();
            if(match == null)
            {

                return;
            }

            match.code = txtcustcode.Text;
            match.name = txtname.Text;
            match.phone = txtphoneno.Text;

            clearData();
            MessageBox.Show("Updating is completed.");
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

            var match = customerList.Where(x => x.id == selectedId).SingleOrDefault();
            if (match == null)
            {

                return;
            }

            customerList.Remove(match);
            clearData();
            MessageBox.Show("Deleted is completed.");
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            clearData();
        }
    }
}
