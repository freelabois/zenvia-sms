using Newtonsoft.Json;
using RestSharp;
using System;
using System.Text;
using ZennviaSMSLib.Entities;

namespace ZennviaSMSLib
{
    public class Zenvia
    {
        private string Authorization = "Basic ";
        private string Account;
        private string Password;
        private string BaseUrlApi = "https://api-rest.zenvia.com/services/";
        //teste
        public Zenvia()
        {

        }

        public Zenvia(string apiurl, string account, string password)
        {
            Account = account;
            Password = password;
            BaseUrlApi = apiurl;
            Authorization += Convert.ToBase64String(Encoding.ASCII.GetBytes(Account + ":" + Password));

        }


        private string Execute(string apiRoute, object requestObj)
        {
            var client = new RestClient(BaseUrlApi + apiRoute);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Authorization);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", requestObj, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return response.Content;
        }


        public SmsResponse SendSMS(SendSmsRequest sendSmsRequest)
        {
            var obj = JsonConvert.DeserializeObject<SmsResponse>(Execute("send-sms", sendSmsRequest));
            return obj;
        }

        public GetSmsStatusResp GetSMS(string id)
        {
            var obj = JsonConvert.DeserializeObject<GetSmsStatusResp>(Execute("get-sms-status/" + id, null));
            return obj;
        }



    }
}
