using Cafeautomation.WinForms.Payments;
using Cafeautomation.WinForms.Products;
using Cafeautomation.WinForms.ReportFiles;
using Cafeautomation.WinForms.ReportForms;
using CafeAutomation.Entities.DAL;
using CafeAutomation.Entities.Models;
using DevExpress.Utils;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeautomation.WinForms.Tables
{
    public partial class frmTableOrders : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context = new CafeContext();
        CustomersDal customersDal = new CustomersDal();
        TableActionsDal actionsDal = new TableActionsDal();
        int? _tableId = null;
        string _saleCode = null;
        PaymentActionsDal paymentActionsDal = new PaymentActionsDal();
        CafeAutomation.Entities.Models.Sales sales;
        SalesDal salesDal = new SalesDal();
        frmChooseProduct frmChooseProduct = new frmChooseProduct();
        Table table;
        TablesDal tablesDal = new TablesDal();
        ProductDal productDal = new ProductDal();
        MenuDal menuDal = new MenuDal();
        bool _packageOrder = false;
        bool print;
        public frmTableOrders(int? tableId = null, string tableName = null, string saleCode = null, bool packageOrder = false)
        {
            InitializeComponent();
            _tableId = tableId;
            _saleCode = saleCode;
            _packageOrder = packageOrder;
            context.TableActions.Where(x => x.SaleCode == _saleCode).Load();
            context.Product.Load();
            context.PaymentActions.Where(x => x.SaleCode == _saleCode).Load();
            gridOrders.DataSource = context.TableActions.Local.ToBindingList();
            gridControlPayments.DataSource = context.PaymentActions.Local.ToBindingList();
            lookUpCustomer.Properties.DataSource = customersDal.GetAll(context);
            sales = salesDal.GetByFilter(context, x => x.SaleCode == _saleCode);
            if (sales != null)
            {
                lookUpCustomer.EditValue = sales.CustomerId;
                txtDesc.Text = sales.Description;
                dateEdit1.Text = (sales.LastProcessDate.ToString("dd.MM.yyyy"));
            }
            table = tablesDal.GetByFilter(context, x => x.Id == _tableId);
            QuickSale();
        }

        public void QuickSale()
        {
            var model = menuDal.GetAll(context);
            foreach (var item in model)
            {
                var page = new XtraTabPage();
                page.Text = item.MenuName;
                page.Name = item.Id.ToString();
                xtraTabControl1.TabPages.Add(page);
                FlowLayoutPanel panel= new FlowLayoutPanel();
                panel.Dock = DockStyle.Fill;
                page.Controls.Add(panel);
                var quickSale = productDal.GetAll(context,x=>x.QuickSale&&x.MenuId==item.Id);
                foreach (var item1 in quickSale)
                {
                    SimpleButton btn = new SimpleButton();
                    btn.Text = item1.ProductName;
                    btn.Name = item1.Id.ToString();
                    btn.Appearance.TextOptions.VAlignment = VertAlignment.Bottom;
                    btn.Size = new Size(75, 75);
                    //var img = Image.FromFile(item1.Image);
                    //ımageList1.Images.Add(img);
                    btn.ImageList = ımageList1;
                    //btn.Image = ımageList1.Images[0];
                    //ımageList1.Images.RemoveAt(0);
                    //btn.Appearance.BackColor = Control.DefaultBackColor;
                    btn.BorderStyle = BorderStyles.NoBorder;
                    panel.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var senderbtn = sender as SimpleButton;            
            int productId = Convert.ToInt32(senderbtn.Name);
            var model = productDal.GetByFilter(context, x => x.Id == productId);
            TableActions tableActions=new TableActions {
                SaleCode=_saleCode,
                TableId=_tableId,
                ProductId=productId,
                Amount=1,
                DiscountPercentage=0,
                UnitPrice=Price(model),
                Description="",
                Date=DateTime.Now
            };
            actionsDal.AddOrUpdate(context, tableActions);
        }

        void Calculate()
        {
            calcTotalDiscount.Value = Convert.ToDecimal(colDiscountPrice.SummaryItem.SummaryValue);
            calcTotalwithDiscount.Value = Convert.ToDecimal(colTotal.SummaryItem.SummaryValue);
            calcPaid.Value = Convert.ToDecimal(colPaid.SummaryItem.SummaryValue);
            calcTotal.Value = calcTotalDiscount.Value + calcTotalwithDiscount.Value;
            calcRemainder.Value = calcTotalwithDiscount.Value - calcPaid.Value;

            if (calcTotal.Value != 0)
            {
                calcDiscounPerc.Value = 100 * Convert.ToDecimal(colDiscountPrice.SummaryItem.SummaryValue)
                    / (Convert.ToDecimal(colTotal.SummaryItem.SummaryValue) + Convert.ToDecimal(colDiscountPrice.SummaryItem.SummaryValue));
            }
            else if (calcTotal.Value == 0)
            {
                calcDiscounPerc.Value = 0;
            }
        }
        private void btnCustomerDel_Click(object sender, EventArgs e)
        {
            lookUpCustomer.EditValue = null;
        }

        private void repositoryDeleteOrder_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili sipariş silinsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridViewOrders.DeleteSelectedRows();
                Calculate();
            }
        }

        private void repositoryPaymentDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili ödeme silinsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridViewPayments.DeleteSelectedRows();
                Calculate();
            }
        }

        decimal Price(Product product)
        {
            decimal unitPrice = product.UnitPrice;
            var model = context.ProgramSettings.FirstOrDefault(x=>x.OptionDefinition=="Birim Fiyatı");
            if (model != null)
            {
                switch (model.OptionName)
                {
                    case "UnitPrice":
                        unitPrice = product.UnitPrice;
                        break;
                    case "UnitPrice2":
                        unitPrice = product.UnitPrice2;
                        break;
                    default:
                        break;
                }
            }
            return unitPrice;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            
            frmChooseProduct.ShowDialog();
            if (frmChooseProduct.chosen)
            {
                TableActions entity = new TableActions
                {
                    SaleCode = _saleCode,
                    TableId = _tableId,
                    ProductId = frmChooseProduct.productModel.Id,
                    Amount = 1,
                    UnitPrice = Price(frmChooseProduct.productModel),
                    DiscountPercentage = 0,
                    Description = "",
                    Date = DateTime.Now,
                };
                actionsDal.AddOrUpdate(context, entity);
            }
        }

        private void gridViewOrders_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //Calculate();
        }

        private void gridViewOrders_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            Calculate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gridViewOrders.RowCount > 0)
            {
                if (dateEdit1.EditValue != null)
                {
                    if (sales == null)
                    {
                        sales = new CafeAutomation.Entities.Models.Sales();
                        sales.SaleCode = _saleCode;
                    }
                    sales.CustomerId = (int?)lookUpCustomer.EditValue;
                    sales.Description = txtDesc.Text;
                    sales.LastProcessDate = Convert.ToDateTime(dateEdit1.EditValue);
                    sales.Remainder = calcRemainder.Value;
                    sales.Paid = calcPaid.Value;
                    sales.Price = calcTotal.Value;
                    sales.DiscountTotal = calcTotalDiscount.Value;
                    sales.IsOrderDelivery = _packageOrder;
                    salesDal.AddOrUpdate(context, sales);
                    context.SaveChanges();
                    print = true;
                }
                else
                {
                    MessageBox.Show("Tarih gerekli", "Altıntaş Yazılım");
                }
            }
            else
            {
                MessageBox.Show("Herhangi bi kayıt bulunamadı", "Altıntaş Yazılım");
            }
        }

        private void btnCash_Click(object sender, EventArgs e)
        {

        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            if (gridViewOrders.RowCount > 0)
            {
                var btn = sender as SimpleButton;
                frmPayment frm = new frmPayment(_saleCode, btn.Text, calcRemainder.Value);
                frm.ShowDialog();
                if (frm.saved)
                {
                    if (paymentActionsDal.AddOrUpdate(context, frm.paymentActions))
                    {
                        gridViewPayments.RefreshData();
                        Calculate();
                    }
                }
            }
        }

        private void gridViewPayments_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            Calculate();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (gridViewOrders.RowCount > 0)
            {
                if (_tableId != null)
                {
                    if (calcRemainder.Value > 0)
                    {
                        if (MessageBox.Show("Onaylarsanız borç kaydedilecek", "Altıntaş Yazılım"
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            if (sales != null)
                            {
                                if (sales.CustomerId == null)
                                {
                                    MessageBox.Show("Müşteri seçin", "Altıntaş Yazılım");
                                }
                                else
                                {
                                    Conclude();
                                    this.Close();
                                }
                            }
                        }
                    }
                    else if (calcRemainder.Value == 0)
                    {
                        Conclude();
                        this.Close();
                    }
                }
            }
        }

        private void Conclude()
        {
            table.SaleCode = null;
            table.TableStatus = false;
            table.Process = null;
            table.UserId = null;
            tablesDal.AddOrUpdate(context, table);
            tablesDal.Save(context);
        }

        private void repositoryPrice_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int productId = Convert.ToInt32(gridViewOrders.GetFocusedRowCellValue(colProductId));
            var model = productDal.GetByFilter(context, x => x.Id == productId);
            barPrice1.Caption = model.UnitPrice.ToString();
            barPrice2.Caption = model.UnitPrice2.ToString();
            radialMenu1.ShowPopup(MousePosition);
        }

        private void Prices(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            gridViewOrders.SetFocusedRowCellValue(colUnitPrice, e.Item.Caption);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            btnSave.PerformClick();
            if (print)
            {
                if (_tableId != null)
                {
                    rpOrderVoucher rpOrder = new rpOrderVoucher(_saleCode, table.TableName, sales);
                    frmShowReport frm = new frmShowReport(rpOrder);
                    frm.ShowDialog();
                }
                else if (_tableId==null)
                {
                    if (sales.CustomerId==null)
                    {
                        rpOrderVoucher rpOrder = new rpOrderVoucher(_saleCode, _saleCode, sales);
                        frmShowReport frm = new frmShowReport(rpOrder);
                        frm.ShowDialog();
                    }
                    else if (sales.CustomerId != null)
                    {
                        rpOrderVoucher rpOrder = new rpOrderVoucher(_saleCode, _saleCode+" "+sales.Customers.NameSurname, sales);
                        frmShowReport frm = new frmShowReport(rpOrder);
                        frm.ShowDialog();
                    }                 
                }

            }
        }
    }
}