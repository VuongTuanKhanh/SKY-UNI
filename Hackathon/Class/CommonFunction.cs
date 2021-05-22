using EmailValidation;
using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Hackathon
{
    class CommonFunction
    {
        // Send Gmail
        public static void Send_Email(string from, string to, string subject, string message, Attachment file = null)
        {
            MailMessage mess = new MailMessage(from, to, subject, message);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("17110313@student.hcmute.edu.vn", "k16111999");
            if (file != null)
            {
                mess.Attachments.Add(file);
            }
            try
            {
                client.Send(mess);
                MessageBox.Show("Send new password success in your email");
            }
            catch
            {
                MessageBox.Show("Unable to connect");
            }
        }

        public static void Send_Email_1(string from, string to, string subject, string message, Attachment file = null)
        {
            MailMessage mess = new MailMessage(from, to, subject, message);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("17110313@student.hcmute.edu.vn", "k16111999");
            if (file != null)
            {
                mess.Attachments.Add(file);
            }
            try
            {
                client.Send(mess);
                MessageBox.Show("Success !");
            }
            catch
            {
                MessageBox.Show("Unable to connect");
            }
        }

        // Get the current time
        public static int getIdOnTime()
        {
            DateTime dateTime = DateTime.Now;
            string hour = dateTime.Hour.ToString();
            string minutes = dateTime.Minute.ToString();
            string secound = dateTime.Second.ToString();
            string miliSecound = dateTime.Millisecond.ToString();
            return int.Parse(hour + minutes + secound + miliSecound);
        }

        // Check Gmail
        public static bool Check_Gmail(string Gmail)
        {
            EmailValidator emailValidator = new EmailValidator();
            EmailValidationResult result = EmailValidationResult.OK;

            if (!emailValidator.Validate(Gmail, out result))
            {
                // No internet connection or mailserver is down or busy
                MessageBox.Show("Unable to check email");
            }

            if (result == EmailValidationResult.OK)
                return true;
            return false;
        }

        // Call Messenger
        public static void CallFacebook(string email, string password, string user_receive)
        {
            try
            {
                var driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                ChromeOptions options = new ChromeOptions();
                options.AddArgument(Application.StartupPath + "chromedriver.exe");
                options.AddArguments("--incognito");
                options.AddArgument(@"--start-maximized");
                options.AddArgument(@"--disable-infobars");
                options.AddArgument("--disable-user-media-security=true");
                options.AddArgument("--use-fake-ui-for-media-stream=1");

                var driver = new ChromeDriver(driverService, options);


                driver.Navigate().GoToUrl("https://www.messenger.com/login.php");
                Thread.Sleep(1000);
                //driver.Manage().Window.Minimize();
                IWebElement query = driver.FindElement(By.CssSelector("#email"));
                query.SendKeys(email);

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                query = driver.FindElement(By.CssSelector("#pass"));
                query.SendKeys(password);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                Thread.Sleep(500);

                query = driver.FindElement(By.CssSelector("#loginbutton"));
                query.Click();
                Thread.Sleep(1000);
                driver.Navigate().GoToUrl("https://www.messenger.com/t/" + user_receive);
                Thread.Sleep(1000);
                query = driver.FindElement(By.XPath(".//*[@data-testid='startVoiceCall']"));
                query.Click();
                Thread.Sleep(5000);
                driver.Quit();
            }
            catch
            {

            }
        }
    }
}
