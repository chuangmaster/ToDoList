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
    public class ToDoListDALTests
    {
        [TestMethod()]
        public void InsertContentTest()
        {
            ToDoListDAL todoDll = new ToDoListDAL();
            bool result = todoDll.InsertContent("代辦1");
            Assert.AreEqual(result, true);

        }

        [TestMethod()]
        public void ReadAllContentEntityTest()
        {
            ToDoListDAL todoDll = new ToDoListDAL();
            List<ContentEntity> list = todoDll.ReadAllContentEntity();
            
        }

        [TestMethod()]
        public void ReadEntityTest()
        {
            ToDoListDAL todoDll = new ToDoListDAL();
            ContentEntity entity = todoDll.ReadEntity("20166498");

        }

        [TestMethod()]
        public void DeleteContentTest()
        {
            ToDoListDAL todoDll = new ToDoListDAL();
            bool result = todoDll.DeleteContent("40574714");
            Assert.AreEqual(result, true);
        }
    }
}