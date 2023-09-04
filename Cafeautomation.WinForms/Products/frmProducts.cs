using Cafeautomation.WinForms.Tables;
using CafeAutomation.Entities.DAL;
using CafeAutomation.Entities.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeautomation.WinForms.Products
{
    public partial class frmProducts : DevExpress.XtraEditors.XtraForm
    {
        CafeContext cafeContext=new CafeContext();
        ProductDal productDal= new ProductDal();
        
        public frmProducts()
        {
            InitializeComponent();
            GetList();
        }

        private void GetList()
        {
            gridControl1.DataSource = productDal.GetAll(cafeContext);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProductSave frmProductSave = new frmProductSave(new Product());
            frmProductSave.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            frmProductSave frmProductSave = new frmProductSave(productDal.
                GetByFilter(cafeContext,p=>p.Id==selectedId));
            frmProductSave.ShowDialog();
            if (frmProductSave.save)
            {
                GetList();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            if (MessageBox.Show("Onaylıyor musunuz","Uyarı",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                productDal.Delete(cafeContext,p=>p.Id==selectedId);
                productDal.Save(cafeContext);
                GetList();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTableActions_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            frmTableActions frm = new frmTableActions(productId: productId);
            frm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cafeContext.SaveChanges();
            GetList();
        }
    }
}