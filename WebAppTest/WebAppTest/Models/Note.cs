using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppTest.Models;

namespace WebAppTest.Controllers
{
    public class Note
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime Date_system { get; set; }
        public string UrlNote { get; set; }
        public int TagID { get; set; }
        public int CategoryID { get; set; }
        public Tag Tag { get; set; }
        public Category Category { get; set; }
    }
}
