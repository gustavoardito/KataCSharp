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
        public void RotateByPivotTest() {
            var items = new int[] { };
            var itemsSorted = srv.RotateByPivot(items, 0);
            Assert.NotNull(itemsSorted);
        }

        [Fact]
        public void RotateByPivotLenghtTest()
        {
            var items = new int[] { };
            var itemsSorted = srv.RotateByPivot(items, 0);
            Assert.Equal(items.Length, itemsSorted.Length);
        }
    }
}
