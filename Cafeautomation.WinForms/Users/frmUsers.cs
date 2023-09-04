using Cafeautomation.WinForms.Roles;
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
    public partial class frmUsers : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context=new CafeContext();
        UsersDal usersDal=new UsersDal();
        public frmUsers()
        {
            InitializeComponent();
            GetList();
            UserAuthorization.IsAdmin(context,btnSave,btnUpdate,btnNew,btnRoles,gridControl1);
        }

        private void GetList()
        {
            gridControl1.DataSource = usersDal.GetAll(context);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmUserRegister frm = new frmUserRegister(new CafeAutomation.Entities.Models.Users());
            frm.ShowDialog();
            GetList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            var model = usersDal.GetByFilter(context,x=>x.Id==id);
            frmUserRegister frm = new frmUserRegister(model);
            frm.ShowDialog();
            GetList();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            frmUserRoles frm = new frmUserRoles(id);
            frm.ShowDialog(); 
        }
    }
}