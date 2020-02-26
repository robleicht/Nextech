using System;
using System.Collections.Generic;
using System.Text;

namespace HackerNewsAdapter.Models
{
    public class Story
    {
        public string By { get; set; }
        public string ID { get; set; }
        public int Score { get; set; }
        public string Text { get; set; }
        public string Time { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }

    }
}
