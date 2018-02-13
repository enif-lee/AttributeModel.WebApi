using System.Web.Mvc;
using AttributeModel.Mvc.Example.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AttributeModel.Mvc.Example.Test.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}