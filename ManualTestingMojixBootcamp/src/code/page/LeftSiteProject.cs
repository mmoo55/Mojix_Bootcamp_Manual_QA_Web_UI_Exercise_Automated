using ManualTestingMojixBootcamp.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualTestingMojixBootcamp.src.code.page
{
    public class LeftSiteProject
    {
        // Add new project
        public Button addNewProjectButton = new Button(By.XPath("//td[text()='Add New Project']"));
        public TextBox projectNameTxtBox = new TextBox(By.Id("NewProjNameInput"));
        public Button addButton = new Button(By.Id("NewProjNameButton"));

        // Submenu project
        public Button subMenuIconButton = new Button(By.XPath("//div[contains(@style,'block')]/img"));
        public Button editButton = new Button(By.XPath("//ul[contains(@style,'block')]//a[text()='Edit']"));
        public TextBox projectNameEditTxtBox = new TextBox(By.XPath("//td/div/input[@id='ItemEditTextbox']"));
        public Button saveButton = new Button(By.XPath("//td/div/img[@id='ItemEditSubmit']"));

        public Button deleteButton = new Button(By.Id("ProjShareMenuDel"));

        public Button ballIconButton = new Button(By.XPath("//ul[@id = 'projectContextMenu']//span[contains(@style, 'ball')]"));

        public Label iconProjectLabel = new Label(By.XPath("(//td[text() = 'Bootcamp'])[last()]//preceding-sibling::td//div[@id = 'ListIcon']"));

        public Boolean ProjectNameIsDisplayed(string nameValue)
        {
            Label nameProject = new Label(By.XPath("(//ul[@id='mainProjectList']/li//td[text()='"+ nameValue + "'])[last()]"));
            return nameProject.IsControlDisplayed();
        }

        public void ClickProjectName(string nameValue)
        {
            Label nameProject = new Label(By.XPath("(//ul[@id='mainProjectList']/li//td[text()='" + nameValue + "'])[last()]"));
            nameProject.Click();
        }

        public void MouseOverOnProjectName(string nameValue)
        {
            Label nameProject = new Label(By.XPath("(//ul[@id='mainProjectList']/li//td[text()='" + nameValue + "'])[last()]"));
            nameProject.MoveToElement(nameProject.GetControl());
        }

        public Boolean IconWasChanged()
        {
            string attribute = iconProjectLabel.GetAttribute("style");
            return attribute.Contains("ball.png");
        }
    }
}
