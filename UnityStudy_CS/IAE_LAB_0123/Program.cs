using System;

namespace IAE_LAB_0123
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();


            while (true)
            {
                game.Process();
            }
        }
    }
}