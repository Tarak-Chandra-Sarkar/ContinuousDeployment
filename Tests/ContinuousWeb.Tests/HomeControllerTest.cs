using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContinuousWeb.Controllers;

namespace ContinuousWeb.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void AboutPageTest()
        {
			var homeController = new HomeController();
            var result = homeController.About();
        }
		
		[TestMethod]
        public void ContactPageTest()
        {
			var homeController = new HomeController();
            var result = homeController.Contact();
        }
    }
}
