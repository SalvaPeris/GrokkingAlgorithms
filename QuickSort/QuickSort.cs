namespace QuickSortAlgorithm
{
    public static class Sort
    {
        public static int[] QuickSort(int[] numbers)
        {
            if(numbers.Length < 2)
                return numbers;
            else
            {
                var pivot = numbers[0];
                var less = numbers.Where(x => x < pivot).ToArray();
                var greater = numbers.Where(x => x > pivot).ToArray();

                var result = QuickSort(less).ToList();
                result.Add(pivot);
                result.AddRange(QuickSort(greater));

                return result.ToArray();
            }
        }
    }
}
