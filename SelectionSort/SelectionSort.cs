namespace SelectionSortAlgorithms
{
    public class SelectionSort
    {
        public int[] _array;
        public SelectionSort(int[] array)
        {
            _array = array;
        }

        public int[] Sort() 
        {
            int arrayLength = _array.Length;
            int[] sortedArray = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++) 
            {
                var smallest = FindAlgorithms.FindSmallest(_array);
                sortedArray[i] = _array[smallest];
                _array = _array.Where((val, idx) => idx != smallest).ToArray();
            }

            return sortedArray;
        }
    }
}
