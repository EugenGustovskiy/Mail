using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailNew
{
    internal class UsersPage : BasePage
    {
        IWebElement _newUser;

        public UsersPage(IWebDriver driver) : base(driver)
        {
            InitializeNewUser();
        }

        private void InitializeNewUser()
        {
            _newUser = FindMailElement(Constants.NEW_USER);
        }

        public LoginPage OpenLoginPage()
        {
            ClickElement(_newUser);
            return new LoginPage(_driver);
        }
    }
}
