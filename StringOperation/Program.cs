using System;
using System.Collections.Generic;

namespace StringOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputStrings = new List<string>();
            inputStrings.Add("book");
            inputStrings.Add("table");
            inputStrings.Add("apple");
            inputStrings.Add("glass");
            inputStrings.Add("spoon");
            inputStrings.Add("apple");
            inputStrings.Add("fork");

            string pattern = "apple";

            StringSearcher.WhenFound += EventMessage.ShowMessage;

            StringSearcher.Search(inputStrings, pattern);

        }
    }
}
