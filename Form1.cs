using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using WindowsFormsApp1.Script;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        
        HttpService httpService = new HttpService();
        public Form1()
        {
            if (instance == null)
            {
                instance = this;
            }
            InitializeComponent();
            GetInfoAsync();
        }
        
        private async Task GetInfoAsync()
        {
            var httpService = new HttpService();

            try
            {
                string result = await httpService.GetCountAsync("https://order-learn-8gtowqh7fdb505b4-1332464681.ap-shanghai.app.tcloudbase.com/GetOrderCount");
                Title_Passager.Text = "当前乘客数：" + result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            Title_Time.Text = "当前时间："+DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            GetInfoAsync();

        }
        
    }
}
