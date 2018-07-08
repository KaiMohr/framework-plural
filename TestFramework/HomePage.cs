using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestFramework
{
    public class HomePage
    {
        static string Url = "http://pluralsight.com";
        private static string PageTitle = "Unlimited Online Developer, IT and Cyber Security Training | Pluralsight";

        [FindsBy(How = How.LinkText, Using = "authors")]
        private IWebElement authorLink;
        public void SelectAuthor(string authorName)
        {
            authorLink.Click();
          var author =  Browser.Driver.FindElement(By.LinkText(authorName));
            author.Click();
        }

        public void Goto()
        {
            Browser.Goto(Url);
        }

        public bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        public bool IsAuthorPage(string authorName)
        {
            var authorPage = new AuthorPage();
#pragma warning disable CS0618 // Type or member is obsolete
            PageFactory.InitElements(Browser.Driver, authorPage);
#pragma warning restore CS0618 // Type or member is obsolete
            return authorPage.AuthorName == authorName;
        }
    }
}
