using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace WildberriesParcing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebDriver driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            driver.Url = "https://www.wildberries.by/";
            driver.Manage().Window.Maximize();

            IWebElement bt = wait.Until(ExpectedConditions.ElementExists(By.XPath("//button[text()=\"Отказаться\"]")));
            bt.Click();

            /*
            int previousItemCount = GetItemCount(driver);

            do
            {
                // Прокручиваем страницу
                for (int i = 0; i < 8; i++)
                {
                    driver.FindElement(By.TagName("html")).SendKeys(Keys.PageDown);
                }
                // Добавьте паузу, чтобы дать странице время загрузиться
                Thread.Sleep(1000);

                int currentItemCount = GetItemCount(driver);

                // Проверяем наличие новых данных на странице
                if (currentItemCount == previousItemCount)
                {
                    // Если новых данных нет, значит, достигли конца страницы
                    break;
                }

                previousItemCount = currentItemCount;

            } while (true);


            int GetItemCount(IWebDriver driver)
            {
                // Ваш код для получения количества элементов на странице
                // Пример: 
                var elements = driver.FindElements(By.ClassName("card__link"));
                return elements.Count;
                //return 0;
            }     
            */

            driver.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
            Thread.Sleep(2000);

           while (driver.FindElement(By.XPath("//button[contains(@class,\"btn--show-more\")]")).Displayed)
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(@class,\"btn--show-more\")]"))).Click();
            }


          //  WriteInFile writeInFile = new WriteInFile(driver);
            //writeInFile.AddToFile();


            WriteInJson writeInJson = new WriteInJson(driver);
            writeInJson.AddToJson();      


            driver.Quit();
        }
    }

}


