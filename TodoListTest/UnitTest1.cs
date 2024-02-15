using System;
using TodoListLibrary;

namespace TodoListLibrary.Tests
{
    [TestClass]
    public class TodoItemTests
    {
       [TestMethod]
        public void TodoItem_Initialize_With_Null_DueDate_And_CompleteDate()
        {
            
            var todoItem = new TodoItem();

            
            Assert.IsNull(todoItem.DueDate, "DueDate should be null initially.");
            Assert.IsNull(todoItem.CompleteDate, "CompleteDate should be null initially.");
        }

        [TestMethod]
        public void TodoItem_DueDate_Can_Be_Set()
        {
            
            var dueDate = DateTime.Now.AddDays(1);

            
            var todoItem = new TodoItem { DueDate = dueDate };

            
            Assert.AreEqual(dueDate, todoItem.DueDate);
        }

        [TestMethod]
        public void TodoItem_CompleteDate_Can_Be_Set()
        {
            
            var completeDate = DateTime.Now;

            
            var todoItem = new TodoItem { CompleteDate = completeDate };

            
            Assert.AreEqual(completeDate, todoItem.CompleteDate);
        }

        [TestMethod]
        public void TodoItem_Description_Can_Be_Set()
        {
            
            var description = "Finish assignment";

            
            var todoItem = new TodoItem { Description = description };

            
            Assert.AreEqual(description, todoItem.Description);
        }
    }
}
