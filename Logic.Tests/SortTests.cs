using NUnit.Framework;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.CompilerServices;

//Открытый ключ(алгоритм хэширования: sha1):
//00240000048000009400000006020000002400005253413100040000010001002df32a8ab20921
//7ea6c9aee24a844a34789333f698e74878000b68fabaeb0711fc5580ab05e54d68e40f3090609f
//605e740b7b5e2d0752f5154ca02165314e1716b52d7c3742298e098b89af4ee20fb06578567b13
//824efcfed1d3426df96c48d49c730b9abdaa2487078a1dc936ae1c989b4f7726004988d61848a8
//de5e5ebc
//Токен открытого ключа: f54b53292da09c2c

namespace Logic.Tests
{
    [TestFixture]
    public class SortTests
    {
        #region Tests for QuickSort
        [TestCase(new int[] { 2, 3, 1 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 2, 1, 4, 6, 5, 3, 1 }, new int[] { 1, 1, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { 9, -5, 3, 2, 0, -4, 6 }, new int[] { -5, -4, 0, 2, 3, 6, 9 })]
        public void QuickSort_CorrectInputArray_PositiveTest(int[] array, int[] sortedArray)
        {
            Sort.QuickSort(array);
            Assert.AreEqual(array, sortedArray);
        }

        [Test]
        public void QuickSort_EmptyInputArray_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Sort.QuickSort(new int[] { }));
        }

        [Test]
        public void QuickSort_NullInputArray_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Sort.QuickSort(null));
        }
        #endregion

        #region Tests for MergeSort
        [TestCase(new int[] { 2, 3, 1 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 2, 1, 4, 6, 5, 3, 1 }, new int[] { 1, 1, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { 9, -5, 3, 2, 0, -4, 6 }, new int[] { -5, -4, 0, 2, 3, 6, 9 })]
        public void MergeSort_CorrectInputArray_PositiveTest(int[] array, int[] sortedArray)
        {
            Sort.MergeSort(array);
            Assert.AreEqual(array, sortedArray);
        }

        [Test]
        public void MergeSort_EmptyInputArray_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Sort.MergeSort(new int[] { }));
        }


        [Test]
        public void MergeSort_NullInputArray_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Sort.MergeSort(null));
        }
        #endregion

        #region Tests for internal methods
        [Test]
        public void ArrayChecker_EmptyInputArray_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Sort.ArrayChecker(new int[] { }));
        }
        [Test]
        public void ArrayChecker_NullInputArray_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Sort.ArrayChecker(null));
        }
        #endregion

    }
}
