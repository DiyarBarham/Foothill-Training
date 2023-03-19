namespace Acme.common;
public static class StringHandler
{
    /// <summary>
    /// Inserts spaces before each capital letter in a String.
    /// </summary>
    /// <param name="source"></param>
    /// <returns></returns>
    public static String InsertSpaces(this String source)
    {
        String result = String.Empty;

        if (!String.IsNullOrWhiteSpace(source))
        {
            foreach(char c in source)
            {
                if (char.IsUpper(c))
                {
                    result = result.Trim();
                    result += " ";
                }
                result += c; 
            }
        }

        return result.Trim();
    }
}

