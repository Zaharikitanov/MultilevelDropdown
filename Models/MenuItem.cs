using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelDropdownMenu.Models
{
    public class MenuItem
    {
        public string Label { get; set; }

        public List<MenuItem> Children { get; set; }
    }
}
