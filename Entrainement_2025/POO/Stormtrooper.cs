using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POO;

namespace POO
{
    public class POO
    {

        public class Stormp
        {
            public enum Stormtroopers // all block types we can have
            {
                None,
                White,
                Yellow,
                Green,
                Blue,
                Red,
            }
            public Stormtroopers color;
            public int count;
            // the type of block
            // the number of blocks in the stack
            public Stormp(Stormtroopers color, int count)
            {
            this.color = color;
            this.count = count;
            }
        }
    }
}