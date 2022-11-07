class Solution
{
    public static void Main(string[] args)
    {

        Console.WriteLine(Decode(".... . -.--   .--- ..- -.. ."));
    }

    public static string Decode(string morseCode)
    {
        string[] ssize = morseCode.Split(" ");
        string decodedMessage = "";

        for (int i = 0; i < ssize.Length; i++)
        {
            
            if (ssize[i] == "")
            {
                decodedMessage += " ";
            }
            else
            {
                decodedMessage += MorseCode.Get(ssize[i]);
            }
        }
        
        while (decodedMessage.Contains("  ")) decodedMessage = decodedMessage.Replace("  ", " ");
        
        return decodedMessage.Trim();

        // using System.Linq;
        //return string.Concat(morseCode.Trim().Replace("   ", "  ").Split().Select(s => s == "" ? " " : MorseCode.Get(s)));

        // using System.Linq;
        //return string.Concat(morseCode.Trim().Replace("   "," X ").Split().Select(x=>x!="X" ? MorseCode.Get(x) : " "));
    }
}
