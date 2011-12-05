using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace TddTetris
{
    public class Block : IBlock
    {
        public int currentStand = 1;
        public virtual void RotateLeft()
        {
            currentStand--;
            if (currentStand == 0) currentStand = 4;
        }

        public virtual void RotateRight()
        {
            currentStand++;
            if (currentStand > 4) currentStand = 1;
        }

        public virtual Color? ColorAt(Vector2 position)
        {   
            return Color.White;
        }

        public virtual List<Vector2> Shape(Vector2 position)
        {
            List<Vector2> shape = new List<Vector2>();
            shape.Add(new Vector2(position.X, position.Y));
            return shape;
        }
    }
}
