using AdLineup.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AdLineupAppEngine.Web_Data
{
    class CustomersWebData
    {
        // global static vars
        private static HttpClient client = new HttpClient();

        // GET: api/CustomersData
        public static List<Customer> GetCustomers()
        {
            // return the data or perform an action using the remote webApiUrl
            string webApiPath = "api/CustomersData";
            string results = "";
            try
            {
                results = client.GetAsync(AppCommon.BuildUrl(AppCommon.GetRemoteWebApiUrl(), webApiPath)).Result.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<Customer>>(results);
            }
            catch (Exception e)
            {
                string message = AppCommon.AppendInnerExceptionMessages("GetCustomers: " + e.Message, e);
                throw new Exception(message);
            }
        } // GetCustomers
    }
}

