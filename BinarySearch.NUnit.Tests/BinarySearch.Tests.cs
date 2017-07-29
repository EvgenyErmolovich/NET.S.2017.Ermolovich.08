using NUnit.Framework;
using System;
namespace LogicBinarySearch.NUnit.Tests
{
	[TestFixture]
	public class SearchTests
	{
		[TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 4, ExpectedResult = 3)]
		[TestCase(new int[] { 19, 20, 21 }, 22, ExpectedResult = -1)]
		public int BinarySearchTest_PositiveTests(int[] array, int element)
		{
			return Search.BinarySearch<int>(array, element);
		}

		[Test]
		public void BinarySearchTest_ThrowsArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Search.BinarySearch<int>(null, 5));
		}

		[Test]
		public void BinarySearchTest_ThrowsArgumentException()
		{
			Assert.Throws<ArgumentException>(() => Search.BinarySearch<int>(new int[] { }, 5));
		}
	}
}
