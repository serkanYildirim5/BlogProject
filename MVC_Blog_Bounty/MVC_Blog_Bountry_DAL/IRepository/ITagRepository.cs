﻿using Core.DataAccess.IBaseRepository;
using MVC_Blog_Bountry_Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Blog_Bountry_DAL.IRepository
{
    public interface ITagRepository:IRepository<Tags,int>
    {

    }
}