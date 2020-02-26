using Microsoft.Extensions.Caching.Memory;
using Nextech.Adapters.Interfaces;
using Nextech.Domain.Interfaces;
using Nextech.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nextech.Domain
{
    public class HackerNews : IHackerNews
    {
        private readonly IHackerNewsHttpClient _client;
        private readonly IMemoryCache _cache;
        public HackerNews(IHackerNewsHttpClient client, IMemoryCache cache)
        {
            _client = client;
            _cache = cache;
        }
        public async Task<List<Story>> GetNewestStories()
        {
            return await _cache.GetOrCreateAsync("newsHackerCache", async cacheEntry => {
                var resultIDs = await _client.Get();
                var result = new List<Story>();
                foreach (var id in resultIDs)
                {
                    result.Add(new Story().MapToDomain(await _client.GetByID(id)));
                }
                return result;
            });




        }

    }
}
