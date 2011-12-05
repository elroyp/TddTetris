using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TddTetris
{
    public class BlockFactory : IBlockFactory
    {
        Random r = new Random();
        public IBlock MakeBlock()
        {
            int num = r.Next(2, 2);

            switch (num)
            {
                case 2:
                    return new LetterIBlock();
                default:
                    return new Block();
            }
        }
    }
}
