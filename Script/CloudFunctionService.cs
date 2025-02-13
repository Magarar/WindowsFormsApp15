using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace TencentCloudFunctionExample
{
    public class CloudFunctionService
    {
        private readonly HttpClient _client;
        private readonly string _cloudFunctionUrl;
        
        private readonly string _envId = "order-learn-8gtowqh7fdb505b4";

        public CloudFunctionService(string functionName="GetOrderCount")
        {
            _client = new HttpClient();
            _cloudFunctionUrl = $"https://order-learn-8gtowqh7fdb505b4-1332464681.ap-shanghai.app.tcloudbase.com/GetOrderCount";
        }
        
        public async Task<string> GetOrderCountAsync()
        {
            HttpResponseMessage response = await _client.GetAsync(_cloudFunctionUrl);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        
        public async Task<string> GetOrderCountAsync(string content)
        {
            var httpContent = new StringContent(content, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PostAsync(_cloudFunctionUrl, httpContent);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        
        
    }
}
