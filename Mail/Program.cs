using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;

namespace Mail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            IndexPage gmailPage = new IndexPage(driver);
            LogivPage loginPage = gmailPage.OpenLoginPage();
            loginPage.EnterLogin("proj.m.first@gmail.com");
            driver.Close();
        }
    }
}