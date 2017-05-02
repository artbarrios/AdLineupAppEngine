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
    class AdsWebData
    {
        // global static vars
        private static HttpClient client = new HttpClient();

        // GET: api/AdsData
        public static List<Ad> GetAds()
        {
            // return the data or perform an action using the remote webApiUrl
            string webApiPath = "api/AdsData";
            string results = "";
            try
            {
                results = client.GetAsync(AppCommon.BuildUrl(AppCommon.GetRemoteWebApiUrl(), webApiPath)).Result.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<Ad>>(results);
            }
            catch (Exception e)
            {
                string message = AppCommon.AppendInnerExceptionMessages("GetAds: " + e.Message, e);
                throw new Exception(message);
            }
        } // GetAds
    }
}

