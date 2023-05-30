using ManualTestingMojixBootcamp.src.code.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualTestingMojixBootcamp.src.code.test
{
    public class ProjectTest : TestBase
    {
        LeftSiteProject leftSiteProject = new LeftSiteProject();

        [Test]
        public void VerifyCreateProjectTest()
        {
            String projectName = "Bootcamp"; //+ new Date().getTime();

            leftSiteProject.addNewProjectButton.Click();
            leftSiteProject.projectNameTxtBox.SetText(projectName);
            leftSiteProject.addButton.Click();

            Assert.IsTrue(leftSiteProject.ProjectNameIsDisplayed(projectName), "ERROR!!! Project was not created");
        }

        [Test]
        public void VerifyChangeProjectIconTest() 
        {
            String projectName = "Bootcamp";

            leftSiteProject.MouseOverOnProjectName(projectName);
            leftSiteProject.subMenuIconButton.Click();
            leftSiteProject.ballIconButton.Click();

            Assert.IsTrue(leftSiteProject.IconWasChanged(), "ERROR!!! icon was not changed");
        }
    }
}
