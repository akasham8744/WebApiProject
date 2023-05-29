using ApiTestProject;
using ApiTestProject.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace ApiTestProject.Tests.Controllers
{
    [TestClass]
    public class WebApiTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            WebApiController controller = new WebApiController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
