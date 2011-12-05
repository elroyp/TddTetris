using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TddTetris;
using Microsoft.Xna.Framework;
using Moq;

namespace Tests
{
    [TestFixture]
    public class FieldTests
    {
        [Test]
        public void FixBlock_BlockIsDrawnWhenFixed()
        {
            Field f = new Field(1,1);
            f.SetBlock(new Block(), new Vector2(0, 0));
            GameMechanics mech = new GameMechanics(f, new BlockFactory());
            mech.AdvanceIfPossible();
            
            Color? color = f.ColorAt(new Vector2(0, 0));
            Assert.IsNotNull(color);
        }
    }
}
