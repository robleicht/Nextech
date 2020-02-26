using System;
using System.Collections.Generic;
using System.Text;

namespace Nextech.Domain.Models
{
    public class Story
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Url { get; set; }

        public Story MapToDomain(HackerNewsAdapter.Models.Story story)
        {
            return new Story()
            {
                Title = story.Title,
                Author = story.By,
                Url = story.Url
            };

        }
    }


}
