using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Blog_Bountry_Entity.Model
{
    public class Tags:IEntity
    {
        public Tags()
        {
            Posts = new HashSet<Posts>();
        }
        public int TagId { get; set; }
        public string TagName { get; set; }
        public virtual ICollection<Posts> Posts { get; set; }
    }
}
