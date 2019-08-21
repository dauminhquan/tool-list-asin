using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ListProductToAmazon
{

    public partial class listProductToAmazon : Form
    {

        private List<Profile> ListData;
        private int quantity = 100;
        private int timeSleep = 30000;
        private int handingtime = 5;
        private IWebDriver driver;
        private Thread thread;
        private Thread thread2;
        private bool start = false;
        private int next = 0;
        private string patch;
        private string keyActive = "2dc38b146ebf814e9574828ecc3e3cce";
        //private ManualResetEvent mrse = new ManualResetEvent(false);
        public listProductToAmazon()
        {
            InitializeComponent();
            ListData = new List<Profile>();
            string dirPath = @"D:\PROFILE";

            List<string> dirs = new List<string>(Directory.EnumerateDirectories(dirPath));
            lb_find_profile.Text = "Tìm thấy " + dirs.Count + " profile";
        }

        private void btn_start_Click(object sender, EventArgs e)
        {

            try
            {
                quantity = Int32.Parse(tb_quantity.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có số lượng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (quantity < 0)
            {
                MessageBox.Show("Không có số lượng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                timeSleep = Int32.Parse(tb_time_sleep.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thời gian không được nhỏ hơn 1", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (timeSleep < 1)
            {
                MessageBox.Show("Thời gian không được nhỏ hơn 1", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            try
            {
                handingtime = Int32.Parse(tb_handing_time.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Handing time không được nhỏ hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (handingtime <= 0)
            {
                MessageBox.Show("Handing time không được nhỏ hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }



            timeSleep = timeSleep * 1000;




            if (start == false)
            {
                start = true;
                btn_start.BackColor = Color.Lime;
                btn_start.ForeColor = Color.White;
                if (thread == null)
                {
                    ThreadStart job2 = new ThreadStart(running);
                    thread2 = new Thread(job2);
                    thread2.IsBackground = true;
                    thread2.Start();
                }
                else
                {
                    thread2.Resume();
                }

                if (thread == null)
                {
                    ThreadStart job = new ThreadStart(run);
                    thread = new Thread(job);
                    thread.IsBackground = true;
                    thread.Start();

                }
                else
                {
                    thread.Resume();
                }

            }
            else
            {
                btn_start.BackColor = Color.White;
                btn_start.ForeColor = Color.Black;
                start = false;
                thread.Suspend();
                thread2.Suspend();
                next = 0;
                btn_start.Text = "Bắt đầu";
            }


        }

        private void loadData()
        {
            
        }

        private bool checkKey()
        {
            string[] keys = new string[] { };
            try
            {
                keys = File.ReadAllLines(@"log.store", Encoding.UTF8);
            }catch(Exception ex)
            {
                MessageBox.Show("Không có key", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(keys.Count() == 0)
            {
                MessageBox.Show("Không có key", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string key = keys[0];
            if (keyActive != key)
            {
                MessageBox.Show("Key bạn nhập không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

            

        }
        private void run()
        {

            if (ListData.Count() > 0)
            {

                int length = ListData.Count();
                for (int i = 0; i < length; i++)
                {
                    driver.Url = "https://sellercentral.amazon.com/abis/Display/ItemSelected?asin=" + ListData[i].asin;

                    Thread.Sleep(5000);
                    driver.FindElement(By.ClassName("switch-background")).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(By.Name("standard_price")).SendKeys(ListData[i].price);
                    Thread.Sleep(1000);
                    // select the drop down list
                    var education = driver.FindElement(By.Name("condition_type"));
                    //create select element object 
                    var selectElement = new SelectElement(education);
                    selectElement.SelectByValue("new, new");
                    Thread.Sleep(1000);
                    driver.FindElement(By.Name("quantity")).SendKeys(quantity.ToString());
                    Thread.Sleep(1000);
                    driver.FindElement(By.Name("fulfillment_latency")).SendKeys(handingtime.ToString());
                    Thread.Sleep(1000);
                    driver.FindElement(By.Id("main_submit_button")).Click();
                    //before your loop

                    string filePath = @"D:/result.csv";
                    var csv = new StringBuilder();


                    var newLine = string.Format("{0},{1}", ListData[i].asin, ListData[i].price);
                    csv.AppendLine(newLine);

                    //after your loop
                    File.WriteAllText(filePath, csv.ToString());
                    lb_length_listed.Text = "List thành công" + (i + 1).ToString();

                    Thread.Sleep(timeSleep);

                }
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào được tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (driver != null)
            {
                driver.Quit();
            }

        }
        //private void test()
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        lb_length_listed.Text = (i + 1).ToString();
        //        Thread.Sleep(1000);
        //    }
        //}
        private void running()
        {

            while (start)
            {
                int x = next % 5;
                string cham = "";
                for (int j = 0; j < x; j++)
                {
                    cham += ".";
                }
                btn_start.Text = "Tool đang chạy" + cham;
                Thread.Sleep(500);
                next++;
            }
        }

        private void Btn_load_profile_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = @"D:\PROFILE\";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string url = folderBrowserDialog.SelectedPath;
                string lastFolderName = Path.GetFileName(url);
                lb_profile_name.Text = lastFolderName;
                patch = url;
                ChromeOptions options = new ChromeOptions();
                options.AddArgument(@"user-data-dir="+@url);
                driver = new ChromeDriver(options);
            }
          
           
        }

        private void Btn_load_asin_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string url = openFileDialog.FileName;
                    string[] data = File.ReadAllLines(@url, Encoding.UTF8);

                    for (int i = 0; i < data.Length; i++)
                    {
                        if (i > 0 && data[i] != ",")
                        {
                            data[i] = data[i].Replace('\t', ',');
                            string[] dataL = data[i].Split(',');
                            ListData.Add(new Profile(dataL[0], dataL[1], false));
                        }

                    }
                    lbl_length_product_find.Text = "Tìm thấy " + ListData.Count().ToString() + " sản phẩm";
                }
                
               
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Không tìm thấy file", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_start.Visible = false;

            }
        }

        private void Btn_create_profile_Click(object sender, EventArgs e)
        {
            createProfile cP = new createProfile();
            cP.DataSent += Cf_Datasend;
            cP.ShowDialog();

        }

        private void Cf_Datasend(string Msg)
        {
            lb_profile_name.Text = Msg;
            ChromeOptions options = new ChromeOptions();
            options.AddArgument(@"user-data-dir=" + @"D:\PROFILE\"+Msg);

            driver = new ChromeDriver(options);
        }

       
    }
}
