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
    class BillboardsWebData
    {
        // global static vars
        private static HttpClient client = new HttpClient();

        // GET: api/BillboardsData
        public static List<Billboard> GetBillboards()
        {
            // return the data or perform an action using the remote webApiUrl
            string webApiPath = "api/BillboardsData";
            string results = "";
            try
            {
                results = client.GetAsync(AppCommon.BuildUrl(AppCommon.GetRemoteWebApiUrl(), webApiPath)).Result.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<Billboard>>(results);
            }
            catch (Exception e)
            {
                string message = AppCommon.AppendInnerExceptionMessages("GetBillboards: " + e.Message, e);
                throw new Exception(message);
            }
        } // GetBillboards
    }
}

