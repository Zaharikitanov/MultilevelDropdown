using System.Collections.Generic;

namespace MultilevelDropdownMenu.Models
{
    public class MenuItem
    {
        public string Label { get; set; }

        public List<MenuItem> Children { get; set; }
    }
}
