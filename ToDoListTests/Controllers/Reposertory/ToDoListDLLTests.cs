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

namespace ToDoListLibrary.Controllers.Reposertory.ToDoList.Tests
{
    [TestClass()]
    public class ToDoListDLLTests
    {
        [TestMethod()]
        public void InsertContentTest()
        {
            ToDoListDLL todoDll = new ToDoListDLL();

            //var connectStr = ConfigurationManager.ConnectionStrings["localDB"].ToString();
            todoDll.InsertContent("def");
            
        }
    }
}