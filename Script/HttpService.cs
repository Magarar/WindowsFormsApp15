using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp1.Script
{
    public class HttpService
    {
        private readonly HttpClient _httpClient;

        public HttpService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> SendGetRequestAsync(string url)
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
    }
}