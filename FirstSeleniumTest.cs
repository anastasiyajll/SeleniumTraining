using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace SeleniumTraining
{
    public class Tests

    {
        IWebDriver driver;
        //IWebDriver driver2;
        [SetUp]
        public void Setup()
        {
            ChromeOptions opt = new ChromeOptions();
            //opt.AddArguments ("start-fullscreen", "auto-open-devtools-for-tabs");
            //opt.BinaryLocation = "/home/chrome";
            driver = new ChromeDriver(opt);
            //driver2 = new ChromeDriver();
            //driver = new EdgeDriver();
            //driver = new FirefoxDriver();

        }

       [TearDown]
        public void TearDown() 
        { 
            driver.Quit();
            //driver2.Quit();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://google.com");
           // driver2.Navigate().GoToUrl("https://google.com");
           /*
           foreach (var cookie in driver.Manage().Cookies.AllCookies)
            {
                Console.WriteLine("drv cookies: " + cookie);
            }
            foreach (var cookie in driver2.Manage().Cookies.AllCookies)
            {
                Console.WriteLine("drv2 cookies: " + cookie);
            }
            driver.Manage().Cookies.AddCookie(new Cookie(name: "myCookie", value: "myValue"));
                foreach (var cookie in driver.Manage().Cookies.AllCookies)
            {
                Console.WriteLine("drv cookies: " + cookie);
            }
            driver.Manage().Cookies.DeleteAllCookies();
            foreach (var cookie in driver.Manage().Cookies.AllCookies)
            {
                Console.WriteLine("drv cookies deleted ALL: " + cookie);
            }
            driver.FindElement(By.CssSelector("[name=q]")).SendKeys("Selenium");
           */

            driver.FindElement(By.Name("q")).SendKeys(text: "Selenium");
        }
    }
}