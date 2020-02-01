using System;
using System.Collections.Generic;
using System.Text;

namespace MK_Quiz_Class7_part2
{
    public abstract class AbstractEntity
    {
        private static int id = 0;

        public int GenerateId()
        {
            id++;
            return id;
        }
    }
}
