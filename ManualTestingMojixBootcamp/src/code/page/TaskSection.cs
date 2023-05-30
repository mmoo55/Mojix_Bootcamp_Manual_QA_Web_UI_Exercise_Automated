using ManualTestingMojixBootcamp.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualTestingMojixBootcamp.src.code.page
{
    public class TaskSection
    {
        public TextBox newTaskTxtBox = new TextBox(By.Id("NewItemContentInput"));
        public Button addTaskButton = new Button(By.Id("NewItemAddButton"));

        // Submenu
        public Button subMenuIconButton = new Button(By.XPath("//img[contains(@style,'inline')]"));
        public Button editTaskButton = new Button(By.XPath("//ul[@id = 'itemContextMenu']//a[text()='Edit']"));
        public TextBox taskNameEditTxtBox = new TextBox(By.XPath("//td[@class = 'ItemContent']//textarea[@id = 'ItemEditTextbox']"));
        public Button saveIconButton = new Button(By.XPath("//td[@class = 'ItemContent']//img[@id = 'ItemEditSubmit']"));

        // Due date && Datepicker
        public TextBox dueTxtBox = new TextBox(By.XPath("//div[contains(@style,'block')]//div[contains(text(), 'Example')]/preceding-sibling::input"));
        public Button saveDueDateButton = new Button(By.XPath("//div[contains(@style, 'block')]//input[@id = 'LinkShowDueDateSave']"));

        public Label GetTaskLabel(String taskName)
        {
            Label taskLabel = new Label(By.XPath("(//div[text() = '" + taskName + "'])[last()]"));
            return taskLabel;
        }

        public Boolean TaskNameIsDisplayed(String nameValue)
        {
            Label nameProject = new Label(By.XPath("//td[@class = 'ItemContent']//div[text() = '" + nameValue + "']"));
            return nameProject.IsControlDisplayed();
        }

        public void MouseOverOnTaskName(String nameValue)
        {
            Label taskLabel = new Label(By.XPath("(//div[text() = '" + nameValue + "'])[last()]"));
            taskLabel.MoveToElement(taskLabel.GetControl());
        }

        public void ClickOnSetDueDate(String nameTask)
        {
            Label setDueDateLabel = new Label(By.XPath("//div[text() = '" + nameTask + "']//preceding-sibling::div//div[contains(@style,'block')]/div"));
            setDueDateLabel.Click();
        }

        public Boolean DueDateIsDisplayed(String nameTask)
        {
            Label setDueDateLabel = new Label(By.XPath("//div[text() = '" + nameTask + "']//preceding-sibling::div//div[contains(@style,'block')]/div"));
            return setDueDateLabel.IsControlDisplayed();
        }
    }
}
