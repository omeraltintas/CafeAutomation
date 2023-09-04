
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
    public partial class frmTableStatus : DevExpress.XtraEditors.XtraForm
    {
        CafeContext cafeContext=new CafeContext();
        CheckButton btnSender;
        SaleCode modelsaleCode;
        string _saleCode;
        int _tableId;
        Table tables;
        TablesDal tablesDal=new TablesDal();
        public frmTableStatus()
        {
            InitializeComponent();
            modelsaleCode=cafeContext.SaleCode.First();
            GetTables();
        }
        public void GetTables()
        {
            flowLayoutPanel1.Controls.Clear();
            cafeContext = new CafeContext();
            var model = cafeContext.Table.ToList();
            for (int i = 0; i < model.Count; i++)
            {
                var btn = new CheckButton();
                btn.Text = model[i].TableName;
                btn.Name = model[i].Id.ToString();
                btn.Tag = model[i].SaleCode;
                btn.Height = 100;
                btn.Width = 75;
                flowLayoutPanel1.Controls.Add(btn);

                if (model[i].IsReserved && !model[i].TableStatus)
                {
                    btn.Appearance.BackColor = Color.Yellow;
                }
                else if (model[i].TableStatus)
                {
                    btn.Appearance.BackColor = Color.Red;
                }
                else if (!model[i].TableStatus)
                {
                    btn.Appearance.BackColor = Color.Green;
                }
                btn.Click += Btn_Click;
            }
        }
        public void RefreshTableStatus()
        {
            btnAddOrder.Enabled = false;
            btnOpenTable.Enabled = false;
            btnReserved.Enabled = false;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
             btnSender=sender as CheckButton;
            _tableId = Convert.ToInt32(btnSender.Name);
            
            RefreshTableStatus();
            if (btnSender.Appearance.BackColor==Color.Yellow)
            {
                btnOpenTable.Enabled = true;
            }
           else if (btnSender.Appearance.BackColor == Color.Green)
            {
                btnOpenTable.Enabled = true;
                btnReserved.Enabled = true;

            }
           else if (btnSender.Appearance.BackColor == Color.Red)
            {
               simpleButton4.Enabled = true;
            }
        }

        private void frmTableStatus_Load(object sender, EventArgs e)
        {

        }

        private void groupCalcs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            _saleCode=btnSender.Tag.ToString();
            frmTableOrders frmTableOrders = new frmTableOrders(tableId: _tableId,tableName:btnSender.Text,saleCode:_saleCode);
            frmTableOrders.ShowDialog();
            btnSender = null;
            RefreshTableStatus();
            GetTables();
        }

        private void btnOpenTable_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(btnSender.Text+" açılsın mı?","Bilgi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                tables = tablesDal.GetByFilter(cafeContext, x => x.Id == _tableId);
                tables.SaleCode = modelsaleCode.SaleDefinition + modelsaleCode.Count;
                tables.TableStatus = true;
                var count = cafeContext.SaleCode.First();
                count.Count++;
                tables.IsReserved = false;
                tablesDal.Save(cafeContext);
                btnSender = null;
                RefreshTableStatus();
                GetTables();
                modelsaleCode = cafeContext.SaleCode.First();
            }
        }

        private void btnReserved_Click(object sender, EventArgs e)
        {
            frmTableReserved frm = new frmTableReserved(_tableId);
            frm.ShowDialog();
            RefreshTableStatus();
            if (frm.processDone)
            {                
                GetTables();        
            }
            btnSender = null;
        }
    }
}