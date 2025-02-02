﻿using System.Collections;

namespace Assignment
{
    internal class Program
    {
        #region Question01 Updated
        public static void ReverseInPlace(ArrayList list)
        {
            int left = 0, right = list.Count - 1;
            while (left < right)
            {
                object temp = list[left];
                list[left] = list[right];
                list[right] = temp;
                left++;
                right--;
            }
        }
        #endregion
        #region Question02 Updated
        static List<int> GetEvenNumbers(List<int> numbers)
        {
            // Create a new list to store even numbers
            List<int> evenNumbers = new List<int>();

            // Iterate through the input list
            foreach (int num in numbers)
            {
                // Check if the number is even
                if (num % 2 == 0)
                {
                    // Add the even number to the new list
                    evenNumbers.Add(num);
                }
            }

            // Return the list of even numbers
            return evenNumbers;
        }
        #endregion
        #region Question03 Updated
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        #endregion
        static void ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }
        static bool IsBalanced(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in s)
            {
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == ']' || ch == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char top = stack.Pop();
                    if (!IsMatchingPair(top, ch))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
        static bool IsMatchingPair(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '[' && close == ']') ||
                   (open == '{' && close == '}');
        }
        static int[] RemoveDuplicates(int[] arr)
        {
            List<int> uniqueList = new List<int>();

            foreach (int num in arr)
            {
                if (!uniqueList.Contains(num))
                {
                    uniqueList.Add(num);
                }
            }

            return uniqueList.ToArray();
        }
        static int[] RemoveOdd(int[] arr)
        {
            List<int> OddList = new List<int>();

            foreach (int num in arr)
            {
                if (num % 2 != 0)
                {
                    OddList.Add(num);
                }
            }

            return OddList.ToArray();
        }
        public static bool HasSubarrayWithSum(List<int> List, int target)
        {
            int currentSum = 0;
            int start = 0;

            for (int end = 0; end < List.Count; end++)
            {
                currentSum += List[end];
                while (currentSum > target && start <= end)
                {
                    currentSum -= List[start];
                    start++;
                }
                if (currentSum == target)
                {
                    return true;
                }
            }
            return false;
        }
        public static Queue<int> ReverseKElements(Queue<int> queue, int k)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < k; i++)
            {
                stack.Push(queue.Dequeue());
            }
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
            int remaining = queue.Count - k;
            for (int i = 0; i < remaining; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
            return queue;
        }
        static void Main(string[] args)
        {
            #region Question01
            //ArrayList list = new ArrayList { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < list.length; ++i)
            //{
            //    Console.WriteLine(list[i]);
            //}
            //ReverseInPlace(list);
            //Console.WriteLine("Reversed ArrayList:");
            //for (int i = 0; i < list.length; ++i)
            //{
            //    Console.WriteLine(list[i]);
            //}
            #endregion

            #region Question02
            //int size = int.Parse(Console.ReadLine());
            //List<int> list = new List<int>(size);
            //for (int i = 0;list.Count > i; i++)
            //{
            //    list.Add(i);
            //}
            //List<int> evennum = GetEvenNumbers(list);
            //foreach (int num in evennum)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            #region Question03
            //int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            //Console.WriteLine("Before Sort:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //BubbleSort(arr);
            //Console.WriteLine("After Sort:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            #endregion

            #region Question04
            //string? input = Console.ReadLine();
            //if (IsBalanced(input))
            //{
            //    Console.WriteLine("Balanced");
            //}
            //else
            //{
            //    Console.WriteLine("Not Balanced");
            //} 
            #endregion

            #region Question05
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

        #region Question06
        //int N = int.Parse(Console.ReadLine());
        //int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        //int[] uniqueArr = RemoveOdd(arr);
        //Console.WriteLine("Array without Odd Numbers:");
        //foreach (int num in uniqueArr)
        //{
        //    Console.Write(num + " ");
        //}  
        #endregion

        #region Question07
        //Queue<object> queue = new Queue<object>();
        //queue.Enqueue(1);
        //queue.Enqueue("Apple");     
        //queue.Enqueue(5.28);        
        //Console.WriteLine("Queue contents:");
        //foreach (var item in queue)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region Question10
        //List<int> arr = new List<int> { 1, 2, 3, 7, 5 };
        //int target = 12;

        //bool result = HasSubarrayWithSum(arr, target);
        //Console.WriteLine($"Subarray with sum {target}: {result}");
        #endregion

        #region Question11
        //Queue<int> queue = new Queue<int>();
        //queue.Enqueue(1);
        //queue.Enqueue(2);
        //queue.Enqueue(3);
        //queue.Enqueue(4);
        //queue.Enqueue(5);

        //int k = 3;
        //Queue<int> resultQueue = ReverseKElements(queue, k);

        //Console.WriteLine($"Queue after reversing first {k} elements:");
        //foreach (int item in resultQueue)
        //{
        //    Console.WriteLine(item);
        //} 
        #endregion


    }
    }
}
