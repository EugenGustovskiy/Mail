using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailNew
{
    internal class MainPage : BasePage
    {
        IWebElement _write;
        IWebElement _user;

        public MainPage(IWebDriver driver) : base(driver)
        {
            _write = FindMailElement(Constants.WRITE_NEW_LETTER_XPATH);
            _user = FindMailElement(Constants.BUTTON_ACCOUNT_GOOGLE_XPATH);
        }

        public void WriteANewLetter(string whom, string subject, string message)
        {
            ClickElement(_write);

            var toWhom = FindMailElement(Constants.FIELD_RECIPIENTS_XPATH);
            var topic = FindMailElement(Constants.FIELD_TOPIC_XPATH);
            var writeLetter = FindMailElement(Constants.FIELD_TEXT_LETTER_XPATH);
            var sendLetter = FindMailElement(Constants.SEND_NEW_LETTER_XPATH);

            toWhom.SendKeys(whom);
            topic.SendKeys(subject);
            writeLetter.SendKeys(message);
            ClickElement(sendLetter);
        }

        public void ReplyToALetter(string message)
        {
            var letter = FindMailElement(Constants.FROM_WHOM_LETTER_XPATH);
            //ClickElement(letter);
            letter.Click();

            var reply = FindMailElement(Constants.BUTTON_REPLY_XPATH);
            ClickElement(reply);

            var text = FindMailElement(Constants.REPLY_FIELD_TEXT_XPATH);
            var send = FindMailElement(Constants.SEND_REPLY_XPATH);

            text.SendKeys(message);
            ClickElement(send);
        }

        public void NewLetter()
        {
            var letter = FindMailElement(Constants.NEW_LETTER_XPATH);
            ClickElement(letter);
        }

        public IndexPage LogOut()
        {
            Thread.Sleep(10000);
            ClickElement(_user);
            var iframe = _driver.FindElement(By.XPath(Constants.IXRAME_XPATH));
            _driver.SwitchTo().Frame(iframe);
            var buttonExit = _driver.FindElement(By.XPath(Constants.LOG_OUT_XPATH));
            //ClickElement(buttonExit);
            buttonExit.Click();
            //_driver.SwitchTo().DefaultContent();
            return new IndexPage(_driver);
        }
    }
}

