namespace SelectionSortAlgorithms
{
    public static class FindAlgorithms
    {
        public static int FindSmallest(int[] numbers)
        {
            int smallest = numbers[0];
            int smallestIndex = 0;

            for (int i = 0; i < numbers.Length; i++) {
                if(numbers[i] < smallest)
                {
                    smallest = numbers[i];
                    smallestIndex = i;
                }
            }

            return smallestIndex;
        }
    }
}
