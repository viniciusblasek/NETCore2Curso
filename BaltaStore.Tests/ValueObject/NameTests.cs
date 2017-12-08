using BaltaStore.Domain.StoreContext.Entities;
using BaltaStore.Domain.StoreContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltaStore.Tests
{
    [TestClass]
    public class NameTests
    {
      private Name validName;
      private Name invalidName;

      public NameTests()
      {
        validName = new Name("Vinicius", "Blasek");
        invalidName = new Name("vi","ta");
      }

       [TestMethod]
        public void ShouldReturnNotificationWhenNameIsNotValid()
        {
          
          Assert.AreEqual(false, invalidName.IsValid);
          Assert.AreEqual(2, invalidName.Notifications.Count);
        }
        
        [TestMethod]
        public void ShouldNotReturnNotificationWhenNameValid()
        {
          Assert.AreEqual(true, validName.IsValid);
          Assert.AreEqual(0, validName.Notifications.Count);
        }

    }
}