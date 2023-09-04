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

namespace Cafeautomation.WinForms.Payments
{
    public partial class frmPayActions : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context=new CafeContext();
        PaymentActionsDal actionsDal=new PaymentActionsDal();
        public frmPayActions(string saleCode=null)
        {
            InitializeComponent();
            if (saleCode==null)
            {
                gridControl1.DataSource = actionsDal.GetAll(context);
            }
            else if (saleCode != null)
            {
                gridControl1.DataSource=actionsDal.GetAll(context,x=>x.SaleCode==saleCode);
            }
        }
    }
}