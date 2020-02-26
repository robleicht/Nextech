using Nextech.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nextech.Domain.Interfaces
{
    public interface IHackerNews
    {
        Task<List<Story>> GetNewestStories();
    }
}
