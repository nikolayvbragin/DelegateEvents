using System;

namespace PingPong
{
    class Program
    {
        static void Main(string[] args)
        {
            Pong.GetPing += Ping.GameAction;
            Ping.GetPong += Pong.GameAction;

            Random rnd = new Random();
            int magicnumber = rnd.Next(0, 10);
            if (magicnumber > 5)
            {
                Ping.GameAction(); 
            }
            else
            {
                Pong.GameAction();
            }


        }
    }
}
