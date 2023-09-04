using CafeAutomation.Entities.DAL;
using CafeAutomation.Entities.Models;
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Cafeautomation.WinForms.ReportFiles
{
    public partial class rpOrderVoucher : DevExpress.XtraReports.UI.XtraReport
    {
        CafeContext context=new CafeContext();
        TableActionsDal tableActionsDal=new TableActionsDal();
        public rpOrderVoucher(string saleCode,string info,CafeAutomation.Entities.Models.Sales sales=null)
        {
            InitializeComponent();
            ObjectDataSource dataSource = new ObjectDataSource();
            dataSource.DataSource = tableActionsDal.GetAll(context, x => x.SaleCode == saleCode);
            xrlabelInfo.Text= info;
            this.DataSource = dataSource;
            xrTableProductName.DataBindings.Add("Text",DataSource,"Product.ProductName");
            xrTableAmount.DataBindings.Add("Text", DataSource, "Amount");
            xrTablePrice.DataBindings.Add("Text", DataSource, "UnitPrice");
            xrTableDisc.DataBindings.Add("Text", DataSource, "DiscountPrice");
            xrLabelKalan.Text = sales.Remainder.ToString("C2");
            xrLabelÖdenen.Text = sales.Paid.ToString("C2");
        }

    }
}
