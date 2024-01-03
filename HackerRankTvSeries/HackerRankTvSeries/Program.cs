using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HackerRankTvSeries
{
    internal class Program
    {
        static async Task<void> Main(string[] args)
        {
            var seriesnames = await GetTvSeries(2011,2013);
            Console.WriteLine(seriesnames);
        }

        public static async Task<List<string>> GetTvSeries(int startYear, int endYear)
        {
            List<string> seriesNames = new List<string>();
            string baseUrl = "https://jsonmock.hackerrank.com/api/tvseries";
            HttpClient client = new HttpClient();

            var response = await client.GetAsync(baseUrl);
            var stringResponse = await response.Content.ReadAsStringAsync();

            var objectResponse = JsonConvert.DeserializeObject(stringResponse) as ApiResponse;
            var data = objectResponse.data;


            return seriesNames;
        }
    }
}
