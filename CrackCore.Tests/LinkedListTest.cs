using System;
using Xunit;
using CrackCore;

namespace CrackCore.Tests
{
    public class LinkedListTest
    {

        [Fact]
        public void Count_CreateAnEmpty_CountIsZero()
        {
            var list = new LinkedList();
            Assert.Equal(0, list.Count);
        }

        [Fact]
        public void Count_ToAnEmptyList_Length1()
        {
            var list = new LinkedList();
            list.Append(1);
            Assert.Equal(1, list.Count);
        }

        [Fact]
        public void Count_To100_Length100()
        {
            var list = new LinkedList();
            for (int i = 0; i < 100; i++)
            {
                list.Append(1);
            }
            Assert.Equal(100, list.Count);
        }

        [Fact]
        public void First_EmptyList_ReturnsNull()
        {
            var list = new LinkedList();

            var item = list.First;

            Assert.Null(item);
        }

        [Fact]
        public void First_OneItem_ReturnsItem()
        {
            var list = new LinkedList();

            list.Append(1);

            Assert.Equal(1, list.First);
        }

        [Fact]
        public void First_TwoItem_ReturnsItem()
        {
            var list = new LinkedList();

            list.Append(1);
            list.Append(3);

            Assert.Equal(1, list.First);
        }

        [Fact]
        public void Last_EmptyList_ReturnsNull()
        {
            var list = new LinkedList();

            var item = list.Last;

            Assert.Null(item);
        }

        [Fact]
        public void Last_OneItem_ReturnsItem()
        {
            var list = new LinkedList();
            list.Append(1);

            var item = list.Last;

            Assert.Equal(1, item);
        }

        [Fact]
        public void Last_TwoItem_ReturnsLastItemAppended()
        {
            var list = new LinkedList();
            list.Append(1);
            list.Append(2000);

            var item = list.Last;

            Assert.Equal(2000, item);
        }

        [Fact]
        public void Prepend_EmptyList_CountIsOne()
        {
            var list = new LinkedList();
            list.Prepend(2);
            Assert.Equal(1, list.Count);
        }

        [Fact]
        public void Prepend_EmptyList_FirstIsNewItem()
        {
            var list = new LinkedList();
            list.Prepend(2);
            Assert.Equal(2, list.First);
        }

        [Fact]
        public void Prepend_EmptyList_LastIsNewItem()
        {
            var list = new LinkedList();
            list.Prepend(2);
            Assert.Equal(2, list.Last);
        }

        [Fact]
        public void Prepend_OneItem_FirstReturnsItemJustAdded()
        {
            var list = new LinkedList();
            list.Append(1);
            list.Append(2);
            list.Prepend(47);

            Assert.Equal(47, list.First);
        }

        [Fact]
        public void Prepend_OneItem_LastReturnsTheFirstItemAdded()
        {
            var list = new LinkedList();
            list.Append(1);
            list.Prepend(47);

            Assert.Equal(1, list.Last);
        }

        [Fact]
        public void Prepend_OneItem_CountIsTwo()
        {
            var list = new LinkedList();
            list.Append(1);
            list.Prepend(47);

            Assert.Equal(2, list.Count);
        }
    }
}
