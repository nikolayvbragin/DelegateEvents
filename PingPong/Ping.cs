using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    static class Ping
    {
        public delegate void EventHandler();
        public static event EventHandler GetPong;

        public static void GameAction()
        {
            Random rnd = new Random();
            int magicnumber = rnd.Next(0, 50);
            if (magicnumber > 2)
            {
                Console.WriteLine("Пинг получил Понг");
                Console.Beep();
                GetPong?.Invoke();
            }
            else
            {
                Console.WriteLine("Пинг проиграл, выиграл Понг");
            }
        }

    }
}
