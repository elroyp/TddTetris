using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace TddTetris
{
    public class LetterIBlock : Block
    {
        List<Vector2> shape = new List<Vector2>();
        public LetterIBlock()
        {
            shape.Add(new Vector2(0,0));
            shape.Add(new Vector2(0,1));
            shape.Add(new Vector2(0,2));
        }
        public override void RotateLeft()
        {
            base.RotateLeft();
            switch (currentStand)
            {
                case 1:
                    shape[1] = new Vector2(0, 0 - 1);
                    shape[2] = new Vector2(0, 0 - 2);
                    break;
                case 2:
                    shape[1] = new Vector2(0-1, 0);
                    shape[2] = new Vector2(0-2, 0);
                    break;
                case 3:
                    shape[1] = new Vector2(0, 0 + 1);
                    shape[2] = new Vector2(0, 0 + 2);
                    break;
                case 4:
                    shape[1] = new Vector2(0 + 1, 0);
                    shape[2] = new Vector2(0 + 2, 0);
                    break;
            }
        }

        public override void RotateRight()
        {
            base.RotateRight();
            switch (currentStand)
            {
                case 1:
                    shape[1] = new Vector2(0, 0 - 1);
                    shape[2] = new Vector2(0, 0 - 2);
                    break;
                case 2:
                    shape[1] = new Vector2(0 + 1, 0);
                    shape[2] = new Vector2(0 + 2, 0);
                    break;
                case 3:
                    shape[1] = new Vector2(0, 0 + 1);
                    shape[2] = new Vector2(0, 0 + 2);
                    break;
                case 4:
                    shape[1] = new Vector2(0 - 1, 0);
                    shape[2] = new Vector2(0 - 2, 0);
                    break;
            }
        }

        public override List<Vector2> Shape(Vector2 position)
        {
            List<Vector2> tmpshape = new List<Vector2>();
            for (int i = 0; i < shape.Count; i++)
            {
                tmpshape.Add(new Vector2(position.X + shape[i].X, position.Y + shape[i].Y));
            }
            return tmpshape;
        }

        public override Color? ColorAt(Vector2 position)
        {
            return Color.Blue;
        }
    }
}
