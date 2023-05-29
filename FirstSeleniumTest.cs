using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace SeleniumTraining
{
    public class Tests

    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            //driver = new EdgeDriver();
            //driver = new FirefoxDriver();
        }

       [TearDown]
        public void TearDown() 
        { 
            driver.Quit();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://google.com");
            driver.FindElement(By.CssSelector("[name=q]")).SendKeys("Selenium");
           
        }
    }
}