namespace Problem_Solving.NeetCode.Day_4
{
    internal class EncodeDecode
    {
        //var concatedStr = Encode(["neet", "code", "love", "you"]);
        ////var concatedStr = Encode([""]);
        //Console.WriteLine(concatedStr);
        //    var result = Decode(concatedStr);
        //    foreach (var item in result)
        //    {
        //        Console.Write(item + " ");
        //    }

        //public static string Encode(IList<string> strs)
        //{
        //    string res = "";
        //    foreach (string s in strs)
        //    {
        //        res += s.Length + "#" + s;
        //    }
        //    return res;
        //}

        //public static List<string> Decode(string s)
        //{
        //    List<string> res = new List<string>();
        //    int i = 0;
        //    while (i < s.Length)
        //    {
        //        int j = i;
        //        while (s[j] != '#')
        //            j++;

        //        int length = int.Parse(s.Substring(i, j - i));
        //        i = j + 1;
        //        j = i + length;
        //        res.Add(s.Substring(i, length));
        //        i = j;
        //    }
        //    return res;
        //}
    }

}
