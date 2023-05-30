using ManualTestingMojixBootcamp.src.code.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualTestingMojixBootcamp.src.code.test
{
    public class TestBase
    {
        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();

        string email = "bootcamp@mojix45.com";
        string password = "12345";
        [SetUp]
        public void OpenBrowser()
        {
            session.Session.Instance().GetBrowser().Navigate().GoToUrl("http://todo.ly/");

            mainPage.loginButton.Click();
            loginSection.Login(email, password);
        }

        [TearDown]
        public void CloseBrowser()
        {
            session.Session.Instance().CloseBrowser();
        }
    }
}
