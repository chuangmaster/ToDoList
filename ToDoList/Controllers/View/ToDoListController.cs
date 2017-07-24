using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.Models;
using ToDoListLibrary.Controllers.Service.ToDoList;
using ToDoListLibrary.Entity.ToDoList;
namespace ToDoList.Controllers
{
    public class ToDoListController : Controller
    {
        // GET: ToDoList
        public ActionResult Index()
        {
            ToDoListBLL todoListBLL = new ToDoListBLL();
            List<ContentEntity> contentList = todoListBLL.GetListContentEntity();
            ToDoListModel model = new ToDoListModel();
            model.entityList = contentList;
            return View(model);
        }
    }
}
