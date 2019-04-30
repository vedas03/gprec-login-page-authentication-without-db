using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WindowsFormsApplication27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  label1.Text = "300"; //start from 90 seconds
           // timer1.Start();
            //var driverService = ChromeDriverService.CreateDefaultService();
          //  driverService.HideCommandPromptWindow = true;
            var options = new ChromeOptions();
            //  options.AddArgument("--headless");
            var driver = new ChromeDriver(@"C:\Users\srinivasa rao\Documents\imagerendering\ImageRender\packages\Selenium.WebDriver.ChromeDriver.2.37.0\driver\win32", options);
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            IWebElement element;
            //////options.AddArgument("headless");
            options.AddArgument("window-size=1200x600");
            options.AddArgument("--disbale-gpw");
            //options.AddArgument("--headless");
            string rolls = textBox1.Text;
            string dob = textBox2.Text;
            driver.Navigate().GoToUrl("https://www.gprec.ac.in/studentdetails/studentdetailslogin.aspx");
            var user = driver.FindElement(By.CssSelector("#ctl00_ContentPlaceHolder1_dfRollNo"));
            var pass = driver.FindElement(By.CssSelector("#ctl00_ContentPlaceHolder1_dfDob"));
            try
            {
                user.SendKeys(rolls);
                pass.SendKeys(dob);
                var sub = driver.FindElement(By.CssSelector("#ctl00_ContentPlaceHolder1_ImageButton1"));
                sub.SendKeys(OpenQA.Selenium.Keys.Enter);
                var cgpa = driver.FindElement(By.CssSelector("#ctl00_ContentPlaceHolder1_lblCgpa"));
                MessageBox.Show(cgpa.Text.ToString());


            }
            catch (Exception eeee)
            {
                MessageBox.Show("Password or username wrong");
            }
            //  driver.Navigate().GoToUrl("https://www.gprec.ac.in/studentdetails/studentdetailslogin.aspx");
            //    var pass = driver.FindElement(By.CssSelector("#ctl00_ContentPlaceHolder1_dfDob"));
            //  int i = 17;
            //var xx = "051999";
            //string password = i.ToString() + xx.ToString();
            //pass.SendKeys(password);

            //var sub = driver.FindElement(By.CssSelector("#ctl00_ContentPlaceHolder1_ImageButton1"));
            //sub.SendKeys(Keys.Enter);
            var year = 1997;
            var m = 1;
            var kk = "";
            var km = "";
            //   Console.WriteLine(m);
            //   Console.ReadKey();
            //
            /* while (year <= 2000)
             {
                 string xx = year.ToString();
                 for (var k = 1; k < 35; k++)
                 {

                     if (k < 10)
                     {
                         var j = k.ToString();
                         kk = "0" + j;

                     }

                     else
                     {
                         kk = k.ToString();
                     }
                     if (m < 10)
                     {
                         var mm = m.ToString();
                         km = "0" + m;

                     }
                     else
                     {
                         km = m.ToString();
                     }

                     string password = kk.ToString() + km.ToString() + xx.ToString();
                     try
                     {
                         var pass = driver.FindElement(By.CssSelector("#ctl00_ContentPlaceHolder1_dfDob"));
                         pass.SendKeys(password);

                     }
                     catch (Exception eee)
                     {
                         var cgpa = driver.FindElement(By.CssSelector("#ctl00_ContentPlaceHolder1_lblCgpa"));
                         textBox2.Text = cgpa.ToString();
                     }
                     try
                     {
                         //ctl00_ContentPlaceHolder1_lblCgpa
                         var sub = driver.FindElement(By.CssSelector("#ctl00_ContentPlaceHolder1_ImageButton1"));
                         sub.SendKeys(OpenQA.Selenium.Keys.Enter);

                     }
                     catch(Exception eee)
                     {
                         var cgpa = driver.FindElement(By.CssSelector("#ctl00_ContentPlaceHolder1_lblCgpa"));
                         textBox2.Text = cgpa.ToString();
                     }
                     try
                     {
                         var fail = driver.FindElement(By.CssSelector("#ctl00_ContentPlaceHolder1_Button1"));
                         var cgpa = driver.FindElement(By.CssSelector("#ctl00_ContentPlaceHolder1_lblCgpa"));
                         MessageBox.Show(cgpa.Text.ToString());
                        this. Close();
                     }
                     catch (Exception)
                     {  driver.Navigate().Back(); }
                     if (k > 31)
                     {
                         m++;
                         k = 0;
                     }
                     if (m == 13)
                     {
                         break;

                     }

                 }
                 year++;
                 m = 1;
             }*/
        }
    }
}
