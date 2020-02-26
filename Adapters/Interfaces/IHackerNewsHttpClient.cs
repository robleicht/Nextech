using HackerNewsAdapter.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nextech.Adapters.Interfaces
{
    public interface IHackerNewsHttpClient
    {
        Task<List<int>> Get();
        Task<Story> GetByID(int storyID);
    }
}
