using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;

namespace TestFramework
{
    public static class Pages
    {
        public static HomePage HomePage {
            get
            {
                var homePage = new HomePage();
#pragma warning disable CS0618 // Type or member is obsolete
                PageFactory.InitElements(Browser.Driver, homePage);
#pragma warning restore CS0618 // Type or member is obsolete
                return homePage;
            }

        }
    }
}
