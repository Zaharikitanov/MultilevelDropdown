using Microsoft.AspNetCore.Components;
using MultilevelDropdownMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelDropdownMenu.Shared
{
    public class MultilevelDropdownBase : ComponentBase
    {
        public List<string> MenuItems { get; set; } = new List<string>();       
    }
}
