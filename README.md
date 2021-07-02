# MultilevelDropdown with Blazor

Dropdown menu with sub menus.

### Functional Specifications

![Alt text](https://github.com/Zaharikitanov/MultilevelDropdown/blob/master/example-design.PNG)

- The menu have top-level (root) and child items. In the above screenshot "Item 1" is a
top-level (root) menu item, "Item 1.2" is a child item (submenu item) of "Item 1" and "Item
1.2.1" is a child item of the "Item 1.2" child item ("Item 1.2" is a child of "Item 1" and a parent of
"Item 1.2.1").
- There is no restriction on the maximum level of nesting of the menu items - the menu
should allows "infinite" nesting of parent and child items. A top-level (root) item have no
subitems.
- A submenu is displayed when the mouse pointer is over a menu item, e.g. in the above
screenshot moving the mouse over "Item 1" displays its submenu – “Item 1.1” and “Item 1.2”.
- When the mouse cursor is moved outside of a submenu, it is closed automatically.
- When a menu item is clicked, a "select" event is triggered. The event arguments of the "select" event should provide the menu item data that has been clicked, so that the user can use this information. (In progress) A user of the menu
component should be able to subscribed to this event and execute arbitrary business logic of
their choice. 
- (TODO) The menu should allow data binding to a list of objects that represent the menu top-level and
child items.

### Prerequisites
* [Visual Studio](https://visualstudio.microsoft.com/vs/) 2019 or later.

### Technologies Used
* [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet/current)
* [Blazorstrap](https://blazorstrap.io/)

### Disclaimer
This is my first encounter with Blazor, I have spent 4 working days on developing it.
