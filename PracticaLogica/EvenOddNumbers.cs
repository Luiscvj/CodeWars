public static class EvenOddNumber
{
        public static string EvenOrOddNumbeer(int TargetNumber)
        {
               string value =  (TargetNumber % 2 )!= 0 ? "Numero impar": "Numero Par";
               return value;
               
        }
} 