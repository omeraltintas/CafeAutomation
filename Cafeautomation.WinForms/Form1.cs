using CafeAutomation.Entities.DAL;
using CafeAutomation.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeautomation.WinForms
{
    public partial class Form1 : Form
    {
        CafeAutomation.Entities.Models.Menu menu;
        MenuDal menuDal = new MenuDal();
        CafeContext cafeContext = new CafeContext();
        UserActionsDal actionsDal = new UserActionsDal();
        public Form1()
        {
            InitializeComponent();
            menu = new CafeAutomation.Entities.Models.Menu();
            txtMenuAdi.DataBindings.Add("Text", menu, "MenuName");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (menuDal.AddOrUpdate(cafeContext,menu))
            {
                menuDal.Save(cafeContext);
            }
        }
    }
}
