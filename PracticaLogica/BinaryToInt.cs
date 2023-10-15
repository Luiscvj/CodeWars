public static class BinaryToInt
{
    public static int ConvertBinaryToInt(int[] ArrayBinary)
    {
        int sizeBinary = ArrayBinary.Length;
        int contador = 0;
        double  NumReturn =0;
        foreach(int bit in ArrayBinary)
        {    contador++;
            if(bit == 1)
            {
               int bitPosition = sizeBinary - contador;
            
               NumReturn  += bitPosition != 0 ? Math.Pow(2,bitPosition): Math.Pow(2,0);
               Console.WriteLine($"BitPosition {bitPosition}, contador {contador}, sizeBinary {sizeBinary}, resultado final {NumReturn}");
               Console.WriteLine(Math.Pow(2,3));
            }
           
        }
        return (int)NumReturn;
    }

}