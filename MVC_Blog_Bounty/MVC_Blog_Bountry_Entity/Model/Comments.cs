using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Blog_Bountry_Entity.Model
{
    public class Comments:IEntity
    {
        public int CommentId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Comment { get; set; }
        
        //Kullanıcı olunca buraya null geçilebilir kullanıcı Id koy
        public int PostId { get; set; }
        public virtual Posts Posts { get; set; }
    }
}
