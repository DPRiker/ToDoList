using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using WebAppUnitTest.Controllers;

namespace WebAppUnitTest.Tests.Controllers
{
	[TestClass]
	public class EmployeeControllerTest
	{
		[TestMethod]
		public void Employees()
		{
			// Arrange
			EmployeeController controller = new EmployeeController();

			// Act
			ViewResult result = controller.Index() as ViewResult;

			// Assert
			Assert.IsNotNull(result);
		}
	}
}
