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
                if (value = true)
                {
                    creationDate = DateTime.Now;
                    updateDate = DateTime.Now;
                }
            }
        }

        public int Id { get; set; }
    }
}
