using Cafeautomation.WinForms.Customers;
using Cafeautomation.WinForms.Menus;
using Cafeautomation.WinForms.Payments;
using Cafeautomation.WinForms.Products;
using Cafeautomation.WinForms.ReportFiles;
using Cafeautomation.WinForms.ReportForms;
using Cafeautomation.WinForms.Roles;
using Cafeautomation.WinForms.Sales;
using Cafeautomation.WinForms.Settings;
using Cafeautomation.WinForms.Tables;
using Cafeautomation.WinForms.Users;
using Cafeautomation.WinForms.WinTools;
using CafeAutomation.Entities.DAL;
using CafeAutomation.Entities.Models;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeautomation.WinForms.MainMenu
{
    public partial class frmMainMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        CafeContext cafeContext=new CafeContext();
        UsersDal usersDal = new UsersDal();
        void GetForm(XtraForm xtraForm)
        {
            xtraForm.MdiParent = this;
            xtraForm.Show();
        }
        public frmMainMenu()
        {
            InitializeComponent();
            if (!cafeContext.Users.Any(x => x.UserName == "ömer123"))
            {
                CafeAutomation.Entities.Models.Users users = new CafeAutomation.Entities.Models.Users
                {
                    NameSurname = "denem ad soyad",
                    Phone = "213213",
                    Adress = "asdas ",
                    Email = "mail@gmail.com",
                    Role = "deneme",
                    UserName = "ömer123",
                    Password = "123",
                    ReminderQuestion = "1",
                    Answer = "1",
                    RegisterDate = DateTime.Now,
                    IsAdmin = true
                };
                cafeContext.Users.Add(users);
                cafeContext.SaveChanges();
                foreach (var item in ribbon.Items)
                {
                    if (item is BarButtonItem)
                    {
                        var btn = item as BarButtonItem;
                        if (btn.Caption!="")
                        {
                            UserRoles roles = new UserRoles
                            {
                                UserId = 1,
                                FormName = "frmMainMenu",
                                ControlCaption = btn.Caption,
                                ControlName = btn.Name,
                                IsVisible = true
                            };
                            cafeContext.UserRoles.Add(roles);
                            cafeContext.SaveChanges();
                        }
                    }
                }
            }
            
        }

        private void btnProducts_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frmProducts = new frmProducts();
            GetForm(frmProducts);
        }

        private void btnMenus_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frmMenus = new frmMenus();
            frmMenus.ShowDialog();
        }

        private void btnTables_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frmTables = new frmTables();
            GetForm(frmTables);
        }

        private void btnOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmTableStatus();
            GetForm(frm);
        }

        private void btnCustomers_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmCustomers();
            GetForm(frm);
        }

        private void btnSales_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmSatislar();
            GetForm(frm);
        }

        private void btnPayActions_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmPayActions();
            GetForm(frm);
        }

        private void btnPackageOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Paket sipariş işlemini onaylıyor musunuz","Uyari",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                var model = cafeContext.SaleCode.First();
                string saleCode = model.SaleDefinition + model.Count;
                model.Count++;
                cafeContext.SaveChanges();
                XtraForm frm = new frmTableOrders(saleCode:saleCode,packageOrder:true);
                frm.ShowDialog(); 
            }
        }

        private void btnTableActionsReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            rptTableActions rpt = new rptTableActions();
            frmShowReport2 frm = new frmShowReport2(rpt);
            frm.ShowDialog();
        }

        private void btnSpecialReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSpecialReport frm = new frmSpecialReport();
            frm.ShowDialog();
        }

        private void btnTableActions_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmTableActions();
            frm.ShowDialog();
        }

        private void btnDashboard_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmDashboard();
            GetForm(frm);
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            frmUserLogin frmUserLogin = new frmUserLogin();
            frmUserLogin.ShowDialog();
            UserAuthorization.GetAuthority(cafeContext, ribbon);
        }

        private void btnUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUsers frm=new frmUsers();
            GetForm(frm);
        }

        private void btnMyInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            var model2 = usersDal.GetByFilter(cafeContext, x => x.Id == UserOptions.userId);
            frmUserRegister frm = new frmUserRegister(model2,"asd");
            frm.ShowDialog();
        }

        private void btnSettings_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSettings frm=new frmSettings();
            frm.ShowDialog();
        }

        private void btnGraphic_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmGraphic frm = new frmGraphic();
            GetForm(frm);
        }
    }
}