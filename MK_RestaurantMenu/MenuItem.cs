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
        private DateTime creationDate;

        // ToDo - make this an enum
        private Category categoryName;
        private int id = 0;
        private static int nextMenuId = 0;


        public MenuItem()
        {
            id = nextMenuId;
            nextMenuId++;

            creationDate = DateTime.Now;
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

        public Category CategoryName 
        { 
            get
            {
                return categoryName;
            }
            set
            {
                categoryName = value;
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

        public enum Category
        {
            MainCourse,
            Appetizer,
            Dessert
        }

        public DateTime CreationDate
        {
            get
            {
                return creationDate;
            }
        }

        public bool IsNew
        {
            get
            {
                if (creationDate > DateTime.Today.AddMonths(-3))
                {
                    return true;
                }

                return false;
            }
        }
    }
}
