using System;
using Newtonsoft.Json;

namespace WindowsFormsApp1.Script
{
    /// <summary>
    /// 封装类
    /// </summary>
    public class Order
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("table")]
        public int Table { get; set; }

        [JsonProperty("Date")]
        // [JsonConverter(typeof(DateTime))]
        public string Date { get; set; }

        [JsonProperty("_openid")]
        public string _OpenId { get; set; }

        [JsonProperty("openID")]
        public string OpenID { get; set; }

        [JsonProperty("phone")]
        public int Phone { get; set; }

        public bool isOver = false;




    }
}