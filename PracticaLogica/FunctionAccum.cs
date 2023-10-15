/* accum("abcd") -> "A-Bb-Ccc-Dddd"
accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
accum("cwAt") -> "C-Ww-Aaa-Tttt" */

using System.Runtime.InteropServices;

public static class CapitalizeAndRepeatLetters
{
    public static string Accum(string WordToConvert)
    {
        string wordComplete = "";
        int contador = 0;

        foreach(char letter in WordToConvert)
        {
            
            for(int i =0 ; i <= contador ; i++)
            {   string letterToAdd= letter.ToString(); 
                
                wordComplete += i == 0 ? letterToAdd.ToUpper(): letterToAdd.ToLower(); 
                
            }
            contador++;
            if(contador < WordToConvert.Length) wordComplete += "-";

        }

        return wordComplete;
    }
}