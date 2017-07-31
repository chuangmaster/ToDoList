using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoListLibrary.Controllers.Reposertory.ToDoList;
using ToDoListLibrary.Entity.ToDoList;
namespace ToDoListLibrary.Controllers.Service.ToDoList
{
    public class ToDoListBLL
    {
        public List<ContentEntity> GetListContentEntity()
        {
            ToDoListDAL toDoListDAL = new ToDoListDAL();
            List<ContentEntity> entity = toDoListDAL.ReadAllContentEntity();
            return entity;
        }

        public bool AddContent(string fld_content)
        {
            ToDoListDAL toDoListDAL = new ToDoListDAL();
            bool isSuccess = toDoListDAL.InsertContent(fld_content);
            return isSuccess;
        }

        public bool UpdateContentStatus(string fld_ID)
        {
            ToDoListDAL toDoListDAL = new ToDoListDAL();
            ContentEntity entity = toDoListDAL.ReadEntity(fld_ID);
            bool fld_status = entity.fld_status ? false : true;
            bool isSuccess = toDoListDAL.UpdateContent(fld_ID, fld_status);
            return isSuccess;
        }

        public bool RemoveContent(string fld_ID)
        {
            ToDoListDAL toDoListDAL = new ToDoListDAL();
            bool isSuccess = toDoListDAL.DeleteContent(fld_ID);
            return isSuccess;
        }
    }
}