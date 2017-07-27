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

        [HttpPost]
        public ActionResult Insert(string content)
        {
            string response = string.Empty;
            ToDoListBLL todoListBLL = new ToDoListBLL();
            bool isSuccess = todoListBLL.AddContent(content);
            if (isSuccess)
            {
                return Json(new { success = true, responseText = "InsertSuccess" }, JsonRequestBehavior.DenyGet); ;
            }
            else
            {
                return Json(new { success = false, responseText = "InsertFalse" }, JsonRequestBehavior.DenyGet); ;
            }
        }
        [HttpPost]
        public ActionResult Delete(string fld_id)
        {
            string response = string.Empty;
            ToDoListBLL todoListBLL = new ToDoListBLL();
            bool isSuccess = todoListBLL.RemoveContent(fld_id);
            if (isSuccess)
            {
                return Json(new { success = true, responseText = "DeleteSuccess" }, JsonRequestBehavior.DenyGet); ;
            }
            else
            {
                return Json(new { success = false, responseText = "DeleteFalse" }, JsonRequestBehavior.DenyGet); ;
            }
        }
        [HttpPost]
        public ActionResult Update(string fld_id, bool fld_status)
        {
            string response = string.Empty;
            ToDoListBLL todoListBLL = new ToDoListBLL();
            bool isSuccess = todoListBLL.UpdateContentStatus(fld_id);
            if (isSuccess)
            {
                return Json(new { success = true, responseText = "UpdateSuccess" }, JsonRequestBehavior.DenyGet); ;
            }
            else
            {
                return Json(new { success = false, responseText = "UpdateFalse" }, JsonRequestBehavior.DenyGet); ;
            }
        }
    }
}
