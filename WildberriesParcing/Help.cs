using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildberriesParcing
{
    internal class Help
    {

        // IWebElement scr = wait.Until(ExpectedConditions.ElementExists(By.XPath("html")));
        /* do
            {
                IWebElement scr = wait.Until(ExpectedConditions.ElementExists(By.XPath("html")));
                scr.SendKeys(Keys.PageDown);
            }
            while (!IsEndOfPage());
         
        // var price = driver.FindElements(By.XPath("[@data-tag='salePrice']"));
        bool IsVkClickable()

        {
            try
            {
                // Проверяем, что элемент vk стал кликабельным
                var vk = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@data-tag=\"vk\"]")));

                // Если элемент vk кликабельный, возвращаем true
                return true;
            }
            catch (NoSuchElementException)
            {
                // Если элемент vk не кликабельный, возвращаем false
                return false;
            }
        }


        bool IsEndOfPage()
        {
            // Получаем высоту всей страницы
            long pageHeight = Convert.ToInt64(((IJavaScriptExecutor)driver).ExecuteScript("return Math.max( document.body.scrollHeight, document.body.offsetHeight, document.documentElement.clientHeight, document.documentElement.scrollHeight, document.documentElement.offsetHeight);"));

            // Получаем текущую прокрутку страницы
            long currentScroll = Convert.ToInt64(((IJavaScriptExecutor)driver).ExecuteScript("return window.pageYOffset || document.documentElement.scrollTop || document.body.scrollTop || 0;"));

            // Проверяем, что текущая прокрутка равна или больше высоты страницы
            return currentScroll >= pageHeight;
        }

        /*
                    foreach (var good in goods)
                    {
                        string goodName = good.FindElement(By.ClassName("b-card__name")).Text;
                        string price = good.FindElement(By.XPath("//span[@data-tag=\"salePrice\"]")).Text;
                        price += " ";

                        (//span[@data-tag="salePrice"])[2]
                        using (StreamWriter sw = new StreamWriter(@"D:\wild.txt", true))  // Используйте true, чтобы добавлять записи, а не перезаписывать файл
                        {
                            sw.WriteLine(price);
                        }
                    }*/

        /* var goods = wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.ClassName("card__link"))).ToList();
         for (int i = 1; i <= goods.Count; i++)
         {
             // Явное ожидание появления цены
             var priceElement = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($"(//span[@data-tag=\"salePrice\"])[{i}]")));
             string price = priceElement.Text;

             // Явное ожидание появления названия
             var nameElement = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($"(//span[@class='b-card__name'])[{i}]")));
             string name = nameElement.Text;

             string final = price + " " + name;

             using (StreamWriter sw = new StreamWriter(@"D:\wild.txt", true))
             {
                 sw.WriteLine(final);
             }
         }*/

    }
}
