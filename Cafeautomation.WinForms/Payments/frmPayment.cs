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
    public partial class frmPayment : DevExpress.XtraEditors.XtraForm
    {
        string _saleCode;
        string _paymentType;
        public PaymentActions paymentActions;
        public bool saved;
        public decimal _remainder;
        public frmPayment(string saleCode, string paymentType, decimal remainder)
        {
            InitializeComponent();
            _saleCode = saleCode;
            _paymentType = paymentType;
            if (_paymentType == "Nakit")
            {
                lblCaption.Text = "Nakit ödeme";
            }
            else if (_paymentType == "Kredi Kartı")
            {
                lblCaption.Text = "Kredi Kartı";
            }
            _remainder = remainder;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            paymentActions=new PaymentActions { 
                SaleCode=_saleCode,
                PaymentType=_paymentType,
                Paid=calcTotal.Value,
                Description=memoEdit1.Text,
                Date=Convert.ToDateTime(dateEdit1.Text)
            };
            saved = true;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            calcTotal.Value = _remainder;
        }
    }
}