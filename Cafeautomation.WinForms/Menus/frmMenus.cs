using Cafeautomation.WinForms.Roles;
using Cafeautomation.WinForms.Tables;
using CafeAutomation.Entities.Models;
using DevExpress.XtraEditors;
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

namespace Cafeautomation.WinForms.Menus
{
    public partial class frmMenus : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context=new CafeContext();

        public frmMenus()
        {
            InitializeComponent();
            context.Menu.Load();
            gridControl1.DataSource = context.Menu.Local.ToBindingList();
            UserAuthorization.IsAdmin(context, btnSave,btnDelete);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            gridView1.RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan silinsin mi?","Uyarı",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
                context.SaveChanges();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTableActions_Click(object sender, EventArgs e)
        {
            int menuId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            frmTableActions frm = new frmTableActions(menuId:menuId);
            frm.ShowDialog();
        }
    }
}