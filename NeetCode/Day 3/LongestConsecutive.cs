namespace Problem_Solving.NeetCode.Day_3
{
    internal class LongestConsecutive
    {

        //var result = LongestConsecutive([2, 20, 4, 10, 3, 4, 5]);
        //Console.WriteLine(result);
        //var result2 = LongestConsecutive([0, 3, 2, 5, 4, 6, 1, 1]);
        //Console.WriteLine(result2);
        //var result3 = LongestConsecutive([9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6]);
        //Console.WriteLine(result3);

        //public static int LongestConsecutive(int[] nums)
        //{
        //    if (nums.Length == 0) return 0;
        //    var DistinctArr = nums.Distinct().ToArray();
        //    Array.Sort(DistinctArr);
        //    var counters = new List<int>();
        //    int count = 1;
        //    for (int i = 0; i < DistinctArr.Length - 1; i++)
        //    {
        //        if (DistinctArr[i] + 1 == DistinctArr[i + 1])
        //        {
        //            count++;
        //        }
        //        else
        //        {
        //            counters.Add(count);
        //            count = 1;
        //        }
        //    }
        //    counters.Add(count);
        //    return counters.Max();
        //}
    }
}
