using Microsoft.AspNetCore.Mvc;
using Nextech.Domain.Interfaces;
using System.Threading.Tasks;

namespace AngularNexTechAssesment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HackerNewsController :ControllerBase
    {
        private readonly IHackerNews _hackerNews;
        public HackerNewsController(IHackerNews hackerNews)
        {
            _hackerNews = hackerNews;
        }
        public async Task<IActionResult> Get()
        {
            return Ok(await _hackerNews.GetNewestStories());
        }

    }
}
