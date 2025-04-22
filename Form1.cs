using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
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
        private static readonly Lazy<Form1> _lazyInstance = new Lazy<Form1>(() => new Form1(), true);
        public static Form1 Instance => _lazyInstance.Value;

        private readonly HttpService _httpService = new HttpService();
        private const string BaseUrl = "https://order-learn-8gtowqh7fdb505b4-1332464681.ap-shanghai.app.tcloudbase.com";

        public Order curOrder;
        public Order newOrder;
        private readonly object _orderLock = new object();
        
        public MySerialPort serialPort = new MySerialPort();
        
        public ConsoleData consoleData = new ConsoleData();
        
        public Form1()
        {
            InitializeComponent();
            _ = GetInfoAsync();
        }
        
        private async Task GetInfoAsync()
        {
            //建立请求
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
                System.Console.WriteLine(ex.Message);
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
            lock (_orderLock)
            {
                if (newOrder.Title != curOrder.Title && curOrder.isOver)
                {
                    curOrder = newOrder;
                }
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

        public void InitPower(int minValue, int maxValue)
        {
            ProgerssBar_Power.Minimum = minValue;
            ProgerssBar_Power.Maximum = maxValue;
        }

        public void UpdatePower(int value)
        {
            ProgerssBar_Power.Value = value;
            Title_Power.Text = ConstString.Power + value + "%";
        }

        public void UpdateLocation(string location)
        {
            Title_Local.Text = ConstString.Location + location;
        }

        public void UpdateState(string status)
        {
            Title_State.Text = ConstString.State + status;
        }

        public void UpdateModel(string model)
        {
            Title_Model.Text = ConstString.Model + model;
        }

        public void UpdateOnWorking(string doing)
        {
            Title_OnWorking.Text = ConstString.OnWorking + doing;
        }

        public void UpdateConsole()
        {
            ListViewItem item = new ListViewItem();
            item.SubItems[0].Text = consoleData.index.ToString();
            item.SubItems.Add(consoleData.time);
            item.SubItems.Add(consoleData.location);
            item.SubItems.Add(consoleData.state);
            item.SubItems.Add(consoleData.action);
            item.SubItems.Add(consoleData.exception);
            item.SubItems.Add(consoleData.information);
            Console.Items.Add(item);
        }
        
        private void Button_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort?.IsOpen ?? true)
                {
                    if (serialPort == null)
                    {
                        serialPort = new MySerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
                    }

                    if (!serialPort.IsOpen)
                    {
                        serialPort.OpenSerialPort();
                    }

                    if (serialPort.IsOpen)
                    {
                        UpdateButtonText("断开串口");
                    }
                }
                else
                {
                    serialPort.CloseSerialPort();
                    UpdateButtonText("连接串口");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"串口操作失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateButtonText(string text)
        {
            Button_Connect.Text = text;
        }
    }
}
