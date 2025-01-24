using System.Collections;

namespace Session02_Advanced
{
    internal class Program
    {
        //public static int SumOfArrayList(ArrayList nums)
        ///{
        ///    int sum = 0;
        ///    if(nums is not null)
        ///    {
        ///        for (int i = 0; i < nums.Count; i++)
        ///        {
        ///            sum += (int?) nums[i] ?? 0;
        ///        }
        ///    }
        ///    return sum;
        ///}
        
        ///public static int SumOfList(List<int> list)
        ///{
        ///    int sum = 0;
        ///    if (list ?.Count > 0)
        ///    {
        ///        for (int i = 0; i <= list.Count; i++) 
        ///        {
        ///            sum += list[i];
        ///        }
        ///    }
        ///    return sum;
        ///}
        static void Main(string[] args)
        {
            #region ArrayList
            ///ArrayList nums = new ArrayList(5) { 1, 2, 3, 4, 5 };
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");
            ///if (nums.Capacity < 21)
            ///    nums.Capacity = 21;
            ///for (int i = 6; i<=21;  i++)
            ///{
            ///    nums.Add(i);
            ///}
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");
            ///Adding and Trimming
            ///nums.Add(1);
            ///nums.Add(2);
            ///nums.AddRange(new int[] { 3, 4 });
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");
            ///nums.Add(5);
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");
            ///nums.TrimToSize();
            ///Console.WriteLine("After Trimming");
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");
            ///
            ///ArrayList nums = new ArrayList(5);
            ///nums.Add(1);
            ///nums.Add(2);
            ///nums.Add(3);
            ///nums.Add(4);
            ///nums.Add("Hamada");
            ///int res = SumOfArrayList()
            #endregion
            #region List
            //List<int> nums = new List<int>(5);
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");
            ///
            ///nums.Add(1);
            ///nums.Add(2);
            ///nums.AddRange([3, 4]);
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");
            ///nums.Add(5);
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");
            ///
            ///nums.TrimExcess();
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");
            ///foreach(int i in nums)
            ///{
            ///    Console.WriteLine(i);
            ///}
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");
            ///nums.EnsureCapacity(21);
            ///for (int i = 6; i < 21; i++)
            ///{
            ///    nums.Add(i);
            ///}
            ///
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");

            ///nums.Add(1);
            ///nums.Add(2);
            ///nums.Add(3);
            ///nums.Add(4);
            ///
            ///int res = SumOfList(nums);
            ///Console.WriteLine(res);
            #endregion
            #region Linked List
            ///LinkedList<int> nums = new LinkedList<int>(); 
            ///LinkedListNode<int> firstnode = nums.AddFirst(1);
            ///LinkedListNode<int> fourthnode = nums.AddLast(4);
            ///LinkedListNode<int> secondnode = nums.AddAfter(firstnode, 2);
            ///LinkedListNode<int> thirdnode = nums.AddBefore(fourthnode, 3);
            ///Console.WriteLine(thirdnode.Previous.Value);
            #endregion
            #region Stack
            ///Stack<int> nums = new Stack<int>();
            ///nums.Push(1);
            ///nums.Push(2);
            ///nums.Push(3);
            ///nums.Pop();
            ///Console.WriteLine(nums.TryPop(out int Value01));
            ///Console.WriteLine(nums.TryPop(out int Value02));
            ///
            ///Console.WriteLine(nums.TryPop(out int Value));
            ///Console.WriteLine(Value);
            #endregion
            #region Queue
            ///Queue<int> queue = new Queue<int>();
            ///nums.Enqueue(1);
            ///nums.Enqueue(2);
            ///nums.Enqueue(3);
            ///nums.Dequeue();
            ///Console.WriteLine(nums.TryDequeue(out int Value01));
            ///Console.WriteLine(nums.TryDequeue(out int Value02));
            ///Console.WriteLine(nums.TryDequeue(out int Value03));
            ///Console.WriteLine(nums.TryDequeue(out int Value04));
            ///
            ///Console.WriteLine(Value01);
            ///Console.WriteLine(Value02);
            ///Console.WriteLine(Value03);
            ///Console.WriteLine(Value04);
            #endregion
        }
    }
}
