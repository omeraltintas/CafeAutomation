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

namespace Cafeautomation.WinForms.Settings
{
    public partial class frmGraphic : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context=new CafeContext();
        public frmGraphic()
        {
            InitializeComponent();
            var model = context.TableActions.GroupBy(x => x.Product.ProductName).Select(t => new
            {
                ProductName=t.Key,
                Amount=t.Sum(a=>a.Amount),
            }).ToList();
            foreach (var item in model)
            {
                chartControl1.Series["Satış Grafiği"].Points.AddPoint(item.ProductName,Convert.ToDouble(item.Amount));
            }
        }
    }
}