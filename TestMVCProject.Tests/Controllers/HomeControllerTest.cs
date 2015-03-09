using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using TestMVCProject;
using TestMVCProject.Controllers;

namespace TestMVCProject.Tests
{
	[TestFixture]
	public class HomeControllerTest
	{
		[Test]
		public void Index ()
		{
			// Arrange
			var controller = new HomeController ();

			// Act
			var result = (ViewResult)controller.Index ();
			var isMono = Type.GetType ("Mono.Runtime") != null;
			var expectedRuntime = isMono ? "Mono" : ".NET";

			// Assert
			Assert.AreEqual (expectedRuntime, result.ViewData ["Runtime"]);
		}
	}
}
