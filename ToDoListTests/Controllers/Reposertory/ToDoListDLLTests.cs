using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoListLibrary.Controllers.Reposertory.ToDoList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Web.Configuration;
using System.Web.Hosting;
using ToDoListLibrary.Entity.ToDoList;

namespace ToDoListLibrary.Controllers.Reposertory.ToDoList.Tests
{
    [TestClass()]
    public class ToDoListDLLTests
    {
        [TestMethod()]
        public void InsertContentTest()
        {
            ToDoListDLL todoDll = new ToDoListDLL();
            todoDll.InsertContent("代辦1");

        }

        [TestMethod()]
        public void ReadAllContentEntityTest()
        {
            ToDoListDLL todoDll = new ToDoListDLL();
            List<ContentEntity> list = todoDll.ReadAllContentEntity();

        }

        [TestMethod()]
        public void ReadEntityTest()
        {
            ToDoListDLL todoDll = new ToDoListDLL();
            ContentEntity entity = todoDll.ReadEntity("20166498");
           
        }

        [TestMethod()]
        public void DeleteContentTest()
        {
            ToDoListDLL todoDll = new ToDoListDLL();
            todoDll.DeleteContent("40574714");
        }
    }
}