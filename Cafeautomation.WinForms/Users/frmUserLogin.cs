using Cafeautomation.WinForms.WinTools;
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
    public partial class frmUserLogin : DevExpress.XtraEditors.XtraForm
    {
        CafeContext cafeContext = new CafeContext();
        UserActionsDal actionsDal = new UserActionsDal();
        UserActions entity=new UserActions();
        bool login;
        public frmUserLogin()
        {
            InitializeComponent();
            GetInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!login)
            {
                Application.Exit();
            }
            
        }

        private void frmUserLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!login)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var model = cafeContext.Users.FirstOrDefault(x=>x.UserName==txtUserName.Text
            &&x.Password==txtPassword.Text);
            if (model!=null)
            {
                login = true;
                SaveInfo();
                UserOptions.userId = model.Id;
                //entity.UserId = model.Id;
                //string desc = model.UserName+" adlı kullanıcı sisteme giriş yaptı";      
                //actionsDal.AddUserActions(cafeContext, entity, desc);
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void GetInfo()
        {
            if (Properties.Settings.Default.RememberMe)
            {
                txtUserName.Text = Properties.Settings.Default.UserName;
                txtPassword.Text = Properties.Settings.Default.Password;
                checkEdit1.Checked = true;
            }
            else
            {
                txtUserName.Text = null;
                txtPassword.Text = null;
                checkEdit1.Checked = false;
            }
        }
        void SaveInfo()
        {
            if (checkEdit1.Checked)
            {
                Properties.Settings.Default.UserName = txtUserName.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.RememberMe = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = null;
                Properties.Settings.Default.Password = null;
                Properties.Settings.Default.RememberMe = false;
            }
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister= new frmRegister(new CafeAutomation.Entities.Models.Users());
            frmRegister.ShowDialog(this);
            
        }

        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            frmForgotPassword frmForgotPassword = new frmForgotPassword();
            frmForgotPassword.ShowDialog();
        }
    }
}