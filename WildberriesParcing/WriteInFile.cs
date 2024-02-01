using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace WildberriesParcing
{
    public class WriteInFile
    {

        private IWebDriver driver;
        private WebDriverWait wait;

        public WriteInFile(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void AddToFile()
        {
            using (StreamWriter sw = new StreamWriter(@"D:\wild.txt", true))
            {

                var products = wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.ClassName("card__link"))).ToList();

                foreach (var product in products)
                {

                    var name = product.FindElement(By.XPath(".//span[@class='b-card__name']"));
                    new Actions(driver).MoveToElement(name).Perform();
                    string goodsName = name.Text;

                    string price = product.FindElement(By.XPath(".//span[@data-tag='salePrice']")).Text;

                    string final = price + " " + goodsName;


                    sw.WriteLine(final);
                }
            }
        }
    }
}
