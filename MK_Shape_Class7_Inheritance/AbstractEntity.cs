using System;
using System.Collections.Generic;
using System.Text;

namespace MK_Shape_Class7_Inheritance
{
    public abstract class AbstractEntity
    {
        private static int id = 0;

        public int GenerateId()
        {
            id++;
            return id ;
        }
     }
}
