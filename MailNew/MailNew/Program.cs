using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MailNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            //First person
            IndexPage indexPage = new IndexPage(driver);
            LoginPage loginPage = indexPage.OpenLoginPage();
            loginPage.EnterLogin("proj.m.first@gmail.com");
            MainPage mainPage = loginPage.EnterPassword("first9832");
            mainPage.WriteANewLetter("proj.m.second@gmail.com", "QA", "Hello world");
            IndexPage indexPage2 = mainPage.LogOut();

            UsersPage usersPage = indexPage2.OpenNewUser();
            LoginPage loginPage1 = usersPage.OpenLoginPage();
            loginPage1.EnterLogin("proj.m.second@gmail.com");
            MainPage mainPage2 = loginPage.EnterPassword("second9832");
            mainPage2.ReplyToALetter("Hello my friend");
            IndexPage indexPage3 = mainPage2.LogOut();




            //Second person
            //IndexPage new_gmailPage = new IndexPage(driver);
            //LogivPage new_loginPage = new_gmailPage.OpenLoginPage();
            //new_loginPage.EnterLogin("proj.m.second@gmail.com");
            //MainPage new_mainPage = new_loginPage.EnterPassword("second9832");
            //new_mainPage.ReplyToALetter("Hello my friend");
            driver.Close();
        }
    }
}