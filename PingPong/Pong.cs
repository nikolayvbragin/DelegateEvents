using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    static class Pong
    {
        public delegate void EventHandler();
        public static event EventHandler GetPing;

        public static void GameAction()
        {
            Random rnd = new Random();
            int magicnumber = rnd.Next(0, 50);
            if (magicnumber > 2)
            {
                Console.WriteLine("Понг получил Пинг");
                Console.Beep();
                GetPing?.Invoke();
            }
            else
            {
                Console.WriteLine("Понг проиграл, выиграл Пинг");
            }
        }

    }
}
