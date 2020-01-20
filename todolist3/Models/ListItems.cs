using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todolist3.Models
{
    public class ListItems
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Expiration { get; set; } 
    }
}
