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
    public partial class frmChooseProduct : DevExpress.XtraEditors.XtraForm
    {
        CafeContext cafeContext=new CafeContext();
        ProductDal productDal=new ProductDal();
        public Product productModel;
        public bool chosen;
        public frmChooseProduct()
        {
            InitializeComponent();
            gridControl1.DataSource= productDal.ProductList(cafeContext);
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount>0)
            {
                int productId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                productModel = productDal.GetByFilter(cafeContext, x => x.Id == productId);
                chosen = true;
            }
            this.Close();
        }
    }
}