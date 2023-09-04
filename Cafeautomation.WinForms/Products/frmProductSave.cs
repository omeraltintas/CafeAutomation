using CafeAutomation.Entities.DAL;
using CafeAutomation.Entities.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeautomation.WinForms.Products
{
    public partial class frmProductSave : DevExpress.XtraEditors.XtraForm
    {
        MenuDal menuDal = new MenuDal();
        ProductDal productDal = new ProductDal();
        Product _product;
        CafeContext cafeContext = new CafeContext();
        public bool save = false;
        public frmProductSave(Product product)
        {
            InitializeComponent();
            _product = product;
            lookupMenu.Properties.DataSource = menuDal.GetAll(cafeContext);
            lookupMenu.DataBindings.Add("EditValue", _product, "MenuId");
            txtProductName.DataBindings.Add("Text", _product, "ProductName");
            txtProductCode.DataBindings.Add("Text", _product, "ProductCode");
            txtUnitPrice1.DataBindings.Add("Text", _product, "UnitPrice", true);
            txtUnitPrice2.DataBindings.Add("Text", _product, "UnitPrice2", true);
            txtDescription.DataBindings.Add("Text", _product, "Description");
            dateEdit1.DataBindings.Add("Text", _product, "Date", true);
            if (_product.Id != 0)
            {
                if (_product.Image != "")
                {
                    try
                    {
                        pictureEdit1.Image = Image.FromFile(_product.Image);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pictureEdit1.GetLoadedImageLocation() != null)
            {
                string dest = $"{Application.StartupPath}\\Image\\{txtProductName.Text}---{txtProductCode.Text}.jpeg";
                if (File.Exists(dest))
                {
                    File.Delete(dest);
                }
                File.Copy(pictureEdit1.GetLoadedImageLocation(), dest);
                _product.Image = $"Image\\{txtProductName.Text}---{txtProductCode.Text}.jpeg";
            }


            if (productDal.AddOrUpdate(cafeContext, _product))
            {
                productDal.Save(cafeContext);
                save = true;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}