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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void btncategoryfrm_Click(object sender, EventArgs e)
        {
            FormCategory frmcategory = new WindowsFormsPos.FormCategory();
            frmcategory.ShowDialog();
        }

        private void btnitemfrm_Click(object sender, EventArgs e)
        {
            FormItem frmitem = new WindowsFormsPos.FormItem();
            frmitem.ShowDialog();
        }

        private void btncustomerfrm_Click(object sender, EventArgs e)
        {
            FormCustomer frmcustomer = new WindowsFormsPos.FormCustomer();
            frmcustomer.ShowDialog();
        }

        private void btnsalefrm_Click(object sender, EventArgs e)
        {
            FormSale frmsale = new WindowsFormsPos.FormSale();
            frmsale.ShowDialog();
        }
    }
}
