using MVC_Blog_Bountry_Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Blog_Bounty_UI.Models
{
    public class PostAddModel
    {
        public List<Categorys> Categorys { get; set; }
        public Posts Posts { get; set; }
        public List<Tags> Tags { get; set; }
    }
}