using System;
using System.Collections.Generic;
namespace LogicBinarySearch
{
	public static class Search
	{
		/// <summary>
		/// Binaries search.
		/// </summary>
		/// <returns>The search.</returns>
		/// <param name="array">Array.</param>
		/// <param name="element">Element.</param>
		/// <param name="comparer">Comparer.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public static int BinarySearch<T>(T[] array, T element, IComparer<T> comparer = null)
		{
			ValidInput(array);
			if (ReferenceEquals(comparer, null)) comparer = Comparer<T>.Default;

			if (comparer.Compare(element, array[0]) < 0 || comparer.Compare(element, array[array.Length - 1]) > 0) return -1;

			int start = 0;
			int finish = array.Length - 1;
			int middle;

			while (start < finish)
			{
				middle = (start + finish) / 2;

				if (comparer.Compare(element, array[middle]) == 0)
				{
					return middle;
				}
				else if (comparer.Compare(element, array[middle]) < 0)
				{
					finish = middle;
				}
				else
				{
					start = middle + 1;
				}
			}
			return (comparer.Compare(array[finish], element) == 0) ? finish : -1;
		}
		/// <summary>
		/// Valids the input.
		/// </summary>
		/// <param name="array">Array.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		private static void ValidInput<T>(T[] array)
		{
			if (ReferenceEquals(array, null)) throw new ArgumentNullException($"{nameof(array)} is null.");
			if (array.Length == 0) throw new ArgumentException($"{nameof(array)} is empty.");
		}
	}
}
