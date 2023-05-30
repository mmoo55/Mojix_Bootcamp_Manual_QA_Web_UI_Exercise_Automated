using OpenQA.Selenium;
using ManualTestingMojixBootcamp.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualTestingMojixBootcamp.src.code.page
{
    public class LoginSection
    {
        public TextBox emailTxtBox = new TextBox(By.Id("ctl00_MainContent_LoginControl1_TextBoxEmail"));
        public TextBox pwdTxtBox = new TextBox(By.Id("ctl00_MainContent_LoginControl1_TextBoxPassword"));
        public Button loginButton = new Button(By.Id("ctl00_MainContent_LoginControl1_ButtonLogin"));

        public void Login(String user, String pwd)
        {
            emailTxtBox.SetText(user);
            pwdTxtBox.SetText(pwd);
            loginButton.Click();
        }
    }
}