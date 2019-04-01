using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<String> One_Hit_Wonders = new HashSet<String>();
        HashSet<String> Two_Hit_Wonders = new HashSet<String>();

        One_Hit_Wonders.Add ("Vanilla Ice,");
        One_Hit_Wonders.Add ("Dexys Midnight Runners,");
        One_Hit_Wonders.Add ("Right Said Fred,");

        One_Hit_Wonders.Add ("Right Said Fred,"); // error, can't add Right Said Fred again, must be unique
                                                      // ... processing continues, but second Right Said Fred not added

        Two_Hit_Wonders.Add ("Coolio,"); 
        Two_Hit_Wonders.Add ("Susan Vega,"); 
        Two_Hit_Wonders.Add (" Marky Mark and the Funky Bunch,"); 

        Console.Write ("One_Hit_Wonders contains {0} elements: ", One_Hit_Wonders.Count);
        DisplaySet (One_Hit_Wonders);

        Console.Write("Two_Hit_Wonders contains {0} elements: ", Two_Hit_Wonders.Count);
        DisplaySet (Two_Hit_Wonders);

      // Create a new HashSet populated with even numbers.
        HashSet<String> allArtistMembers = new HashSet<String>(One_Hit_Wonders);
        Console.WriteLine ("allArtistMembers UnionWith Two_Hit_Wonders ...");
        allArtistMembers.UnionWith (Two_Hit_Wonders);

        Console.Write ("allArtistMembers contains {0} elements: ", allArtistMembers.Count);
        DisplaySet (allArtistMembers);

    }

    private static void DisplaySet (HashSet<String> set)
    {
        Console.Write ("{");
        foreach (String i in set)
        {
                Console.Write (" {0}", i);
        }
        Console.WriteLine (" }");
    }
}

