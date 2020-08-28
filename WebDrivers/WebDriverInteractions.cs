using AutoItX3Lib;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace RaidArmyDS
{
    class WebDriverInteractions
    {
        public static string[] proxyData;
        private Proxy webDriverProxy;
        private ChromeOptions webDriverOptions;
        private ChromeDriver webDriver;
        private WebDriverWait webDriverWait;
        private PhoneNumberVerification phoneNumberVerification = new PhoneNumberVerification();

        public WebDriverInteractions()
        {
            proxyData = TXTWriterReader.ReadProxyCreate().Split(new char[] { '@', ':' });
            webDriverProxy = new Proxy();
            webDriverOptions = new ChromeOptions();
            webDriver = new ChromeDriver(@"C:\Users\User\source\repos\RaidArmyDS\WebDrivers", WebDriverOptions);
            webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(30));
        }

        private ChromeOptions WebDriverOptions
        {
            get
            {
                webDriverOptions.Proxy = WebDriverProxy;
                // webDriverOptions.AddArguments("--headless");
                return webDriverOptions;
            }
        }

        private Proxy WebDriverProxy
        {
            get
            {
                webDriverProxy.Kind = ProxyKind.Manual;
                webDriverProxy.HttpProxy = $"{proxyData[0]}:{proxyData[1]}";
                webDriverProxy.FtpProxy = $"{proxyData[0]}:{proxyData[1]}";
                webDriverProxy.SslProxy = $"{proxyData[0]}:{proxyData[1]}";
                // webDriverProxy.SocksProxy = proxyPort[0];
                // webDriverProxy.SocksUserName = proxyPort[1];
                // webDriverProxy.SocksPassword = proxyPort[2];
                return webDriverProxy;
            }
        }

        private IWebElement webDriverElement;
        private AutoItX3 webDriverWindows = new AutoItX3();

        public void CreateDiscordAccount()
        {
            webDriver.Navigate().GoToUrl("https://www.mohmal.com/en/inbox");
            if (proxyData.Length != 2)
            {
                webDriverWindows.WinWait("[CLASS:Chrome_WidgetWin_1]");
                webDriverWindows.Send(proxyData[2]);
                webDriverWindows.Send("{TAB}");
                webDriverWindows.Send(proxyData[3]);
                webDriverWindows.Send("{ENTER}");
            }
            webDriverElement = webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='email']/div[1]")));
            string email = webDriverElement.Text;
            
            webDriver.Navigate().GoToUrl("https://discord.com/register");
            Thread.Sleep(2000);
            webDriverElement = webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[2]/div/div[2]/div/form/div/div[2]/div[1]/div/input")));
            Actions pasteEmail = new Actions(webDriver);
            pasteEmail.MoveToElement(webDriverElement);
            pasteEmail.Click();
            pasteEmail.SendKeys(email);
            pasteEmail.Build().Perform();
            webDriverElement = webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[2]/div/div[2]/div/form/div/div[2]/div[2]/div/input")));
            Actions fillUsername = new Actions(webDriver);
            fillUsername.MoveToElement(webDriverElement);
            fillUsername.Click();
            fillUsername.SendKeys(FormCreate.username);
            fillUsername.Build().Perform();
            Actions fillPassword = new Actions(webDriver);
            webDriverElement = webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[2]/div/div[2]/div/form/div/div[2]/div[3]/div/input")));
            fillPassword.MoveToElement(webDriverElement);
            fillPassword.Click();
            fillPassword.SendKeys(FormCreate.password);
            fillPassword.Build().Perform();
            Actions clickMounth = new Actions(webDriver);
            webDriverElement = webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[2]/div/div[2]/div/form/div/div[2]/div[4]/div[1]/div[1]/div/div/div/div")));
            clickMounth.MoveToElement(webDriverElement);
            clickMounth.Click();
            clickMounth.Build().Perform();
            Actions fillMounth = new Actions(webDriver);
            webDriverElement = webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[3]/div/div[1]/div[1]")));
            fillMounth.MoveToElement(webDriverElement);
            fillMounth.Click();
            fillMounth.Build().Perform();
            Actions clickDay = new Actions(webDriver);
            webDriverElement = webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[2]/div/div[2]/div/form/div/div[2]/div[4]/div[1]/div[2]/div/div/div/div")));
            clickDay.MoveToElement(webDriverElement);
            clickDay.Click();
            clickDay.Build().Perform();
            Actions fillDay = new Actions(webDriver);
            webDriverElement = webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[3]/div/div[1]/div[1]")));
            fillDay.MoveToElement(webDriverElement);
            fillDay.Click();
            fillDay.Build().Perform();
            Actions clickYear = new Actions(webDriver);
            webDriverElement = webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[2]/div/div[2]/div/form/div/div[2]/div[4]/div[1]/div[3]/div/div/div/div")));
            clickYear.MoveToElement(webDriverElement);
            clickYear.Click();
            clickYear.Build().Perform();
            Actions fillYear = new Actions(webDriver);
            webDriverElement = webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[3]/div/div[1]/div[18]")));
            fillYear.MoveToElement(webDriverElement);
            fillYear.Click();
            fillYear.Build().Perform();
            Actions submit = new Actions(webDriver);
            webDriverElement = webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[2]/div/div[2]/div/form/div/div[2]/div[5]/button")));
            submit.MoveToElement(webDriverElement);
            submit.Click();
            submit.Build().Perform();
            ((IJavaScriptExecutor)webDriver).ExecuteScript($"___grecaptcha_cfg.clients[0].X.X.callback('{CaptchaSolving.SolveCaptcha("https://discord.com/register")}')");
            try
            {
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='app-mount']/div[2]/div/div[2]/div[2]/div/div[1]/div[4]/div")));
            }
            catch (WebDriverTimeoutException)
            {
                webDriver.Quit();
                proxyData = TXTWriterReader.ReadProxyCreate().Split(new char[] { '@', ':' });
                webDriverProxy = new Proxy();
                webDriverOptions = new ChromeOptions();
                webDriver = new ChromeDriver(@"C:\Users\User\source\repos\RaidArmyDS\WebDrivers", WebDriverOptions);
                webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(30));
                CreateDiscordAccount();
            }
            Program.formMain.Console($"Created Account: Login - {FormCreate.username} Password - {FormCreate.password}");
        }

        public void VerifyDiscord()
        {
            webDriver.Navigate().GoToUrl("https://www.mohmal.com/en/inbox");
            webDriverElement = webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='inbox-table']/tbody/tr/td[1]/a")));
            Actions verifyEmail = new Actions(webDriver);
            verifyEmail.MoveToElement(webDriverElement);
            verifyEmail.Click();
            verifyEmail.Build().Perform();
            webDriverElement = webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div/div[7]/div/div[2]/iframe")));
            webDriver.SwitchTo().Frame(webDriverElement);
            webDriverElement = webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[2]/div/table/tbody/tr/td/div/table/tbody/tr[2]/td/table/tbody/tr/td/a")));
            Actions verifyButton = new Actions(webDriver);
            verifyButton.MoveToElement(webDriverElement);
            verifyButton.Click();
            verifyButton.Build().Perform();
            Thread.Sleep(3000);
            var tabs = webDriver.WindowHandles;
            try
            {
                webDriver.SwitchTo().Window(tabs[1]);
                webDriver.SwitchTo().Window(tabs[0]).Close();
                tabs = webDriver.WindowHandles;
                webDriver.SwitchTo().Window(tabs[0]);
            }
            catch (ArgumentOutOfRangeException)
            {
                webDriver.SwitchTo().Window(tabs[0]).Close();
                tabs = webDriver.WindowHandles;
                webDriver.SwitchTo().Window(tabs[0]);
            }
            ((IJavaScriptExecutor)webDriver).ExecuteScript($"___grecaptcha_cfg.clients[0].X.X.callback('{CaptchaSolving.SolveCaptcha("https://discordapp.com/verify")}')");
            try
            {
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[2]/div/div[2]/div/section/div/button")));
            }
            catch (WebDriverTimeoutException)
            {
                VerifyDiscord();
                return;
            }
            Program.formMain.Console("Account Verified");
            webDriver.Navigate().GoToUrl("https://discord.com/channels/@me");
            webDriverElement = webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='app-mount']/div[2]/div/div[2]/div[2]/div/div[1]/div[4]/div")));
            Thread.Sleep(3000);
            Actions verifyByPhone = new Actions(webDriver);
            verifyByPhone.MoveToElement(webDriverElement);
            verifyByPhone.Click();
            verifyByPhone.Build().Perform();
            PhoneVerifyDiscord();
        }

        public void PhoneVerifyDiscord(byte divIndex = 5)
        {
            webDriverElement = webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath($"//*[@id='app-mount']/div[6]/div[2]/div/div/div[{divIndex}]/button[1]")));
            Actions listCodes = new Actions(webDriver);
            listCodes.MoveToElement(webDriverElement);
            listCodes.Click();
            listCodes.Build().Perform();
            webDriverElement = webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath($"//*[@id='app-mount']/div[6]/div[2]/div/div/div[{divIndex}]/div/div[3]/div[114]")));
            Actions codeKazakhstan = new Actions(webDriver);
            codeKazakhstan.MoveToElement(webDriverElement);
            codeKazakhstan.Click();
            codeKazakhstan.Build().Perform();
            webDriverElement = webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath($"//*[@id='app-mount']/div[6]/div[2]/div/div/div[{divIndex}]/input")));
            webDriverElement.Clear();
            Actions numberInput = new Actions(webDriver);
            numberInput.MoveToElement(webDriverElement);
            numberInput.Click();
            numberInput.SendKeys(phoneNumberVerification.NumberReservation());
            numberInput.Build().Perform();
            webDriverElement = webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath($"//*[@id='app-mount']/div[6]/div[2]/div/div/div[{divIndex}]/button[2]")));
            Actions send = new Actions(webDriver);
            send.MoveToElement(webDriverElement);
            send.Click();
            send.Build().Perform();
            try
            {
                webDriverElement = webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='app-mount']/div[6]/div[2]/div/div/div[4]/div/input[1]")));
                string response = phoneNumberVerification.Verify();
                if (response == "ACCESS_CANCEL")
                {
                    webDriverElement = webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='app-mount']/div[6]/div[2]/div/div/div[4]/button/div")));
                    Actions resendSms = new Actions(webDriver);
                    resendSms.MoveToElement(webDriverElement);
                    resendSms.Click();
                    resendSms.Build().Perform();
                    Thread.Sleep(300000);
                    PhoneVerifyDiscord();
                    return;
                }
                Actions numbersInput = new Actions(webDriver);
                numbersInput.MoveToElement(webDriverElement);
                numbersInput.Click();
                numbersInput.SendKeys(response);
                numbersInput.Build().Perform();
                Thread.Sleep(2000);
            }
            catch (WebDriverTimeoutException)
            {
                phoneNumberVerification.RecreateNumber();
                PhoneVerifyDiscord(4);
                return;
            }
        }

        public void GetDiscordToken()
        {
            webDriver.Navigate().GoToUrl("https://chrome.google.com/webstore/detail/tampermonkey/dhdgffkkebhmkfjojejmpbldmpobfkfo");
            webDriverElement = webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[5]/div[2]/div/div/div[2]/div[2]/div")));
            Actions addExtension = new Actions(webDriver);
            addExtension.MoveToElement(webDriverElement);
            addExtension.Click();
            addExtension.Build().Perform();
            Thread.Sleep(1000);
            webDriverWindows.WinWait("[CLASS:Chrome_WidgetWin_1]");
            webDriverWindows.Send("{TAB}");
            webDriverWindows.Send("{TAB}");
            webDriverWindows.Send("{ENTER}");
            Thread.Sleep(3000);
            webDriver.Navigate().GoToUrl("chrome-extension://dhdgffkkebhmkfjojejmpbldmpobfkfo/options.html#nav=dashboard");
            Thread.Sleep(3000);
            webDriver.Navigate().GoToUrl("chrome-extension://dhdgffkkebhmkfjojejmpbldmpobfkfo/options.html#nav=new-user-script+editor");
            webDriverElement = webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='div_bmV3LXVzZXItc2NyaXB0X2VkaXQ']/div/div/div[6]/div[1]/div/div/div/div[5]")));
            Actions clearConsole = new Actions(webDriver);
            clearConsole.MoveToElement(webDriverElement);
            clearConsole.Click();
            clearConsole.KeyDown(Keys.LeftControl);
            clearConsole.SendKeys("a");
            clearConsole.KeyUp(Keys.LeftControl);
            clearConsole.SendKeys(Keys.Backspace);
            clearConsole.Build().Perform();
            var tabs = webDriver.WindowHandles;
            webDriver.SwitchTo().Window(tabs[1]).Close();
            tabs = webDriver.WindowHandles;
            webDriver.SwitchTo().Window(tabs[0]);
            string token = System.IO.File.ReadAllText(@"C:\Users\User\source\repos\RaidArmyDS\Services\GetDiscordToken.js");
            Actions pasteScript = new Actions(webDriver);
            pasteScript.MoveToElement(webDriverElement);
            pasteScript.Click();
            pasteScript.SendKeys(token);
            pasteScript.Build().Perform();
            Actions saveScript = new Actions(webDriver);
            saveScript.KeyDown(Keys.LeftControl);
            saveScript.SendKeys("s");
            saveScript.KeyUp(Keys.LeftControl);
            saveScript.Build().Perform();
            Thread.Sleep(1000);
            webDriver.Navigate().GoToUrl("https://discord.com/channels/@me");
            webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
            var alert = webDriver.SwitchTo().Alert();
            Program.formMain.formConfigs.WriteToken(alert.Text.Replace("\"", ""));
            TXTWriterReader.WriteToken(alert.Text.Replace("\"", ""));
            alert.Dismiss();
            webDriver.Quit();
            Program.formMain.Console("Token is Writed");
        }
    }
}
