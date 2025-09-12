namespace Problem_Solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var concatedStr = Encode(["neet", "code", "love", "you"]);
            ////var concatedStr = Encode([""]);
            //Console.WriteLine(concatedStr);
            //var result = Decode(concatedStr);
            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
        }
    }

    //public static string Encode(IList<string> strs)
    //{
    //    string EncodedStr = string.Empty;
    //    foreach (var str in strs)
    //    {
    //        if (str == "")
    //        {
    //            EncodedStr += ",";
    //            continue;
    //        }

    //        foreach (var c in str)
    //            EncodedStr += (int)c + " ";

    //        EncodedStr += "#";
    //    }
    //    return EncodedStr;


    //}
    //public static List<string> Decode(string s)
    //{
    //    List<string> strs = new List<string>();
    //    List<string> DecodedStrs = new List<string>();
    //    strs = s.Trim().Split('#', StringSplitOptions.RemoveEmptyEntries).ToList();
    //    foreach (string word in strs)
    //    {
    //        if (word.Contains(','))
    //        {
    //            DecodedStrs.Add("");
    //            continue;
    //        }
    //        var chars = word.Trim().Split(" ")
    //                                .Select(num => (char)int.Parse(num)).Concat("").ToList();
    //        string result = "";
    //        foreach (var item in chars)
    //            result += item;

    //        DecodedStrs.Add(result);
    //    }
    //    return DecodedStrs;

    //}
}
}