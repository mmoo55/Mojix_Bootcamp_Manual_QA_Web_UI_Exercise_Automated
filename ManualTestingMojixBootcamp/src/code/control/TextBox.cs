using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualTestingMojixBootcamp.src.code.control
{
    public class TextBox : ControlSelenium
    {
        public TextBox(By locator) : base(locator)
        {
        }

        public void SetText(string value)
        {
            FindControl();
            Thread.Sleep(100);
            control.Clear();
            control.SendKeys(value);
        }

        public void SetTextEnter(string value)
        {
            FindControl();
            Thread.Sleep(100);
            control.Clear();
            control.SendKeys(value);
            control.SendKeys(Keys.Enter);
        }
    }
}