using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_go_to_HomePage()
        {
            Pages.HomePage.Goto();
            Assert.IsTrue(Pages.HomePage.IsAt());
        }

        [TestMethod]

        public void Can_go_to_Author_Page()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.SelectAuthor("Matt Milner");
            Assert.IsTrue(Pages.HomePage.IsAuthorPage("Matt Milner"));
        }


//        [TestCleanup]
  //      public void Cleanup()
    //    {
      //      Browser.Close();
      //  }
    }
}
