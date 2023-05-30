using ManualTestingMojixBootcamp.src.code.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualTestingMojixBootcamp.src.code.test
{
    public class TaskTest : TestBase
    {
        LeftSiteProject leftSiteProject = new LeftSiteProject();
        TaskSection taskSection = new TaskSection();
        [Test]
        public void VerifyChangeNameOfTaskTest() 
        {
            String projectName = "Bootcamp changes";
            String taskName = "Task";
            String taskNameUpdated = "Task Updated";

            leftSiteProject.ClickProjectName(projectName);
            taskSection.MouseOverOnTaskName(taskName);
            taskSection.subMenuIconButton.Click();
            taskSection.editTaskButton.Click();
            taskSection.taskNameEditTxtBox.SetTextEnter(taskNameUpdated);
            //taskSection.saveIconButton.Click();

            Assert.IsTrue(taskSection.TaskNameIsDisplayed(taskNameUpdated), "ERROR!!! Task name was not updated");
        }

        [Test]
        public void VerifyDueDateAddedToTaskTest()
        {
            String projectName = "Bootcamp changes";
            String taskName = "Task";
            String dueDate = "May 21, 10:30";

            leftSiteProject.ClickProjectName(projectName);
            taskSection.MouseOverOnTaskName(taskName);
            taskSection.ClickOnSetDueDate(taskName);
            taskSection.dueTxtBox.SetText(dueDate);
            taskSection.saveDueDateButton.Click();

            Assert.IsTrue(taskSection.DueDateIsDisplayed(taskName), "Error!!! Task due date was not added");
        }
    }
}
