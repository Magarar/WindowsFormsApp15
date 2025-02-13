using System;
using System.Threading.Tasks;
using TencentCloud.Cls.V20201016;
using TencentCloud.Scf.V20180416.Models;


namespace WindowsFormsApp1.Script
{
    public class CloudBaseService
    {

    }
    
    static async Task<string> InvokeCloudFunction(string functionName)
    {
        // 实例化一个认证对象，入参需要传入腾讯云账户的SecretId，SecretKey
        var cred = new Credential("你的SecretId", "你的SecretKey");
            
        // 实例化一个客户端配置对象
        var clientConfig = new ClientProfile();
        clientConfig.HttpProfile.Endpoint = "cls.tencentcloudapi.com";

        // 实例化要请求产品的client对象
        var client = new ClsClient(cred, "", clientConfig);

        // 实例化一个请求对象
        var req = new InvokeFunctionRequest
        {
            FunctionName = functionName,
            // 如果需要传递参数，可以使用以下方式
            // Args = "{\"key\":\"value\"}"
        };

        // 返回的resp是一个InvokeFunctionResponse的实例，与请求对象对应
        var resp = await client.InvokeFunctionAsync(req);

        // 返回json格式的字符串回包
        return resp.ToJsonString();
    }
}