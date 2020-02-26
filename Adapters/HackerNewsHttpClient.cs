using HackerNewsAdapter.Models;
using Nextech.Adapters.Interfaces;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
namespace Adapters
{
    public class HackerNewsHttpClient : IHackerNewsHttpClient
    {
        static HttpClient client = new HttpClient();
        static string basePath = "https://hacker-news.firebaseio.com/v0/";
        public async Task<List<int>> Get()
        {
            try
            {
                using (HttpResponseMessage response = await client.GetAsync(basePath + "askstories.json?print=pretty"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsAsync<List<int>>();
                        return result;
                    }
                    else
                    {
                        throw new HttpRequestException("Hacker News is not responding at this time");
                    }
                }

            }
            catch
            {
                throw new HttpRequestException("Hacker News is not responding at this time");
            }
        }

        public async Task<Story> GetByID(int storyID)
        {
            try
            {
                using (HttpResponseMessage response = await client.GetAsync(basePath + $"item/{storyID}.json?print=pretty"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsAsync<Story>(); ;
                    }
                    else
                    {
                        throw new HttpRequestException("Hacker News is not responding at this time");
                    }
                }
            }
            catch
            {
                throw new HttpRequestException("Hacker News is not responding at this time");
            }
        
        }
    }
}
