using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailNew
{
    internal class IndexPage : BasePage
    {
        IWebElement _signIn;

        public IndexPage(IWebDriver driver) : base(driver)
        {
            GoToUrl("https://www.google.com/intl/en/gmail/about/");
            InitializeSignIn();
        }

        private void InitializeSignIn()
        {
            _signIn = FindMailElement(Constants.SIGN_IN_XPATH);
        }

        public LoginPage OpenLoginPage()
        {
            ClickElement(_signIn);
            return new LoginPage(_driver);
        }

        public UsersPage OpenNewUser()
        {
            ClickElement(_signIn);
            return new UsersPage(_driver);
        }
    }
}
