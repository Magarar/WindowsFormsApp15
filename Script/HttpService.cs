using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp1.Script
{
    /// <summary>
    /// 与后端进行HTTP请求服务
    /// </summary>
    public class HttpService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        /// <summary>
        /// 发送 GET 请求
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private async Task<string> SendGetRequestAsync(string url)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                
                response.EnsureSuccessStatusCode();
                
                string result = await response.Content.ReadAsStringAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("发送 GET 请求时出错: " + ex.Message);
            }
        }
        /// <summary>
        /// 获取客流量
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> GetCountAsync(string url)
        {
            try
            {
                string jsonResponse = await SendGetRequestAsync(url);
                
                JObject json = JObject.Parse(jsonResponse);
                
                string count = json["count"].Value<string>();
                Console.WriteLine("Count: " + count);

                return count;
            }
            catch (Exception ex)
            {
                throw new Exception("解析 JSON 时出错: " + ex.Message);
            }
        }

        /// <summary>
        /// 获取餐桌空余情况
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<bool> GetTableAsync(string url)
        {
            try
            {
                string jsonResponse = await SendGetRequestAsync(url);
                
                JObject json = JObject.Parse(jsonResponse);
                // Console.WriteLine(json);
                
                
                bool exist = json["exists"].Value<bool>();

                return exist;
            }
            catch (Exception ex)
            {
                throw new Exception("解析 JSON 时出错: " + ex.Message);
            }
        }

        /// <summary>
        /// 获取后端最新订单
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<Order> GetOrderAsync(string url)
        {
            try
            {
                string jsonResponse = await SendGetRequestAsync(url);
                Console.WriteLine(jsonResponse);
                Order order = JsonConvert.DeserializeObject<Order>(jsonResponse);
                return order;
            }
            catch (Exception ex)
            {
                throw new Exception("解析 JSON 时出错: " + ex.Message);
            }
        }

        /// <summary>
        /// 请求回传后端
        /// </summary>
        /// <param name="url"></param>
        /// <param name="orderID"></param>
        public async Task UpdateOrderStatus(string url, string orderID)
        {
            try
            {
                var requestBody = new
                {
                    title = orderID
                };
                var json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}