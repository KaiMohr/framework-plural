using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestFramework
{
    public class AuthorPage
    {
        [FindsBy(How = How.ClassName, Using = "author-content")]
        private IWebElement authorName;
        public string AuthorName {
            get
            {return authorName.Text;}
    }

    }
}
