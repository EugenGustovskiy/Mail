using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailNew
{
    internal class Constants
    {
        //IndexPage
        public const string SIGN_IN_XPATH = "//a[contains(text(), 'Sign in')]";

        //LogivPage
        public const string FIELD_LOGIN_XPATH = "//input[@type = 'email']";
        public const string FURTHER_XPATH = "//button[contains(@class, 'qIypjc TrZEUc lw1w4b')]";
        public const string FIELD_PASSWORD_XPATH = "//input[@type = 'password']";

        //UsersPage
        public const string NEW_USER = "//div[text() = 'Użyj innego konta']";

        //MainPage
        public const string WRITE_NEW_LETTER_XPATH = "//div[contains(text(), 'Написать')]";
        public const string BUTTON_ACCOUNT_GOOGLE_XPATH = "//a[contains(@aria-label, 'Аккаунт Google:')]";
        //MainPage.WriteANewLetter()
        public const string FIELD_RECIPIENTS_XPATH = "(//input[@type='text'])[4]";
        public const string FIELD_TOPIC_XPATH = "//input[@name = 'subjectbox']"; //"//input[contains(@aria-label, 'Тема')]";
        public const string FIELD_TEXT_LETTER_XPATH = "//div[@aria-label = 'Текст письма']";
        public const string SEND_NEW_LETTER_XPATH = "(//div[contains(@aria-label, 'Отправить')])[2]";
        //MainPage.ReplyToALetter()
        public const string FROM_WHOM_LETTER_XPATH = "(//span[@name = 'UserName' and @email = 'proj.m.first@gmail.com'])[2]";
        public const string BUTTON_REPLY_XPATH = "(//span[text() = 'Ответить'])[2]";
        public const string REPLY_FIELD_TEXT_XPATH = "//div[@aria-label = 'Текст письма']";
        public const string SEND_REPLY_XPATH = "//div[text() = 'Отправить']";
        //MainPage.NewLetter()
        public const string NEW_LETTER_XPATH = "//span[contains(text(), 'Hello my friend')]";
        public const string IXRAME_XPATH = "//iframe[@name = 'account']";
        //MainPage.LogOut()
        public const string LOG_OUT_XPATH = "//a[contains(@href, 'Logout')]";
    }
}
