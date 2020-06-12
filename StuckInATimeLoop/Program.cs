using System;

namespace StuckInATimeLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stuck In A Time Loop
            //  https://open.kattis.com/problems/timeloop



            var str = "Abracadabra";
            var num = EnterNum();

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"{i} {str}");
            }
        } // ---- end main ----
        private static int EnterNum()
        {
            int a = 0;
            string str = " ";
            str = Console.ReadLine();
            try
            {
                 a = int.Parse(str);
                if (a <= 0 || a > 100)
                    throw new ArgumentException();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType().ToString());
                return EnterNum();
            }
            return a;
        }
    }
}
