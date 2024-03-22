
using System.Runtime.InteropServices;

namespace InsertInterval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] [] intervals = [[1, 2], [3, 5], [6, 7], [8, 10], [12, 16]];
            int[] newInterval =  [2, 3] ;

            int[][] result = InsertInterval(intervals, newInterval);

            foreach (int[] interval in result)
            {
                Console.Write("[");
                foreach (int num in interval)
                {
                    Console.Write(num + " ");
                }
                Console.Write("], ");
            }


        }

        private static int[][] InsertInterval(int[][] intervals, int[] newInterval)
        {
            int n = intervals.Length, i = 0;
            List<int[]> res = new List<int[]>();

            while (i < n && intervals[i][1] < newInterval[0]) {
                res.Add(intervals[i]);
                i++;
            }
            while(i<n && newInterval[1] >= intervals[i][0]) {
                newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
                newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
                i++;
            }
            res.Add(newInterval);

            while(i<n)
            {
                res.Add(intervals[i]);
                i++;
            }

           return res.ToArray();
            
        }
    }
}
