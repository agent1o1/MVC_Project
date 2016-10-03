using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameStore.WebUI.Controllers.WebAPI;
using System.Web.Helpers;

namespace GameStore.UnitTests.API
{
    [TestClass]
    public class GamesAPITests
    {
        [TestMethod]
        public void Empty_Get_Should_Return_A_Json_With_Products_Names()
        {
            GamesAPIController controller = new GamesAPIController();

            Type json = typeof(Json);

            Assert.IsInstanceOfType(controller.Get(), json);
        }
    }
}
