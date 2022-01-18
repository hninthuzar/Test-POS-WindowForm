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
    public partial class frmCategoryList : Form
    {
        public bool selectedRow = false;
        public frmCategoryList()
        {
            InitializeComponent();
        }

        private void dataGridViewCat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = true;
            this.Close();
        }
    }
}
