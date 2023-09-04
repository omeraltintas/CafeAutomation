using Cafeautomation.WinForms.MainMenu;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeautomation.WinForms.Users
{
    public partial class frmRegister : DevExpress.XtraEditors.XtraForm
    {
        CafeContext cafeContext= new CafeContext();
        UsersDal usersDal = new UsersDal();
        CafeAutomation.Entities.Models.Users _entity;
        UserActions userActions=new UserActions();
        UserActionsDal actionsDal= new UserActionsDal();
        
        public frmRegister(CafeAutomation.Entities.Models.Users entity)
        {
            InitializeComponent();
            _entity = entity;
            toggleActive.DataBindings.Add("EditValue",_entity,"IsActive");
            txtNameSurname.DataBindings.Add("Text",_entity,"NameSurname");
            txtPhone.DataBindings.Add("Text", _entity, "Phone");
            txtEmail.DataBindings.Add("Text", _entity, "Email");
            txtRole.DataBindings.Add("Text", _entity, "Role");
            txtUsername.DataBindings.Add("Text", _entity, "UserName");
            txtPassword.DataBindings.Add("Text", _entity, "Password");
            txtQuestion.DataBindings.Add("Text", _entity, "ReminderQuestion");
            txtAnswer.DataBindings.Add("Text", _entity, "Answer");
            txtDesc.DataBindings.Add("Text", _entity, "Description");
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text==txtRepass.Text)
            {
                _entity.RegisterDate = DateTime.Now;
                if (usersDal.AddOrUpdate(cafeContext, _entity))
                {
                    usersDal.Save(cafeContext);
                    var model =cafeContext.Users.Max(x=>x.Id);
                    userActions.UserId = model;
                    string desc = "Yeni kullanıcı eklendi";
                    actionsDal.AddUserActions(cafeContext, userActions,desc);
                    frmMainMenu frm= new frmMainMenu();
                    foreach (var item in frm.ribbon.Items)
                    {
                        if (item is BarButtonItem)
                        {
                            var btn = item as BarButtonItem;
                            if (btn.Caption != "")
                            {
                                UserRoles roles = new UserRoles
                                {
                                    UserId = cafeContext.Users.Max(x=>x.Id),
                                    FormName = "frmMainMenu",
                                    ControlCaption = btn.Caption,
                                    ControlName = btn.Name,
                                    IsVisible = false
                                };
                                cafeContext.UserRoles.Add(roles);
                                cafeContext.SaveChanges();
                            }
                        }
                    }
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Hata");
            }
            
        }
    }
}