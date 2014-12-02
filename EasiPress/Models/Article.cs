using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasiPress.Models
{
    public class Article
    {
        public int id { get; set; }

        public String title { get; set; }

        public User writer { get; set; }

        public DateTime date { get; set; }

        public String content { get; set; }
    }
}