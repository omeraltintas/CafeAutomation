using CafeAutomation.Entities.Interfaces;
using CafeAutomation.Entities.Models;
using CafeAutomation.Entities.Repository;
using CafeAutomation.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.DAL
{
    public class UserActionsDal : EntityRepositoryBase<CafeContext, UserActions, UserActionsValidator>
    {
       
        public void AddUserActions(CafeContext context, UserActions userActions,string description)
        {
            UserActionsDal userActionsDal = new UserActionsDal();
            userActions.Description = description;
            userActions.Date=DateTime.Now;
            if (userActionsDal.AddOrUpdate(context,userActions))
            {
                userActionsDal.Save(context);
            }
        }
    }
}
