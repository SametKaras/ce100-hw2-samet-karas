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

namespace MatrixChainMultiplicationDPUnitTests
{
    [TestClass()]
    public class MatrixChainMultiplicationDPBestTests
    {
        [TestMethod()]
        public void MCMDDPTest()
        {
            int[] d = new int[] { 10, 20, 30, 40, 50 };
            int expected = 38000;

            int result;
            int status = MatrixChainMultiplicationDP.MCMDP(d, out result, true);

            Assert.AreEqual(expected, result);
            Assert.IsTrue(status >= 0);
        }
    }
    [TestClass()]
    public class MatrixChainMultiplicationDPAverageTests
    {
        [TestMethod()]
        public void MCMDDPTest()
        {
            int[] d = new int[] { 10, 20, 20, 40, 30 };
            int expected = 24000;

            int result;
            int status = MatrixChainMultiplicationDP.MCMDP(d, out result, true);

            Assert.AreEqual(expected, result);
            Assert.IsTrue(status >= 0);
        }
    }
    [TestClass()]
    public class MatrixChainMultiplicationDPWorstTests
    {
        [TestMethod()]
        public void MCMDDPTest()
        {
            int[] d = new int[] { 10, 40, 30, 50, 20 };
            int expected = 37000;

            int result;
            int status = MatrixChainMultiplicationDP.MCMDP(d, out result, true);

            Assert.AreEqual(expected, result);
            Assert.IsTrue(status >= 0);
        }
    }
}

namespace MemorizedRecursiveMultiplicationUnitTests
{
    [TestClass()]
    public class MemorizedRecursiveMultiplicationBestTests
    {
        [TestMethod()]
        public void MatrixChainOrderTest()
        {
            int[] p = { 10, 20, 30, 40, 50, 60, 70 };
            int expected = 110000;


            int n = p.Length - 1;
            int[,] m = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    m[i, j] = -1;
                }
            }

            int result = MemorizedRecursiveMultiplication.MCMMRM(p, true);

            Assert.AreEqual(expected, result);
        }

    }
    [TestClass()]
    public class MemorizedRecursiveMultiplicationAverageTests
    {
        [TestMethod()]
        public void MatrixChainOrderTest()
        {
            int[] p = { 30, 35, 15, 30, 10, 20, 25 };
            int expected = 32750;


            int n = p.Length - 1;
            int[,] m = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    m[i, j] = -1;
                }
            }

            int result = MemorizedRecursiveMultiplication.MCMMRM(p, true);

            Assert.AreEqual(expected, result);
        }

    }
    [TestClass()]
    public class MemorizedRecursiveMultiplicationWorstTests
    {
        [TestMethod()]
        public void MatrixChainOrderTest()
        {
            int[] p = { 30, 35, 15, 5, 10, 20, 25 };
            int expected = 15125;


            int n = p.Length - 1;
            int[,] m = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    m[i, j] = -1;
                }
            }

            int result = MemorizedRecursiveMultiplication.MCMMRM(p, true);

            Assert.AreEqual(expected, result);
        }

    }
}

namespace LongestCommonSubsequenceUnitTests
{
    [TestClass()]
    public class LongestCommonSubsequenceBestTests
    {
        [TestMethod()]
        public void LcsTest()
        {
            string X = new string('a', 100);
            string Y = new string('a', 100);
            Assert.AreEqual(100, LongestCommonSubsequence.LCS(X, Y, true));
        }
    }
    [TestClass()]
    public class LongestCommonSubsequenceAverageTests
    {
        [TestMethod()]
        public void LcsTest()
        {
            string X = ("dmcsoniklbgpvzwkxfjetyhqarupjaegwmbsxdmcsoniklbgpvzwkxfjetyhqarupjaegwmbsxdmcsoniklbgpvzwkxfjetyhqa");
            string Y = ("abcdefghıoprsjtuvyzadcfghtesjakncjqwnasasaldjqwdlqjdqwlkdjqwdksaadasdaqdqdwdqassdasdasdasdaasdhqwoı");

            Assert.AreEqual(25, LongestCommonSubsequence.LCS(X, Y, true));
        }
    }
    [TestClass()]
    public class LongestCommonSubsequenceWorstTests
    {
        [TestMethod()]
        public void LcsTest()
        {
            string X = new string('a', 100);
            string Y = new string('b', 100);
            Assert.AreEqual(0, LongestCommonSubsequence.LCS(X, Y, true));
        }
    }
}