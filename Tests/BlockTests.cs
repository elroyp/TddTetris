using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TddTetris;
using Moq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Tests
{
    [TestFixture]
    public class BlockTests
    {

        [Test]
        public void RotateLeft_Once()
        {
            IBlock block = new LetterIBlock();
            block.RotateLeft();
            Assert.AreEqual(new List<Vector2>() { new Vector2(3, 2), new Vector2(4, 2), new Vector2(5, 2) },(block.Shape(new Vector2(3, 2))));
        }

        [Test]
        public void RotateLeft_FourTimesReturnsToBeginning()
        {
            List<Vector2> startPosition = new List<Vector2>() { new Vector2(3, 2), new Vector2(3, 1), new Vector2(3, 0) };
            IBlock block = new LetterIBlock();
            block.RotateLeft();
            block.RotateLeft();
            block.RotateLeft();
            block.RotateLeft();
            Assert.AreEqual(startPosition, (block.Shape(new Vector2(3, 2))));
        }

        [Test]
        public void RotateRight_Once()
        {
            IBlock block = new LetterIBlock();
            block.RotateRight();
            Assert.AreEqual(new List<Vector2>() { new Vector2(3, 2), new Vector2(4, 2), new Vector2(5, 2) }, (block.Shape(new Vector2(3, 2))));
        }

        [Test]
        public void RotateRight_FourTimesReturnsToBeginning()
        {
            List<Vector2> startPosition = new List<Vector2>() { new Vector2(3, 2), new Vector2(3, 1), new Vector2(3, 0) };
            IBlock block = new LetterIBlock();
            block.RotateRight();
            block.RotateRight();
            block.RotateRight();
            block.RotateRight();
            Assert.AreEqual(startPosition, (block.Shape(new Vector2(3, 2))));
        }
    }
}
