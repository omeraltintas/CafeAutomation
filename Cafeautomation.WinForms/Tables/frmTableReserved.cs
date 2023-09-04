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


namespace Cafeautomation.WinForms.Tables
{
    public partial class frmTableReserved : DevExpress.XtraEditors.XtraForm
    {
        int _masaId;
        public bool processDone;
        Table table;
        TablesDal tablesDal = new TablesDal();
        CafeContext cafeContext=new CafeContext();
        public frmTableReserved(int masaId)
        {
            InitializeComponent();
            _masaId = masaId;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            table = tablesDal.GetByFilter(cafeContext, x => x.Id == _masaId);
            table.Process = txtProcess.Text;
            table.LastProcessDate =Convert.ToDateTime(dateEdit1.EditValue);
            table.UserId = UserOptions.userId;
            table.IsReserved = true;
            tablesDal.Save(cafeContext);
            processDone = true;
            this.Close();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}