using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace TddTetris
{
    public interface IBlock
    {
        void RotateLeft();
        void RotateRight();

        Color? ColorAt(Vector2 position);

        //Returns a list of positions to form the shape of a block
        List<Vector2> Shape(Vector2 position);
    }
}
