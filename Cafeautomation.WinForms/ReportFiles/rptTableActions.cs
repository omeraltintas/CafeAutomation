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
    public partial class rptTableActions : DevExpress.XtraReports.UI.XtraReport
    {
        CafeContext context=new CafeContext();
        TableActionsDal actionsDal = new TableActionsDal();
        public rptTableActions()
        {
            InitializeComponent();
            ObjectDataSource dataSource= new ObjectDataSource();
            dataSource.DataSource = actionsDal.GetAll(context);
            DataSource=dataSource;
            xrTableId.DataBindings.Add("Text",DataSource,"Id");
            xrTableSaleCode.DataBindings.Add("Text", DataSource, "SaleCode");
            xrTableTableName.DataBindings.Add("Text", DataSource, "Table.TableName");
            xrTableMenu.DataBindings.Add("Text", DataSource, "Menu.Product.MenuName");
            xrTableProductName.DataBindings.Add("Text", DataSource, "Product.ProductName");
            xrTableAmount.DataBindings.Add("Text", DataSource, "Amount");
            xrTablePrice.DataBindings.Add("Text", DataSource, "UnitPrice");
            xrTableDiscPrice.DataBindings.Add("Text", DataSource, "DiscountPrice");
            xrTableDate.DataBindings.Add("Text", DataSource, "Date");
            xrTableDesc.DataBindings.Add("Text", DataSource, "Description");
        }

    }
}
