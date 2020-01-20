using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todolist3.Models;

namespace todolist3.Services
{
    public interface ListServices
    {
        ListItems AddListItems(ListItems items);
        Dictionary<string, ListItems> GetListItems();
    }
}
