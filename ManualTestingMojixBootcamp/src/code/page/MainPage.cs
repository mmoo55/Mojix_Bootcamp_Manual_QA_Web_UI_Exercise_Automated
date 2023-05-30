using ManualTestingMojixBootcamp.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualTestingMojixBootcamp.src.code.page
{
    public class MainPage
    {
        public Button loginButton = new Button(By.XPath("//img[@src=\"/Images/design/pagelogin.png\"]"));
    }
}