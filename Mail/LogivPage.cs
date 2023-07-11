using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mail
{
    public class LogivPage : BasePage
    {
        IWebElement _fieldLogin;
        
        const string FIELD_LOGIN_XPATH = "//input[1]";
        const string FURTHER_XPATH = "//button[contains(@class, 'qIypjc TrZEUc lw1w4b')]";
        
        public LogivPage(IWebDriver driver) : base(driver)
        {
            InitializeLogin();
        }

        private void InitializeLogin()
        {
            _fieldLogin = FindMailElement(FIELD_LOGIN_XPATH);
        }

        public void EnterLogin(string login)
        {
            _fieldLogin.SendKeys(login);
            var buttonFurther = FindMailElement(FURTHER_XPATH);
            ClickElement(buttonFurther);
        }
    }
}
