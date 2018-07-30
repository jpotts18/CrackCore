using System;
using Xunit;
using CrackCore;

namespace CrackCore.Tests
{
    public class StackTest
    {

        [Fact]
        public void Count_CreateAnEmpty_CountIsZero()
        {
            var stack = new Stack<int>();
            Assert.Equal(0, stack.Count);
        }
        
        [Fact]
        public void Count_PushOne_CountIsOne()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            Assert.Equal(1, stack.Count);
        }

        [Fact]
        public void Count_PushTwo_CountIsTwo()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(42);
            
            int count = stack.Count;

            Assert.Equal(2, count);
        }

        [Fact]
        public void Count_PushMany_CountIsMany()
        {
            var stack = new Stack<int>();

            for (int i = 0; i > -98; i--)
            {
                stack.Push(i);
            }
            
            Assert.Equal(98, stack.Count);
        }

        [Fact]
        public void Pop_Empy_ThrowsException()
        {
            var stack = new Stack<int>();
            Assert.Throws<ArgumentException>(() => stack.Pop());
        }

        [Fact]
        public void Pop_OneItem_ReturnsItem()
        {
            var stack = new Stack<int>();

            stack.Push(1992);
            var item = stack.Pop();
            
            Assert.Equal(1992, item);
        }

        [Fact]
        public void Pop_OneItem_CountIsZero()
        {
            var stack = new Stack<int>();

            stack.Push(1992);
            var item = stack.Pop();
            
            Assert.Equal(0, stack.Count);
        }


        [Fact]
        public void Peek_Empty_ThrowException()
        {
            var stack = new Stack<int>();
            
            Assert.Throws<ArgumentException>(() => stack.Peek());
        }

        [Fact]
        public void Peek_ThreeItemsInStack_ReturnsLastItemAdded()
        {
            var stack = new Stack<int>();
            
            stack.Push(1);
            stack.Push(10);
            stack.Push(1000000);

            Assert.Equal(1000000, stack.Peek());
        }

        [Fact]
        public void Peek_ThreeItemsInStack_Count()
        {
            var stack = new Stack<int>();
            
            stack.Push(1);
            stack.Push(10);
            stack.Push(1000000);

            Assert.Equal(3, stack.Count);
        }
    }
}
