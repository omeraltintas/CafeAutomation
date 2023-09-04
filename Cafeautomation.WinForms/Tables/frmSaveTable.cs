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

namespace Cafeautomation.WinForms.Tables
{
    public partial class frmSaveTable : DevExpress.XtraEditors.XtraForm
    {
        CafeContext cafeContext = new CafeContext();
        TablesDal tablesDal = new TablesDal();
        Table _entity;
        public bool _saveTable = false;
        public frmSaveTable(Table entity)
        {
            InitializeComponent();
            _entity = entity;
            txtTableName.DataBindings.Add("Text", _entity, "TableName");
            txtDescription.DataBindings.Add("Text", _entity, "Description");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {           
            if (_entity.Id == 0)
            {
                _entity.TableStatus = false;
                _entity.IsReserved = false;
                _entity.AddedDate = DateTime.Now;
                _entity.LastProcessDate = DateTime.Now;
                _entity.Process = "Yeni masa eklendi";
            }
            else if (_entity.Id!=0)
            {
                _entity.LastProcessDate = DateTime.Now;
                _entity.Process = "masa güncellendi";
            }
            if (tablesDal.AddOrUpdate(cafeContext, _entity))
            {
                tablesDal.Save(cafeContext);
                _saveTable = true;
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}