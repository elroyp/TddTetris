using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace TddTetris
{
    public class GameMechanics
    {
        private readonly IField field;
        private readonly IBlockFactory blockFactory;
        private IBlock currentBlock;

        public GameMechanics(IField field, IBlockFactory blockFactory)
        {
            this.field = field;
            this.blockFactory = blockFactory;
            this.currentBlock = blockFactory.MakeBlock();
            field.SetBlock(currentBlock, new Vector2(0, 0));
        }

        public void HandleInput(List<Keys> input)
        {
            if (input.IndexOf(Keys.Left) > -1)
            {
                MoveLeftIfPossible();
            }

            if (input.IndexOf(Keys.Right) > -1)
            {
                MoveRightIfPossible();
            }

            if (input.IndexOf(Keys.Space) > -1)
            {
                field.FixBlock();
            }
            if (input.IndexOf(Keys.A) > -1)
            {
                currentBlock.RotateLeft();
            }

            if (input.IndexOf(Keys.D) > -1)
            {
                currentBlock.RotateRight();
            }
        }

        public void AdvanceIfPossible()
        {
            if (field.CanAdvance())
            {
                field.AdvanceBlock();
            }
            else
            {
                field.FixBlock();
                currentBlock = blockFactory.MakeBlock();
                field.SetBlock( currentBlock, new Vector2(field.Width / 2, 0) );
            }
        }

        public void MoveLeftIfPossible()
        {
            if (field.CanMoveLeft())
            {
                field.MoveBlockLeft();
            }
        }

        public void MoveRightIfPossible()
        {
            if (field.CanMoveRight())
            {
                field.MoveBlockRight();
            }
        }
    }
}
