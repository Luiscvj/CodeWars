public static class IntToBinary
{
    public static string ConvertIntToBinary(int a , int b)
    {
        int res = a + b;
        var binary = Convert.ToString(res,2);
        return binary;
    }
}