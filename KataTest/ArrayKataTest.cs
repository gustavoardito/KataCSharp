using FluentAssertions;
using KataCSharp.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KataTest
{
    public class ArrayKataTest
    {
        private readonly ArrayKata srv;

        public ArrayKataTest() {
            srv = new ArrayKata();
        }

        [Fact]
        public void RotateByPivotNotNullTest() {
            var items = new int[] { 1 };
            var itemsSorted = srv.RotateByPivot(items, 0);
            Assert.NotNull(itemsSorted);
        }

        [Fact]
        public void RotateByPivotLengthTest()
        {
            var items = new int[] { 1 };
            var itemsSorted = srv.RotateByPivot(items, 0);
            Assert.Equal(items.Length, itemsSorted.Length);
        }

        [Fact]
        public void RotateByPivotIndexExceptionTest()
        {
            var items = new int[] { 1 };
            var itemsSorted = srv.RotateByPivot(items, 0);
            Action act = () => srv.RotateByPivot(items, -1);
            var ex = Assert.Throws<IndexOutOfRangeException>(act);
            Assert.NotNull(ex);
        }

        [Fact]
        public void RotateByPivotIndexEquivalentTest()
        {
            var items = new int[] {1,3,5,7 };
            var itemsResult = new int[] { 7, 5, 3, 1 };
            var itemsRotated = srv.RotateByPivot(items, 0);

            itemsResult.Should().BeEquivalentTo(itemsRotated);
        }

        [Fact]
        public void RotateByPivotSortedTest()
        {
            var items = new int[] { 1, 3, 5, 7 };
            var itemsResult = new int[] { 7, 5, 3, 1 };
            var itemsRotated = srv.RotateByPivot(items, 0);

            itemsResult.Should().ContainInOrder(itemsRotated);
        }
        //[Fact]
        //public void RotateByPivotIndexTest()
        //{
        //    var items = new int[] { 1, 3, 5, 7 };
        //    var itemsResult = new int[] { 7, 5, 3, 1 };
        //    var itemsRotated = srv.Rotate(items,3);

        //    itemsResult.Should().BeEquivalentTo(itemsRotated);
        //    //Assert.ar(ex);
        //}

        //[Fact]
        //public void RotateByPivotLenghtTest()
        //{
        //    var items = new int[] { };
        //    var itemsSorted = srv.RotateByPivot(items, 0);
        //    Assert.Equal(items.Length, itemsSorted.Length);
        //}
    }
}
