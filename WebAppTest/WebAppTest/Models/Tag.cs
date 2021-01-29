using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppTest.Controllers;

namespace WebAppTest.Models
{
    public class Tag
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string UrlSlug { get; set; }

        public string Description { get; set; }

        public ICollection<Note> Note { get; set; }
    }
}
