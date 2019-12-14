using MVC_Blog_Bountry_BLL.IServices;
using MVC_Blog_Bountry_BLL.Services;
using MVC_Blog_Bountry_DAL.Repository;
using MVC_Blog_Bountry_Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Blog_Bountry_BLL.Controller
{
    public class CommentController : ServiceBase<Comments, int>, ICommentServices
    {
        public CommentController() : base(new CommentRepository())
        {

        }
    }
}
