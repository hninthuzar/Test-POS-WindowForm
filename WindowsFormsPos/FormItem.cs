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
    public partial class FormItem : Form
    {
        public static List<Item> itemList = new List<Item>();
        public FormItem()
        {
            InitializeComponent();
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                Item item = new Item();
                item.id = DateTime.Now.ToString();
                item.name = txtname.Text;
                item.code = txtitmcode.Text;
                item.unit = txtunit.Text;
                item.price = Convert.ToInt32(txtprice.Text);
                item.remark = txtremark.Text;

                itemList.Add(item);
                clearData();
                MessageBox.Show("Saving is completed!");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                var match = itemList.Where(x=>x.id == selectedId).SingleOrDefault();                
                if(match == null)
                {
                    return;
                }
                match.name = txtname.Text;
                match.code = txtitmcode.Text;
                match.price = Convert.ToInt32(txtprice.Text);
                match.unit = txtunit.Text;
                match.remark = txtremark.Text;

                MessageBox.Show("Updating is completed.");
                clearData();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error => " + ex.Message);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                var match = itemList.Where(x => x.id == selectedId).SingleOrDefault();
                if(match == null)
                {
                    return;
                }
                itemList.Remove(match);
                clearData();
                MessageBox.Show("Deleting is completed.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void clearData()
        {
            txtitmcode.Text = txtname.Text = txtunit.Text = txtprice.Text = txtremark.Text = string.Empty;
        }

        string selectedId = string.Empty;
        private void btnItemlist_Click(object sender, EventArgs e)
        {
            frmItemList frmitmList = new WindowsFormsPos.frmItemList();
            //frmitmList.dataGridView1.DataSource = itemList;
            //gridProperties(frmitmList.dataGridView1);
            frmitmList.ShowDialog();

            if (frmitmList.selectedRow)
            {
                selectedId = frmitmList.dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
                txtitmcode.Text = frmitmList.dataGridView1.SelectedRows[0].Cells["code"].Value.ToString();
                txtname.Text = frmitmList.dataGridView1.SelectedRows[0].Cells["name"].Value.ToString();
                txtunit.Text = frmitmList.dataGridView1.SelectedRows[0].Cells["unit"].Value.ToString();
                txtprice.Text = frmitmList.dataGridView1.SelectedRows[0].Cells["price"].Value.ToString();
                txtremark.Text = frmitmList.dataGridView1.SelectedRows[0].Cells["remark"].Value.ToString();
            }
        }

        //private void gridProperties(DataGridView grid1)
        //{
        //    grid1.Columns["id"].HeaderText = "DateTime";
        //    grid1.Columns["code"].HeaderText = "Code";
        //    grid1.Columns["name"].HeaderText = "Name";
        //    grid1.Columns["unit"].HeaderText = "Unit";
        //    grid1.Columns["price"].HeaderText = "Price";
        //    grid1.Columns["remark"].HeaderText = "Remark";
        //}

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}
