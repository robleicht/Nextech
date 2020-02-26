using Nextech.Domain.Interfaces;
using Nextech.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nextech.Domain
{
    public class HackerNews : IHackerNews
    {
        public HackerNews()
        {

        }
        public async Task<List<Story>> GetNewestStories()
        {
            return null;
        }

    }
}
