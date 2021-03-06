using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitWebDriverTests
{
    public class SoftUniTests
    {
        private WebDriver driver;


        [OneTimeSetUp]
        public void OpenBrowserAndNavigate()
        {
            this.driver = new ChromeDriver();
            driver.Url = "https://softuni.bg";
            driver.Manage().Window.Maximize();

        }
        [OneTimeTearDown]
        public void ShutDown()
        {
            driver.Quit();
        }

        [Test]
        public void Test_AssertMainPageTitle()
        {
            //Arrange

            //Act
            driver.Url = "https://softuni.bg";
            string expectedTitle = "???????? ?? ???????????? - ????????? ???????????";
            
            //Assert
            Assert.That(driver.Title, Is.EqualTo(expectedTitle));
                     
        }

        [Test]
        public void Test_AssertAboutUsTitle()
        {
            //Arrange
            
            //Act
            var zaNasElement = driver.FindElement(By.CssSelector("#header-nav > div.toggle-holder > ul > li:nth-child(1) > a > span"));
            zaNasElement.Click();

            string expectedTitle = "?? ??? - ????????? ???????????";
            
            
            //Assert
            Assert.That(driver.Title, Is.EqualTo(expectedTitle));
                        
        }
    }
}