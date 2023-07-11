using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail
{
    public class IndexPage : BasePage
    {
        IWebElement _signIn;
        
        const string SIGN_IN_XPATH = "//a[contains(text(), 'Sign in')]";


        public IndexPage(IWebDriver driver) : base(driver)
        {
            GoToUrl("https://www.google.com/intl/en/gmail/about/");
            InitializeSignIn();
        }

        private void InitializeSignIn()
        {
            _signIn = FindMailElement(SIGN_IN_XPATH);
        }

        public LogivPage OpenLoginPage()
        {
            ClickElement(_signIn);
            return new LogivPage(_driver);
        }
    }
}