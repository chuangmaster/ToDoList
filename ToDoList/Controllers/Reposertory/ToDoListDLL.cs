using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using ToDoListLibrary.Entity.ToDoList;
namespace ToDoListLibrary.Controllers.Reposertory.ToDoList
{
    /// <summary>
    /// To Do Read, Update, Delete
    /// </summary>
    public class ToDoListDLL
    {
        public ContentEntity ReadEntity()
        {
            return new ContentEntity();
        }
        public List<ContentEntity> ReadAllContentEntity()
        {
            return new List<ContentEntity>( );
        }

        public bool InsertContent()
        {
            return false;
        }

        public bool DeleteContent(string fld_ID)
        {
            return false;
        }
    }
}
