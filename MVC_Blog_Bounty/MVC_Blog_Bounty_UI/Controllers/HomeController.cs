using MVC_Blog_Bountry_BLL.Controller;
using MVC_Blog_Bountry_Entity.Model;
using MVC_Blog_Bounty_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Blog_Bounty_UI.Controllers
{
    public class HomeController : Controller
    {
        PostController post = new PostController();
        TagController tag = new TagController();
        CategoryController category = new CategoryController();
        UserController User = new UserController();
        CommentController comment = new CommentController();
        
        public ActionResult Index()
        {
            IndexModel model=IndexMethod();
            return View(model);
        }

        private IndexModel IndexMethod()
        {
            IndexModel model = new IndexModel();
            model.Categorys = category.Getir();
            model.Posts = post.Getir();
            model.Tags = tag.Getir();
            return model;
        }
       public ActionResult Delete(Posts posts)
        {
            post.Sil(post.Getir(x=>x.PostId==posts.PostId).FirstOrDefault());
            return RedirectToAction("AdminPanel");
        }
        public ActionResult AdminPanel()
        {
            IndexModel model = IndexMethod();
            return View(model);
        }
        [HttpPost]
        public ActionResult AdminPanel(Users users)
        {
            if (User.Getir(x=>x.Email==users.Email).Any() && User.Getir(x => x.Password == users.Password).Any())
            {
                IndexModel model = IndexMethod();
                return View(model);
            }
            return View();
            
        }
        [HttpPost]
        public void PostAdd(Posts posts)
        {

        }
        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }
        public ActionResult Category()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CommentAdd(Comments comments)
        {
            comment.Ekle(comments);
            return RedirectToAction("Blog_Details", blogDetail(comments.PostId).Posts);
        }
        public Blog_DetailModel blogDetail(int id)
        {
            Blog_DetailModel detail = new Blog_DetailModel();
            detail.Posts = post.Getir(x => x.PostId == id).FirstOrDefault();
            detail.Comments = comment.Getir(x => x.PostId == id);
            return detail;
        }

        public ActionResult Blog_Details(Posts posts)
        {
            return View(blogDetail(posts.PostId));
        }

    }
}