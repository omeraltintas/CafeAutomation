using CafeAutomation.Entities.DAL;
using CafeAutomation.Entities.Mapping;
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

namespace Cafeautomation.WinForms.Tables
{
    public partial class frmTables : DevExpress.XtraEditors.XtraForm
    {
        CafeContext cafeContext= new CafeContext();
        TablesDal tablesDal = new TablesDal();
        public frmTables()
        {
            InitializeComponent();
            GetAll();
        }

        private void GetAll()
        {
            gridControl1.DataSource = tablesDal.GetAll(cafeContext);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmSaveTable frmSaveTable = new frmSaveTable(new Table());
            frmSaveTable.ShowDialog();
            if (frmSaveTable._saveTable)
            {
                GetAll();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            var tables = tablesDal.GetByFilter(cafeContext,x=>x.Id==selectedId);
            frmSaveTable frmSaveTable = new frmSaveTable(tables);
            frmSaveTable.ShowDialog();
            if (frmSaveTable._saveTable)
            {
                GetAll();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            if (MessageBox.Show("Onaylıyor musunuz", "Uyarı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tablesDal.Delete(cafeContext, p => p.Id == selectedId);
                tablesDal.Save(cafeContext);
                GetAll();
            }
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount>0)
            {
                int selectedId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                var tables = tablesDal.GetByFilter(cafeContext, x => x.Id == selectedId);
                if (tables.TableStatus)
                {
                    tables.TableStatus = false;
                }
                else if (!tables.TableStatus)
                {
                    tables.TableStatus = true;
                }
                tablesDal.Save(cafeContext);
                GetAll();
            }
        }

        private void btnReserved_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                int selectedId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                var tables = tablesDal.GetByFilter(cafeContext, x => x.Id == selectedId);
                if (tables.IsReserved)
                {
                    tables.IsReserved = false;
                }
                else if (!tables.IsReserved)
                {
                    tables.IsReserved = true;
                }
                tablesDal.Save(cafeContext);
                GetAll();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTableActionsClick(object sender, EventArgs e)
        {
            int tableId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            frmTableActions frm=new frmTableActions(tableId:tableId);
            frm.ShowDialog();
        }
    }
}