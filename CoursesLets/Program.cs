using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoursesLets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://courses.letskodeit.com/practice");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            // Test Scenario's-----------------

            // ( 1 )- -------------- Radio Button --------------

            Driver.FindElement(By.XPath("//input[@id='bmwradio']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//input[@id='benzradio']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath(" //input[@id='hondaradio']")).Click();
            Thread.Sleep(2000);

            //(2)-----------------Select Class -------------------

            Driver.FindElement(By.XPath(" //select[@id='carselect'] ")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath(" //select[@id='carselect'] // option[@value='benz']")).Click();
            Thread.Sleep(2000);

            //(3)----------------Multiple Select------------------

            Driver.FindElement(By.XPath(" //select[@id='multiple-select-example'] // option[@value='apple']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath(" //select[@id='multiple-select-example'] // option[@value='orange']")).Click();
            Thread.Sleep(2000);

            //(4) ----------------CheckBox-------------------------

            Driver.FindElement(By.XPath("//input[@id='bmwcheck']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//input[@id='benzcheck']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//input[@id='hondacheck']")).Click();
            Thread.Sleep(2000);

            //(5)---------------Switch Tab------------------

            Driver.FindElement(By.XPath("//a[@id='opentab']")).Click();
            Thread.Sleep(2000);
            string x = Driver.WindowHandles[1];
            string y = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(x);
            Thread.Sleep(2000);
            Driver.Close();

            Thread.Sleep(2000);
            Driver.SwitchTo().Window(y);
            Thread.Sleep(2000);

            //------------------Switch Window----------------------
            Driver.FindElement(By.XPath("//button[@id='openwindow']")).Click();
            Thread.Sleep(2000);

            string a = Driver.WindowHandles[1];
            string b = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(a);
            Thread.Sleep(2000);
            Driver.Close();

            Thread.Sleep(2000);
            Driver.SwitchTo().Window(b);
            Thread.Sleep(2000);

            //----------------Switch To Alert---------------

            Driver.FindElement(By.XPath("//input[@id='name']")).SendKeys("Pappu");
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//input[@id='alertbtn']")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//input[@id='confirmbtn']")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);


            //--------------Web Table--------------

            Driver.FindElement(By.XPath("//table[@id='product']")).Click();
            Thread.Sleep(2000);

            //----------------Mouse Hover------------------

            
            
            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[@id='mousehover']")).Click();
            //Driver.FindElement(By.XPath("//a[@href='#top']")).Click();
            Thread.Sleep(2000);



            js.ExecuteScript("window.scrollBy(0,500)");
            IWebElement top = Driver.FindElement(By.XPath("//button[@id='mousehover']"));
            top.Click();
            Thread.Sleep(2000);
            Actions act = new Actions(Driver);

            act.MoveToElement(Driver.FindElement(By.XPath("//button[@id='mousehover']")))
                    .KeyDown(Keys.Down)
                    .Click()
                .Perform();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,500)");
            Driver.FindElement(By.XPath("//button[@id='mousehover']"))
                   .Click();
            Thread.Sleep(2000);
            Actions action = new Actions(Driver);
            action.MoveToElement(Driver.FindElement(By.XPath("//button[@id='mousehover']")))

                .KeyDown(Keys.Down)
                .KeyDown(Keys.Down)
                .Click()
                .Perform();
            Thread.Sleep(10000);

            Driver.Close();
            Driver.Quit();
        }









    }
}
