using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoListLibrary.Controllers.Reposertory.ToDoList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListLibrary.Controllers.Reposertory.ToDoList.Tests
{
    [TestClass()]
    public class ToDoListDLLTests
    {
        [TestMethod()]
        public void InsertContentTest()
        {
            ToDoListDLL todoDll = new ToDoListDLL();
            todoDll.InsertContent("abc");
            //Assert.Fail();
        }
    }
}