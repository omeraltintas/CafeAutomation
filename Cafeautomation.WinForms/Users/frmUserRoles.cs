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
    public partial class frmUserRoles : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context=new CafeContext();
        UserRolesDal rolesDal = new UserRolesDal();
        int _userId;
        public frmUserRoles(int userId)
        {
            InitializeComponent();
            _userId = userId;
            gridControl1.DataSource = rolesDal.GetAll(context,x=>x.UserId==_userId);         
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            rolesDal.Save(context);
            gridView1.RefreshData();
        }
    }
}