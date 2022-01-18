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
    public partial class FormCategory : Form
    {
        List<Category> categorylist = new List<Category>();
        public FormCategory()
        {
            InitializeComponent();
        }

        private void fillComboData()
        {
            List<Category> cboData = new List<Category>();
            cboData.Add(new Category { id = "parent", name = "parent" });
            foreach(var c in categorylist)
            {
                cboData.Add(c);
            }
            
            

            comboparent.DataSource = null;

            comboparent.DisplayMember = "name";
            comboparent.ValueMember = "id";
            comboparent.DataSource = cboData;
            

            

            //string[] catname = { "Category1", "Category2","Category3"}; 
            //foreach(var name in catname)
            //{
            //    comboparent.Items.Add(name);
            //}
            if (categorylist.Count > 0)
                comboparent.SelectedIndex = 0;
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            fillComboData();
        }

    
        private void savebtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                Category categorydata = new Category();
                categorydata.id = DateTime.Now.ToString();
                categorydata.code = txtcatcode.Text;
                categorydata.name = txtname.Text;
                //categorydata.parent = comboparent.SelectedItem.ToString();

                if (categorylist.Count < 1)
                    categorydata.parent = "Parent";

                else
                {
                    categorydata.parentID = comboparent.SelectedValue.ToString();
                    categorydata.parent = comboparent.Text.ToString();
                }

                categorylist.Add(categorydata);
                MessageBox.Show("Saving is completed.");
                fillComboData();
                clearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearData()
        {
            txtcatcode.Text = txtname.Text = string.Empty;
            if (categorylist.Count > 0)
                comboparent.SelectedIndex = 0;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            var match = categorylist.Where(x => x.id == selectedId).SingleOrDefault();
            if(match == null)
            {
                MessageBox.Show("This is not match data.");
                return;
            }

            match.code = txtcatcode.Text;
            match.name = txtname.Text;
            match.parent = comboparent.SelectedItem.ToString();
            
            MessageBox.Show("Updating is completed.");
            clearData();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var match = categorylist.Where(x => x.id == selectedId).SingleOrDefault();
            if(match == null)
            {
                MessageBox.Show("This is not match data.");
                return;
            }

            categorylist.Remove(match);
            MessageBox.Show("Deleting is completed.");
            clearData();
        }

        string selectedId = string.Empty;
        private void btncategorylist_Click(object sender, EventArgs e)
        {
            frmCategoryList frmcatlist = new WindowsFormsPos.frmCategoryList();
            frmcatlist.dataGridViewCat.DataSource = categorylist;
            gridProperties(frmcatlist.dataGridViewCat);
            frmcatlist.ShowDialog();

            if (frmcatlist.selectedRow)
            {
                selectedId = frmcatlist.dataGridViewCat.SelectedRows[0].Cells["id"].Value.ToString();
                txtcatcode.Text = frmcatlist.dataGridViewCat.SelectedRows[0].Cells["code"].Value.ToString();
                txtname.Text = frmcatlist.dataGridViewCat.SelectedRows[0].Cells["name"].Value.ToString();
                comboparent.SelectedItem = frmcatlist.dataGridViewCat.SelectedRows[0].Cells["parent"].Value.ToString();
            }
        }

        private void gridProperties(DataGridView grid)
        {
            grid.Columns["parentID"].Visible = false;
            grid.Columns["id"].HeaderText = "ID";
            grid.Columns["code"].HeaderText = "Category Code";
            grid.Columns["name"].HeaderText = "Category Name";
            grid.Columns["parent"].HeaderText = "Parent Name";


            grid.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            grid.Columns["code"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid.Columns["parent"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnnewcat_Click(object sender, EventArgs e)
        {
            clearData();
        }
    }
}
