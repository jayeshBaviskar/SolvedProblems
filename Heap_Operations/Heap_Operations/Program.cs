using System;
using System.Collections.Generic;
using System.Linq;

namespace Heap_Operations
{
    internal class Program
    {

        public int MaxEvents3(int[][] events)
        {

            events = events.OrderBy(x => x[1]).ThenBy(x => x[0]).ToArray();
            var EventTimeLine = new int[events.Last()[1] + 1];
            var prevEvent = -1;
            var prevArrival = -1;
            foreach (var evt in events)
            {
                var startEventTime = evt[0];
                if (prevEvent == evt[0]) startEventTime = prevArrival + 1;
                prevEvent = evt[0];
                for (var i = startEventTime; i <= evt[1] && i < EventTimeLine.Length; i++)
                {
                    if (EventTimeLine[i] == 0)
                    {
                        EventTimeLine[i] = 1;
                        prevArrival = i;
                        break;
                    }
                }
            }
            //Console.WriteLine(string.Join(",", calendar));
            return EventTimeLine.Count(x => x != 0);
        }


        public int MaxEvents2(int[][] events)
        {
            if (events == null && events.Length == 0)
            {
                return 0;
            }

            List<(int Start, int End)> intervals = new List<(int, int)>();
            for (int i = 0; i < events.Length; i++)
            {
                int start = events[i][0];
                int end = events[i][1];
                intervals.Add((start, end));
            }

            intervals = intervals.OrderBy(x => x.End).ThenBy(x => x.Start).ToList();
            HashSet<int> visited = new HashSet<int>();
            "".Substring(1,)
                
            foreach ((int Start, int End) in intervals)
            {
                if (Start == End)
                {
                    visited.Add(Start);
                }
                else
                {
                    for (int j = Start; j <= End; j++)
                    {
                        if (visited.Add(j))
                        {
                            break;
                        }
                    }
                }
            }

            return visited.Count;
        }

        public static int maxEvents(List<int> arrival, List<int> duration)
        {
            int[][] events = new int[arrival.Count][];
            int result = 0;

            for (int i = 0; i < arrival.Count; i++)
            {
                events[i] = new int[2];
                events[i][0] = arrival[i];
                events[i][1] = arrival[i] + duration[i];
            }

            var sorted = events.OrderBy(x => x[1]).ThenBy(x => x[0]).ToArray();
            var eventTrack = new HashSet<int>();
            foreach (var currentEvent in sorted)
            {
                for (int i = currentEvent[0]; i <= currentEvent[1]; i++)
                {
                    if (!eventTrack.Contains(i))
                    {
                        eventTrack.Add(i);
                        ++result;
                        break;
                    }
                }
            }

            return result;
        }

        public int MaxEvents(int[][] events)
        {
            events[0][0] = 1;
            events[0][1] = 11;

            events[1][0] = 1;
            events[1][1] = 1;

            events[2][0] = 1;
            events[2][1] = 1;

            events[3][0] = 1;
            events[3][1] = 1;

            events[4][0] = 1;
            events[4][1] = 1;

            var sorted = events.OrderBy(x => x[1]).ThenBy(x => x[0]).ToArray(); // order event by the earliest they end, as well as the earliest starting point
            int result = 0;
            var eventTrack = new HashSet<int>(); //keep track of which days we've attended events
            foreach (var currentEvent in sorted)
            {
                for (int i = currentEvent[0]; i <= currentEvent[1]; i++)
                { // check every day in range of event
                    if (!eventTrack.Contains(i))
                    {
                        eventTrack.Add(i);
                        result++;
                        break;
                    }
                }
            }
            return result;
        }

        private static void Main(string[] args)
        {
            List<int> arr = new List<int>();

            arr.Add(9);
            arr.Add(12);
            arr.Add(13);
            Console.WriteLine("Hello World!");
            Program p = new Program();

            p.Display(arr);

            Console.WriteLine("Command: insert 10");
            p.Insert(10, arr);
            p.Display(arr);

            Console.WriteLine("Command: insert 50");
            p.Insert(50, arr);
            p.Display(arr);

            Console.WriteLine("Command: Remove");
            p.Remove(arr);
            p.Display(arr);

            Console.WriteLine("Command: Build New Heap");
            p.BuildHeap();
        }

        public void Display(List<int> arr)
        {
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }

            Console.WriteLine();
        }

        public void BuildHeap()
        {
            List<int> newArray = new List<int> { 10, 9, 5, 1, 3, 6, 8 };
            for (int i = newArray.Count - 1; i >= 0; i--)
            {
                SiftDown(i, newArray);
            }

            Display(newArray);
        }

        public void SiftDown(int index, List<int> arr)
        {
            while (index < arr.Count - 1)
            {
                if (arr.Count <= ((index * 2) + 1))
                {
                    break;
                }

                if ((arr[index] < arr[((index * 2) + 1)]) && (arr[index] < arr[((index * 2) + 2)]))
                {
                    break;
                }
                else
                {
                    if (arr.Count > ((index * 2) + 2))
                    {
                        if (arr[((index * 2) + 1)] < arr[((index * 2) + 2)])
                        {
                            int temp = arr[index];
                            arr[index] = arr[((index * 2) + 1)];
                            arr[((index * 2) + 1)] = temp;
                            index = ((index * 2) + 1);
                        }
                        else
                        {
                            int temp = arr[index];
                            arr[index] = arr[((index * 2) + 2)];
                            arr[((index * 2) + 2)] = temp;
                            index = ((index * 2) + 2);
                        }
                    }
                    else
                    {
                        int temp = arr[index];
                        arr[index] = arr[((index * 2) + 1)];
                        arr[((index * 2) + 1)] = temp;
                        index = ((index * 2) + 1);
                    }
                }
            }
        }

        public void SiftUp(List<int> arr)
        {
            int index = arr.Count - 1;
            while (index > 0)
            {
                if (arr[index] < arr[((index - 1) / 2)])
                {
                    int temp = arr[index];
                    arr[index] = arr[((index - 1) / 2)];
                    arr[((index - 1) / 2)] = temp;

                    index = (index - 1) / 2;
                }
                else
                {
                    break;
                }
            }
        }

        public void Insert(int item, List<int> arr)
        {
            arr.Add(0);
            arr[arr.Count - 1] = item;
            SiftUp(arr);
        }

        public void Remove(List<int> arr)
        {
            int temp = arr[0];
            arr[0] = arr[arr.Count - 1];
            arr[arr.Count - 1] = temp;
            arr.RemoveAt(arr.Count - 1);
            SiftDown(0, arr);
        }
    }
}