namespace Problem_Solving.NeetCode.Day_9
{
    internal class LengthOfLongestSubstring
    {

        //Program program = new Program();
        //program.LengthOfLongestSubstring("abcabcbb");
        //program.LengthOfLongestSubstring(" ");

        //Input: s = "zxyzaxyz"
        //Output: 3

        //Input: s = "xxxx"
        //Output: 1
        //public int LengthOfLongestSubstring(string s)
        //{
        //    int length = 0;
        //    var hashset = new HashSet<char>();
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        for (int j = i; j < s.Length; j++)
        //        {
        //            if (!hashset.Contains(s[j]))
        //                hashset.Add(s[j]);
        //            else
        //            {
        //                length = Math.Max(length, hashset.Count);
        //                hashset.Clear();
        //                break;
        //            }
        //        }
        //    }
        //    return length;
        //}
        //public int LengthOfLongestSubstring(string s)
        //{
        //    int MaxLength = 0, left = 0;
        //    var hashset = new HashSet<char>();

        //    for (int right = 0; right < s.Length; right++)
        //    {
        //        while (hashset.Contains(s[right]))
        //        {
        //            hashset.Remove(s[left]);
        //            left++;
        //        }
        //        hashset.Add(s[right]);
        //        MaxLength = Math.Max(MaxLength, right - left + 1);
        //    }
        //    return MaxLength;
        //}
    }
}
