namespace BinarySearchAlgorithm
{
	public class BinarySearch
	{
		private int low;
		private int high;
		private int mid;
		private int guess;
		private List<int> _sortedNumbers;
		private int _numberToSearch;
		private int numberOfOperations;

		public BinarySearch(List<int> sortedNumbers, int numberToSearch)
		{
			numberOfOperations = 0;
			low = 0;
			high = sortedNumbers.Count - 1;
			_sortedNumbers = sortedNumbers;
			_numberToSearch = numberToSearch;
		}

		public int? Operate()
		{
			while (low <= high)
			{
				mid = (low + high) / 2;
				guess = _sortedNumbers[mid];

				if (guess == _numberToSearch)
				{
					Console.WriteLine("Number of operations : " + numberOfOperations);
					return mid;
                }
				else if (guess > _numberToSearch)
					high = mid - 1;
				else
					low = mid + 1;

				numberOfOperations++;
			}

			return null;
		}
	}
}

