using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public delegate void DataSendHandler(string Msg);
    public partial class createProfile : Form
    {
        public string input;
        public event DataSendHandler DataSent;
        public createProfile()
        {
            InitializeComponent();
        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {
            this.input = tb_profile_name.Text;
            string dirPath = @"D:\PROFILE";

            List<string> dirs = new List<string>(Directory.EnumerateDirectories(dirPath));
            foreach (var dir in dirs)
            {
                if(dir.Substring(dir.LastIndexOf("\\") + 1) == input)
                {
                    MessageBox.Show("Tên profile đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }
            this.DataSent(input);
            this.Close();
        }
    }
}
