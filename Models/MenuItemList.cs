using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MultilevelDropdownMenu.Models
{
    public class MenuItemList : ComponentBase
    {
        public List<MenuItem> MenuItems { get; set; }

        protected override Task OnInitializedAsync()
        {
            PopulateMenuItems();
            return base.OnInitializedAsync();
        }

        private void PopulateMenuItems()
        {
            MenuItems = new List<MenuItem>
            {
                new MenuItem
                {
                    Label = "item 1",
                    Children = new List<MenuItem>
                    {
                        new MenuItem { Label = "1.1"},
                        new MenuItem {
                            Label = "1.2 subitem",
                            Children = new List<MenuItem>{
                                new MenuItem { Label = "1.2.1"},
                                new MenuItem { Label = "1.2.2"},
                                new MenuItem { Label = "1.2.3"},
                            }
                        }
                    }
                },
                new MenuItem
                {
                    Label = "item 2",
                    Children = new List<MenuItem>
                    {
                        new MenuItem { Label = "2.1"},
                        new MenuItem { Label = "2.2"}
                    }
                },
                new MenuItem
                {
                    Label = "item 3"
                }
            };
        }
    }
}
