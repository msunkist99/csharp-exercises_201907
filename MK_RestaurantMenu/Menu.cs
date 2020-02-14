using System;
using System.Collections.Generic;
using System.Text;

namespace MK_RestaurantMenu
{
    class Menu
    {
        private DateTime creationDate;
        private DateTime updateDate;
        private List<MenuItem> menuItems;
        private bool newMenu;
        private int id;
        private static int nextMenuId = 0;

        public  Menu()
        {
            id = ++nextMenuId;
            menuItems = new List<MenuItem>();
        }

        public DateTime CreationDate
        {
            get
            {
                return creationDate;
            }
        }

        public DateTime UpdateDate { 
            get
            {
                return updateDate;
            }
        }

        public List<MenuItem> MenuItems
        {
            get
            {
                return menuItems;
            }
            // this creates the menuItems list when the class is instantiated
            set
            {
                menuItems = value;
                updateDate = DateTime.Now;
            }
        }

        public bool NewMenu { 
            get
            {
                return newMenu;
            }
            set 
            {
                newMenu = value;
                if (value == true)
                {
                    creationDate = DateTime.Now;
                    updateDate = DateTime.Now;
                }
            }
        }

        public int Id { get
            {
                return id;
            }
        }


        // ToDo
        public bool IsNew { get; set; }
    }
}
