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
            ToDoListDLL toDoListDLL = new ToDoListDLL();
            List<ContentEntity> entity = toDoListDLL.ReadAllContentEntity();
            return entity;
        }

        public bool AddContent(string fld_content)
        {
            ToDoListDLL toDoListDLL = new ToDoListDLL();
            bool isSuccess = toDoListDLL.InsertContent(fld_content);
            return isSuccess;
        }

        public bool RemoveContent(string fld_ID)
        {
            ToDoListDLL toDoListDLL = new ToDoListDLL();
            bool isSuccess = toDoListDLL.DeleteContent(fld_ID);
            return isSuccess;
        }
    }
}