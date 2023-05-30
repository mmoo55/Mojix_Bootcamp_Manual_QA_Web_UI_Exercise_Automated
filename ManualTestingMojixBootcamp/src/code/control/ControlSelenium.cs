using OpenQA.Selenium;
using ManualTestingMojixBootcamp.src.code.session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace ManualTestingMojixBootcamp.src.code.control
{
    public class ControlSelenium
    {
        protected By locator;
        protected IWebElement control;
        protected Actions action;

        public ControlSelenium(By locator)
        {
            this.locator = locator;
        }

        protected void FindControl()
        {
            control = session.Session.Instance().GetBrowser().FindElement(locator);
        }

        protected void MouseActions()
        {
            action = new Actions(session.Session.Instance().GetBrowser());
        }

        public Actions GetAction()
        {
            MouseActions();
            return action;
        }

        public void Click()
        {
            FindControl();
            control.Click();
        }

        public void RightClick()
        {
            this.MouseActions();
            this.FindControl();
            action.ContextClick(control).Perform();
        }

        public void MoveToElement(IWebElement element)
        {
            this.GetAction().MoveToElement(element).Perform();
        }

        public Boolean IsControlDisplayed()
        {
            try
            {
                FindControl();
                return control.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string GetText()
        {
            this.FindControl();
            return this.control.Text;
        }

        public string GetAttribute(string attribute)
        {
            this.FindControl();
            return this.control.GetAttribute(attribute);
        }

        public IWebElement GetControl()
        {
            this.FindControl();
            return this.control;
        }

        public void WaitControlIsNotInThePage()
        {
            WebDriverWait explicitWait = new WebDriverWait(session.Session.Instance().GetBrowser(), TimeSpan.FromSeconds(10));
            explicitWait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(this.locator));
        }
    }
}