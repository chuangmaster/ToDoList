using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoListLibrary.Entity.ToDoList;
namespace ToDoListLibrary.Controllers.Service.ToDoList
{
    public class ToDoListBLL
    {
        public List<ContentEntity> GetListContentEntity()
        {
            
            return new List<ContentEntity>();
        }

        public bool AddContent()
        {
            return false;
        }

        public bool RemoveContent(string fld_ID)
        {
            return false;
        }
    }
}