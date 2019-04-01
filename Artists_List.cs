// Sample Dictionary
using System;
using System.Collections.Generic;

namespace DictionaryExample
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create a dictionary in which both keys and values are strings.
      Dictionary<string, string> dict = new Dictionary<string, string>();

      // Add some items to the dictionary: each has a key and a value.
      dict.Add ("Weird Al", "Sings parodies of hit songs");
      dict.Add ("Dr Dre", "A hip hop artist who raps about hardships and successes");
      dict.Add ("Snoop Dog", "A hip hop artist who raps about hedonism");
      dict.Add ("Metallica", "A very successful heavy metal group");
      dict.Add ("Susan Vega", "a women who doesn't really sing but talks and found great success with this style");
      dict.Add ("Coolio", "A two hit hip hop wonder from the 90s");


      // See if the dictionary contains a particular key.
      Console.WriteLine ("Use the ContainsKey method to see if a movies exists in your dictionary:");
      Console.WriteLine ("Contains key Weird Al       " + dict.ContainsKey ("Weird Al"));
      Console.WriteLine ("Contains key Dr Dre     " + dict.ContainsKey ("Dr Dre"));
      Console.WriteLine ("Snoop Dog" + dict.ContainsKey ("Snoop Dog"));

     // Iterate the dictionary's contents with foreach.
      // Note that you're iterating pairs of keys and values,
      // using the KeyValuePair<T,U> type.
      Console.WriteLine ("\nContents of the dictionary:");
      foreach (KeyValuePair<string, string> pair in dict)
      {
            // Because the key is a string, you can use string methods
            Console.WriteLine ("Key: " + pair.Key.PadRight(8) + "  Value: " + pair.Value);
      }

      // List the keys, remember they are in no particular order.
      Console.WriteLine ("\nJust the keys:");

      // Dictionary<TKey, TValue>.KeyCollection is a collection of just the keys,
     // in this case strings. So here's how to retrieve the keys:
      Dictionary<string, string>.KeyCollection keys = dict.Keys;
      foreach(string key in keys)
      {
            Console.WriteLine ("Key: " + key);
      }

      // List the values, which are in same order as key collection above.
      Console.WriteLine ("\nJust the values:");
      Dictionary<string, string>.ValueCollection values = dict.Values;
      foreach (string value in values)
      {
            Console.WriteLine ("Value: " + value);
      }

      Console.Write ("\nNumber of items in the dictionary: " + dict.Count);

    }
  }
}
