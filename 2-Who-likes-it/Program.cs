class Solution
{
    public static void Main(string[] args)
    {
        //string[] name  = {};                                 // --> "no one likes this"
        //string[] name = { "Peter" };                            // -- > "Peter likes this"
        string[] name = { "jacob", "alex" };                   // -- > "jacob and alex like this"
        //string[] name = {"max", "john", "mark"};              // -- > "max, john and mark like this"
        //string[] name = {"alex", "jacob", "mark", "max"};     // -- > "Alex, Jacob and 2 others like this"

        Console.WriteLine(Likes(name));
    }

    public static string Likes(string[] name)
    {

        if (name.Length == 1)
        {
            return name[0] + "  likes this";
        }
        else if (name.Length == 2)
        {
            return name[0] + " and " + name[1] + " like this";
        }
        else if (name.Length == 3)
        {
            return name[0] + ", " + name[1] + " and " + name[2] + " like this";
        }
        else if (name.Length >= 4)
        {
            return name[0] + ", " + name[1] + " and " + (name.Length-2) + " others like this";
        }
        else
        {
            return "no one likes this";
        }

        //switch (names.Length)
        //{
        //    case 0: return "no one likes this"; // :(
        //    case 1: return $"{names[0]} likes this";
        //    case 2: return $"{names[0]} and {names[1]} like this";
        //    case 3: return $"{names[0]}, {names[1]} and {names[2]} like this";
        //    default: return $"{names[0]}, {names[1]} and {names.Length - 2} others like this";
        //}

    }
}