namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            int N = int.Parse(Console.ReadLine());
            List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            arr.Sort();
            int Q = int.Parse(Console.ReadLine());
            for (int i = 0; i < Q; i++)
            {
                int X = int.Parse(Console.ReadLine());
                int index = arr.BinarySearch(X);

                if (index < 0)
                {
                    index = ~index;
                }
                else
                {
                    index++;
                    while (index < N && arr[index] == X)
                    {
                        index++;
                    }
                }
                int count = N - index;
                Console.WriteLine(count);
            }
        } 
        #endregion
    }
}
