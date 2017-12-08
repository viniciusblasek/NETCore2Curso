using BaltaStore.Domain.StoreContext.Commands.CustomerCommands.Inputs;
using BaltaStore.Domain.StoreContext.Entities;
using BaltaStore.Domain.StoreContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltaStore.Tests
{
    [TestClass]
    public class CreateCustomerCommandTests
    {
        [TestMethod]
        public void ShouldValidateWhenCommandIsValid()
        {
            var command = new CreateCustomerCommand();
            command.FirstName = "Vinícius";
            command.LastName = "Blasek";
            command.Document = "46986225814";
            command.Email = "vbsilva@bip.b.br";
            command.Phone = "11997664545";

            Assert.AreEqual(true, command.Valid());
        }

    }
}
