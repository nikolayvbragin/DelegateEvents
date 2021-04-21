using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvents
{
    class ClassCounter
    

    {
        public delegate void General();
        public static event General ReachedThreshold;
        
                
         public static void Count()

        
        

        {
            int ind = 0;
            while (ind<=100) 
            {
                if (ind == 77)
                {

                   ReachedThreshold();

                }
                ind++;
            }
        }

            
            
    }
}
