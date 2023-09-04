using Cafeautomation.WinForms.MainMenu;
using Cafeautomation.WinForms.WinTools;
using CafeAutomation.Entities.DAL;
using CafeAutomation.Entities.Interfaces;
using CafeAutomation.Entities.Models;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeautomation.WinForms.Users
{
    public partial class frmUserRegister : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context = new CafeContext();
        CafeAutomation.Entities.Models.Users _users;
        UserActions userActions = new UserActions();
        UsersDal usersDal = new UsersDal();
        UserActionsDal actionsDal = new UserActionsDal();
        string _userLogged;
        public frmUserRegister(CafeAutomation.Entities.Models.Users users, string loggedUser = null)
        {
            InitializeComponent();
            _users = users;
            _userLogged = loggedUser;
            toggleActive.DataBindings.Add("EditValue", _users, "IsActive", true);
            txtNameSurname.DataBindings.Add("Text", _users, "NameSurname", true);
            txtAdress.DataBindings.Add("Text", _users, "Adress", true);
            txtPhone.DataBindings.Add("Text", _users, "Phone", true);
            txtEmail.DataBindings.Add("Text", _users, "Email", true);
            txtRole.DataBindings.Add("Text", _users, "Role", true);
            txtUsername.DataBindings.Add("Text", _users, "UserName", true);
            txtPassword.DataBindings.Add("Text", _users, "Password", true);
            txtQuestion.DataBindings.Add("Text", _users, "ReminderQuestion", true);
            txtAnswer.DataBindings.Add("Text", _users, "Answer", true);
            txtDesc.DataBindings.Add("Text", _users, "Description", true);
            if (_users.Id == 0)
            {
                lblTitle.Text = "Yeni Kullanıcı Ekleme Sayfası";
            }
            else if (_users.Id != 0)
            {
                lblTitle.Text = _users.UserName + " Bilgileri";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblTitle.Text == "Yeni Kullanıcı Ekleme Sayfası")
            {
                _users.RegisterDate = DateTime.Now;
                if (usersDal.AddOrUpdate(context, _users))
                {
                    usersDal.Save(context);
                    var model = context.Users.Max(x => x.Id);
                    userActions.UserId = model;
                    string desc = "Yeni kullanıcı eklendi";
                    actionsDal.AddUserActions(context, userActions, desc);
                    frmMainMenu frm = new frmMainMenu();
                    foreach (var item in frm.ribbon.Items)
                    {
                        if (item is BarButtonItem)
                        {
                            var btn = item as BarButtonItem;
                            if (btn.Caption != "")
                            {
                                UserRoles roles = new UserRoles
                                {
                                    UserId = context.Users.Max(x => x.Id),
                                    FormName = "frmMainMenu",
                                    ControlCaption = btn.Caption,
                                    ControlName = btn.Name,
                                    IsVisible = false
                                };
                                context.UserRoles.Add(roles);
                                context.SaveChanges();
                            }
                        }
                    }
                    this.Close();
                }
            }
            else
            {
                if (usersDal.AddOrUpdate(context, _users))
                {
                    usersDal.Save(context);
                    var model = _users.Id;
                    userActions.UserId = model;
                    string desc;
                    if (_userLogged != null)
                    {                      
                        desc = _users.UserName + " bilgilerini değiştirdi";
                    }
                    else
                    {
                        desc = "Yönetici tarafından " + _users.UserName + "`nın bilgileri güncellendi";
                    }
                    actionsDal.AddUserActions(context, userActions, desc);
                    this.Close();
                }
            }
        }
    }
}
