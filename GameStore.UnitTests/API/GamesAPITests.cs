using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameStore.WebUI.Controllers.WebAPI;
using System.Web.Helpers;
using System.Collections.Generic;

namespace GameStore.UnitTests.API
{
    [TestClass]
    public class GamesAPITests
    {
        [TestMethod]
        public void Empty_Get_Request_Should_Return_A_Not_Empty_Collection()
        {
            GamesAPIController controller = new GamesAPIController();

            bool isEmpty = true;

            foreach (var item in controller.Get())
            {
                isEmpty = false;
                break;
            }

            Assert.IsFalse(isEmpty);
        }
    }
}
