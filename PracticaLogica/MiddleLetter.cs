/* Kata.getMiddle("test") should return "es"

Kata.getMiddle("testing") should return "t"

Kata.getMiddle("middle") should return "dd"

Kata.getMiddle("A") should return "A" */



public static class MiddleLetter
{
    public static string getMiddle(string Word)
    {
        string WordToReturn = "";
        int indexLetter = Word.Length/2;
        if((Word.Length%2) != 0)
        {
           
            string letterFound = Word.Substring(indexLetter,1);
            WordToReturn = letterFound;

        }else
        {
           string twoLetters = Word.Substring(indexLetter-1,2) ;
           WordToReturn = twoLetters;
        }

        return WordToReturn;

    }
}