using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Blog_Bountry_Entity.Model
{
    public class Posts:IEntity
    {
        public Posts()
        {
            Comments = new HashSet<Comments>();
            Tags = new HashSet<Tags>();
            Categorys = new HashSet<Categorys>();
        }
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostText { get; set; }
        public bool PostActive { get; set; }
        public DateTime Date { get; set; }
        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }
        public virtual ICollection<Categorys> Categorys { get; set; }
        public virtual ICollection<Tags> Tags { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }

       
    }
}
