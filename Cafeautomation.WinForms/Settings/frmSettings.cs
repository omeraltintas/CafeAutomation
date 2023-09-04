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

namespace Cafeautomation.WinForms.Settings
{
    public partial class frmSettings : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context=new CafeContext();
        public frmSettings()
        {
            InitializeComponent();
            List<object> list = new List<object>();
            int i = 0;
            foreach (var item in typeof(Product).GetProperties())
            {
                if (item.Name.Contains("UnitPrice"))
                {
                    list.Insert(i, item.Name);
                    i++;
                }
            }
            lookUpUnitPrice.Properties.DataSource = list;
            GetOption();
        }

        private void GetOption()
        {
            var model = context.ProgramSettings.FirstOrDefault(x => x.OptionDefinition == "Birim Fiyatı");
            if (model != null)
            {
                lookUpUnitPrice.EditValue = model.OptionName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var model = context.ProgramSettings.FirstOrDefault(x => x.OptionDefinition == "Birim Fiyatı");
            if (model!=null)
            {
                model.OptionName = lookUpUnitPrice.EditValue.ToString();
                
            }
            else if(model==null)
            {
                ProgramSettings settings=new ProgramSettings {
                    OptionDefinition="Birim Fiyatı",
                    OptionName=lookUpUnitPrice.EditValue.ToString()
                };
                context.ProgramSettings.Add(settings);
            }
            context.SaveChanges();
            GetOption();
            MessageBox.Show("Ayarlar kaydedildi");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}