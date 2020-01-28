using System;
using System.Collections.Generic;
using System.Text;

namespace MK_Quiz_Class7
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
