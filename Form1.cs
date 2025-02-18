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
        public static Form1 Instance { get; } = new Form1();

        private readonly HttpService _httpService = new HttpService();
        private const string BaseUrl = "https://order-learn-8gtowqh7fdb505b4-1332464681.ap-shanghai.app.tcloudbase.com";

        public Order curOrder;
        public Order newOrder;
        public Form1()
        {
            InitializeComponent();
            _ = GetInfoAsync();
        }
        
        private async Task GetInfoAsync()
        {
            var httpService = new HttpService();

            try
            {
                string result = await _httpService.GetCountAsync($"{BaseUrl}/GetOrderCount");
                Title_Passager.Text = "当前乘客数：" + result;
                await UpdateTableStat();
                await UpdateOrder();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task UpdateTableStat()
        {
            bool isTable0 = await _httpService.GetTableAsync($"{BaseUrl}/GetTable0");
            Pic_Table0.Image = isTable0 ? Properties.Resources.Table1_True : Properties.Resources.Table1_False;

            bool isTable1 = await _httpService.GetTableAsync($"{BaseUrl}/GetTable1");
            Pic_Table1.Image = isTable1 ? Properties.Resources.Table2_True : Properties.Resources.Table2_False;

            bool isTable2 = await _httpService.GetTableAsync($"{BaseUrl}/GetTable2");
            Pic_Table2.Image = isTable2 ? Properties.Resources.Table3_True : Properties.Resources.Table3_False;

            bool isTable3 = await _httpService.GetTableAsync($"{BaseUrl}/GetTable3");
            Pic_Table3.Image = isTable3 ? Properties.Resources.Table4_True : Properties.Resources.Table4_False;
        }

        private async Task UpdateOrder()
        {
            newOrder = await _httpService.GetOrderAsync($"{BaseUrl}/GetLatestOrder");
            if (newOrder.Title != curOrder.Title)
            {
                curOrder = newOrder;
            }
        }
        
        
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            Invoke((Action)(() =>
            {
                Title_Time.Text = "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                GetInfoAsync().ConfigureAwait(false);
            }));

        }

    }
}
