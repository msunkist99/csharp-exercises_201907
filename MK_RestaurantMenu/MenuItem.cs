using System;
using System.Collections.Generic;
using System.Text;

namespace MK_RestaurantMenu
{
    class MenuItem
    {
        private double price;
        private string description;
        private string name;

        // ToDo - make this an enum
        private string category;
        private int id = 0;
        private static int nextMenuId = 0;

        public MenuItem()
        {
            id = ++nextMenuId;
        }
        public double Price
        {
            get
            { return price; }
            set
            {
                if ((value < 1) || (value > 25))
                {

                }
                else
                {
                    price = value;
                }
            }
        }

        public string Category 
        { 
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
        }
    }
}
