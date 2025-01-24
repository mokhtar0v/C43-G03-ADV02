namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //    int N = int.Parse(Console.ReadLine());
            //    List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            //    arr.Sort();
            //    int Q = int.Parse(Console.ReadLine());
            //    for (int i = 0; i < Q; i++)
            //    {
            //        int X = int.Parse(Console.ReadLine());
            //        int index = arr.BinarySearch(X);

            //        if (index < 0)
            //        {
            //            index = ~index;
            //        }
            //        else
            //        {
            //            index++;
            //            while (index < N && arr[index] == X)
            //            {
            //                index++;
            //            }
            //        }
            //        int count = N - index;
            //        Console.WriteLine(count);
            //    }
            //} 
            #endregion

            #region Question02
            int N = int.Parse(Console.ReadLine());
            List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool Flag = true;
            for (int i = 0; i < N / 2; i++)
            {
                if (arr[i] != arr[N - 1 - i])
                {
                    Flag = false;
                    break;
                }
            }
            if (Flag) Console.WriteLine("YES");
            else Console.WriteLine("NO"); 
            #endregion


        }
    }
}
