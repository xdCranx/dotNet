using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class ApiClass
    {
        //https://openexchangerates.org/api/latest.json?app_id=f38c89eb50574ffaa1b50dfb683fa29b&base=PLN
        private string _appId = "f38c89eb50574ffaa1b50dfb683fa29b";
        public HttpClient HttpClient { get; set; }
        public ApiClass() {
            HttpClient = new HttpClient();
        }  

        public async Task<string> GetData()
        {
            string base_currency = "USD";
            string request = "https://openexchangerates.org/api/latest.json"+"?app_id="+_appId+"&base="+base_currency+"&";
            string response = await HttpClient.GetStringAsync(request);

            return response;
        }
        


    }
}
