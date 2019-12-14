using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Blog_Bountry_Entity.Model
{
    public class Categorys : IEntity
    {
        public Categorys()
        {
            Posts = new HashSet<Posts>();
        }
        public int CateogryId{get;set;}
        public string CategoryName { get; set; }

        public virtual ICollection<Posts> Posts { get; set; }
    }
}
