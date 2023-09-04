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
    public class TablesDal : EntityRepositoryBase<CafeContext, Table,TablesValidator>
    {
        public object GetAll(CafeContext context)
        {
            var model=(from t in context.Table join u in context.Users on t.UserId equals u.Id 
                       into kullanici from kullanicimasa in kullanici.DefaultIfEmpty()
                       select new
            {
                t.Id,
                t.TableName,
                t.TableStatus,
                t.IsReserved,
                t.Description,
                t.AddedDate,
                t.LastProcessDate,
                t.Process,
                User=kullanicimasa.UserName
            }).ToList();
            return model;
        }
    }
}
