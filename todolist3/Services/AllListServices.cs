using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todolist3.Models;

namespace todolist3.Services
{
    public class AllListServices : ListServices
    {
        private readonly Dictionary<string, ListItems> _listitems;

        public AllListServices()
        {
            _listitems = new Dictionary<string, ListItems>();
        }

        public ListItems AddListItems(ListItems items)
        {
            _listitems.Add(items.Title, items);

            return items;
        }

        public Dictionary<string, ListItems> GetListItems()
        {
            return _listitems;
        }
    }
}
