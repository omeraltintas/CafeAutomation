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

namespace Cafeautomation.WinForms.Users
{
    public partial class frmForgotPassword : DevExpress.XtraEditors.XtraForm
    {
        CafeContext cafeContext=new CafeContext();
        UsersDal usersDal = new UsersDal();
        UserActions userActions = new UserActions();
        UserActionsDal actionsDal = new UserActionsDal();

        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var entity = usersDal.GetByFilter(cafeContext,
                x=>x.UserName==txtUsername.Text||x.Email==txtUsername.Text);
            if (entity!=null)
            {
                if (entity.ReminderQuestion==txtQuestion.Text&&entity.Answer==txtAnswer.Text)
                {
                    if (txtPassword.Text==txtRepass.Text)
                    {
                        entity.Password= txtPassword.Text;
                        if (usersDal.AddOrUpdate(cafeContext,entity))
                        {
                            usersDal.Save(cafeContext);
                            userActions.UserId = entity.Id;
                            string desc = entity.UserName + " adlı kullanıcı parolası yenilendi";
                            actionsDal.AddUserActions(cafeContext, userActions, desc);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Parola uyuşmadı");
                    }
                }
                else
                {
                    MessageBox.Show("Soru veya cevap yanlış");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}