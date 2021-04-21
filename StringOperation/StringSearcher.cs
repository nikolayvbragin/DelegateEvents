using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperation
{
   
        public static class StringSearcher
        {
            public delegate void SearchMessage(string foundedString);
            public static event SearchMessage WhenFound;

            public static void Search(List<string> list, string pattern)
            {
               
                foreach (string itemString in list)
                {
                if (itemString == pattern)
                    {
                        WhenFound?.Invoke(itemString);
                        break;
                    }
                }
            }
        }


}
