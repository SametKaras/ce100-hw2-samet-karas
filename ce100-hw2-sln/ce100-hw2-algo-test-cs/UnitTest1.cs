using ce100_hw2_algo_lib_cs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ce100_hw2_algo_test_cs
{

}

namespace HeapSortUnitTests
{
    [TestClass()]
    public class HeapSortFuncionBestTests
    {
        [TestMethod()]
        public void TestHeapSortFunction()
        {
            //Arrange
            int[] series = new int[1000];
            Random random = new Random();

            for (int i = 0; i < series.Length; i++)
            {
                series[i] = random.Next(0, 1000);
            }

            int[] sorted = (int[])series.Clone();
            Array.Sort(sorted);


            Array.Sort(series);
            //Act
            HeapSortFuncion.HeapSort(series, true);

            //Assert
            CollectionAssert.AreEqual(sorted, series);
        }
    }
    [TestClass()]
    public class HeapSortFuncionAverageTests
    {
        [TestMethod()]
        public void TestHeapSortFunction()
        {
            //Arrange
            int[] series = new int[1000];
            Random random = new Random();

            for (int i = 0; i < series.Length; i++)
            {
                series[i] = random.Next(0, 1000);
            }

            int[] sorted = (int[])series.Clone();
            Array.Sort(sorted);

            //Act
            HeapSortFuncion.HeapSort(series, true);

            //Assert
            CollectionAssert.AreEqual(sorted, series);
        }
    }
    [TestClass()]
    public class HeapSortFuncionWorstTests
    {
        [TestMethod()]
        public void TestHeapSortFunction()
        {
            //Arrange
            int[] series = new int[1000];
            Random random = new Random();

            for (int i = 0; i < series.Length; i++)
            {
                series[i] = random.Next(0, 1000);
            }

            int[] sorted = (int[])series.Clone();
            Array.Sort(sorted);

            Array.Reverse(series);

            //Act
            HeapSortFuncion.HeapSort(series, true);

            //Assert
            CollectionAssert.AreEqual(sorted, series);
        }
    }
}