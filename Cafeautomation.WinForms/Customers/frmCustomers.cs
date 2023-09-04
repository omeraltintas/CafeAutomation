using CafeAutomation.Entities.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeautomation.WinForms.Customers
{
    public partial class frmCustomers : DevExpress.XtraEditors.XtraForm
    {
        CafeContext cafeContext= new CafeContext();
        public frmCustomers()
        {
            InitializeComponent();
            cafeContext.Customers.Load();
            gridControl1.DataSource=cafeContext.Customers.Local.ToBindingList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cafeContext.SaveChanges();
            gridView1.RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan müşteri silinsin mi?", "Uyarı",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
                cafeContext.SaveChanges();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}