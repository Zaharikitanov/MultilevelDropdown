using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MultilevelDropdownMenu.Models
{
    public class MenuItemList : ComponentBase
    {
        public List<MenuItem> MenuItems { get; set; }

        public List<string> ItemLabels = new List<string>();

        protected override Task OnInitializedAsync()
        {
            PopulateMenuItems();
            return base.OnInitializedAsync();
        }

        private void PopulateMenuItems()
        {
            List<MenuItem> firstItem = new List<MenuItem>
            {
                new MenuItem
                {
                    Label = "item 1",
                    Children = new List<MenuItem>
                    {
                        new MenuItem { Label = "1.1"},
                        new MenuItem {
                            Label = "1.2",
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

            MenuItems =  firstItem;
            foreach (var item in firstItem)
            {
                //ItemLabels.Add(item.Label);
                IterateMenuItems(item);
            }
        }

        private void IterateMenuItems(MenuItem node)
        {
            if (node == null)
                return;

            ItemLabels.Add(node.Label);

            if (node.Children == null)
                return;

            foreach (var child in node.Children)
                IterateMenuItems(child);
        }
    }
}
