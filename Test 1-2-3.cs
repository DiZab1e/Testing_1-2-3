using System.Linq;
using System.Collections.Generic;
public class LineNumbering
{
    public static List<string> Number(List<string> lines)
    {
        List<string> result = new List<string>();

        for (int i = 0; i < lines.Count; ++i)
            result.Add($"{i + 1}: {lines[i]}");

        return result;
    }
}