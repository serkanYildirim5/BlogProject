using MVC_Blog_Bountry_Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Blog_Bounty_UI.Models
{
    public class Blog_DetailModel
    {
        public List<Comments> Comments { get; set; }
        public Posts Posts { get; set; }
    }
}