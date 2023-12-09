namespace SelectionSort
{
    public static class FindAlgorithms
    {
        public static int FindSmallest(int[] numbers)
        {
            int smallest = numbers[0];
            int smallestIndex = 0;
            
            foreach (var i in numbers) {
                if(i < smallest)
                {
                    smallest = numbers[i];
                    smallestIndex = i;
                }
            }

            return smallestIndex;
        }
    }
}
