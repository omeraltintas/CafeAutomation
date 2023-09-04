using CafeAutomation.Entities.Models;
using CafeAutomation.Entities.Repository;
using CafeAutomation.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.DAL
{
    public class MenuDal : EntityRepositoryBase<CafeContext, Menu,MenuValidator>
    {
    }
}
