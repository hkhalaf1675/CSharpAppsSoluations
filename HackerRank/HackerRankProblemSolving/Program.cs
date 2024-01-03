using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<List<int>> ar = new List<List<int>>();
            //ar.Add(new List<int> { 11,2,4});
            //ar.Add(new List<int> { 4,5,6});
            //ar.Add(new List<int> { 10,8,-12});

            //var res = diagonalDifference(ar);
            //Console.WriteLine(res);

            //miniMaxSum(new List<int> { 1,2,3,4,5 });

            var result = GetTvSeries(2019, -1);
            Console.WriteLine(result.Count());
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public static int simpleArraySum(List<int> ar)
        {
            return ar.Sum();
        }
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int> { 0, 0 };
            for(int i=0; i<a.Count(); i++)
            {
                if (a[i] > b[i])
                    result[0] += 1;
                else if (a[i] < b[i])
                    result[1] += 1;
            }

            return result;
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int r1 = 0;
            int r2 = 0;
            for (int i = 0; i < arr.Count(); i++)
            {
                for(int j=0; j < arr[i].Count(); j++)
                {
                    if (i == j)
                        r1 += arr[i][j];
                    if(arr.Count() - i -1 == j)
                        r2 += arr[i][j];
                }
            }

            return Math.Abs(r1 - r2);
        }

        public static void miniMaxSum(List<int> arr)
        {
            int minNumber = arr.IndexOf(arr.Min());
            int maxNumber = arr.IndexOf(arr.Max());

            long minSum = 0;
            long maxSum = 0;

            for (int i = 0; i<arr.Count(); i++)
            {
                if (i != minNumber)
                    maxSum += arr[i];

                if (i != maxNumber)
                    minSum += arr[i];
            }
            Console.WriteLine($"{minSum} {maxSum}");

        }

        public static List<int> gradingStudents(List<int> grades)
        {
            for (int i= 0; i < grades.Count(); i++){
                if (grades[i] < 38)
                    continue;

                else
                {
                    if (grades[i] % 5 < 3)
                    {
                        grades[i] += grades[i] % 5;
                    }
                }
            }

            return grades;
        }

        public static List<string> GetTvSeries(int start, int end)
        {
            List<string> seriesNames = new List<string>();

            string baseUrl = "https://jsonmock.hackerrank.com/api/tvseries";

            HttpClient client = new HttpClient();

            var response = client.GetAsync(baseUrl).Result;

            string stringResponse = response.Content.ReadAsStringAsync().Result;

            //dynamic objectResponse = JObject.Parse(stringResponse);

            SeriesData objectResponse = JsonConvert.DeserializeObject<SeriesData>(stringResponse);

            for(int i=1; i<=objectResponse.total_pages; i++)
            {
                var pageResponse = client.GetAsync($"{baseUrl}?page={i}").Result;
                string pageResponseString = pageResponse.Content.ReadAsStringAsync().Result;
                SeriesData pageResponseData = JsonConvert.DeserializeObject<SeriesData>(pageResponseString);

                foreach(var item in pageResponseData.data)
                {
                    var seriesYears = item.runtime_of_series.Trim('(', ')').Split('-');

                    int startYear;
                    int endYear;

                    if(seriesYears.Length > 0)
                    {
                        if (int.TryParse(seriesYears[0], out startYear)) { }
                        else
                        {
                            startYear = 0;
                        }
                    }
                    else
                    {
                        startYear = 0;
                    }

                    if (seriesYears.Length > 1)
                    {
                        if (int.TryParse(seriesYears[1],out endYear)) { }
                        else
                        {
                            endYear = -1;
                        }
                    }
                    else
                    {
                        endYear = -1;
                    }

                    // check if the series in the range 
                    if(start>= startYear && end <= endYear)
                    {
                        seriesNames.Add(item.name);
                    }
                }
            }
            return seriesNames;
        }


    }

    public class SeriesData
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public List<Data> data { get; set; }
    }

    public class Data
    {
        public string name { get; set; }
        public string runtime_of_series { get; set; }
        public string certificate { get; set; }
        public string runtime_of_episodes { get; set; }
        public string genre { get; set; }
        public float imdb_rating { get; set; }
        public string overview { get; set; }
        public int no_of_votes { get; set; }
    }
}
