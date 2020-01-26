using System;
using System.Collections.Generic;
using System.Text;

namespace MK_Shape_Class7_Inheritance
{
    public class Shape : AbstractEntity
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public int Id {get;set; }

        public Shape(string name, string color, string type) 
        {
            Name = name;
            Color = color;
            Type = type;
            Id = GenerateId();
        }
    }
}
