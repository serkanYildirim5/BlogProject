using Core.DataAccess.BaseClasses.EntityFramework;
using MVC_Blog_Bountry_DAL.IRepository;
using MVC_Blog_Bountry_Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Blog_Bountry_DAL.Repository
{
    public class UserRepository:EFRepositoryBase<Users,int,MVC_Blog_BountryContext>,IUserRepository
    {
        public UserRepository():base(new MVC_Blog_BountryContext())
        {

        }
    }
}
