using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;

namespace WildberriesParcing
{
    public class WriteInJson
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
      

        public WriteInJson(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void AddToJson()
        {
            List<Final> final = new List<Final>();
            var products = wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.ClassName("card__link"))).ToList();
            int index = 1;

            foreach (var product in products)
            {
                var name = product.FindElement(By.XPath(".//span[@class='b-card__name']"));
                new Actions(driver).MoveToElement(name).Perform();
                final.Add(new Final
                {
                    id = index,
                    name = name.Text,
                    price = product.FindElement(By.XPath(".//span[@data-tag='salePrice']")).Text
                });

                string json = JsonConvert.SerializeObject(final, Formatting.Indented);
                File.WriteAllText(@"D:\wild.json", json);
                index++;
            }
        }
    }
}
