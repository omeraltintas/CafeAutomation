using Cafeautomation.WinForms.WinTools;
using CafeAutomation.Entities.Models;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraReports.UserConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeautomation.WinForms.Roles
{
    public class UserAuthorization
    {
        public static void GetAuthority(CafeContext context, RibbonControl ribbon)
        {
            foreach (var item in ribbon.Items)
            {
                foreach (var role in context.UserRoles.Where(x => x.UserId == UserOptions.userId).ToList())
                {
                    if (item is BarButtonItem)
                    {
                        var btn = item as BarButtonItem;
                        if (btn.Name == role.ControlName && role.IsVisible)
                        {
                            btn.Enabled = true;
                        }
                        if (btn.Name == role.ControlName && !role.IsVisible)
                        {
                            btn.Enabled = false;
                        }
                    }
                }
            }
        }
        public static void IsAdmin(CafeContext context, params dynamic[] obj)
        {
            var adminCheck = context.Users.FirstOrDefault(x => x.Id == UserOptions.userId);
            if (adminCheck.IsAdmin)
            {
                for (int i = 0; i < obj.Length; i++)
                {
                    obj[i].Enabled = true;
                }
            }
            else if (!adminCheck.IsAdmin)
            {
                for (int i = 0; i < obj.Length; i++)
                {
                    obj[i].Enabled = false;
                }
            }
        }
    }
}
