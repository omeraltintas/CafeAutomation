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

namespace Cafeautomation.WinForms.Tables
{
    public partial class frmTableActions : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context = new CafeContext();
        TableActionsDal actionsDal = new TableActionsDal();
        int? _tableId, _menuId, _productId;
        public frmTableActions(int? tableId = null, int? menuId = null, int? productId = null)
        {
            InitializeComponent();
            _menuId = menuId;
            _productId = productId;
            _tableId = tableId;
            if (_tableId != null)
            {
                gridControl1.DataSource = actionsDal.GetAll(context, x => x.TableId == _tableId);
                return;
            }
            else if (_menuId != null)
            {
                gridControl1.DataSource = actionsDal.GetAll(context, x => x.Product.MenuId == _menuId);
                return;
            }
            else if (_productId != null)
            {
                gridControl1.DataSource = actionsDal.GetAll(context, x => x.ProductId == _productId);
                return;
            }
            gridControl1.DataSource = actionsDal.GetAll(context);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}