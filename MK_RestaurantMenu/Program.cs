using System;
using System.Collections.Generic;

namespace MK_RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            MenuItem menuItem = new MenuItem();
            menuItem.CategoryName = MenuItem.Category.MainCourse;
            menuItem.Description = "with cheese and fries";
            menuItem.Name = "Burger";
            menuItem.Price = 8.99;
            menu.MenuItems.Add(menuItem);

            menuItem = new MenuItem();
            menuItem.CategoryName = MenuItem.Category.Appetizer;
            menuItem.Description = "with cheese, beans, and jalepeno peppers";
            menuItem.Name = "Nachos";
            menuItem.Price = 5.99;
            menu.MenuItems.Add(menuItem);

            menuItem = new MenuItem();
            menuItem.CategoryName = MenuItem.Category.Dessert;
            menuItem.Description = "ultimate chocolate";
            menuItem.Name = "Cake";
            menuItem.Price = 4.99;
            menu.MenuItems.Add(menuItem);
            
            menu.NewMenu = true;

            Console.ReadLine();

        }
    }
}
