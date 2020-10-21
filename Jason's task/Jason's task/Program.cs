using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jason_s_task
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<float> time = new List<float>();
            double maleworld = 9.58;
            double maleeurope = 9.86;
            double malebritain = 9.87;

            double femaleworld = 10.49;
            double femaleeurope = 10.73;
            double femalebritain = 10.99;
            






            Console.WriteLine("What Gender Does The Race Consist Of? 1 - Male,  2 - Female");
            int gender = Convert.ToInt32(Console.ReadLine());


            if (gender != 1 || gender != 2)
            { 
                while (gender != 1 && gender != 2)
                {
                    Console.WriteLine("Please Enter A Valid Choice:  1 - Male,  2 - Female");
                    gender = Convert.ToInt32(Console.ReadLine());
                    if (gender == 1 || gender == 2) { break; }
                }
            }

            
            
            Console.WriteLine("How Many Constestors Are There? (Between 4 And 8)");
            int lanes = Convert.ToInt32(Console.ReadLine());
            if (lanes < 4 || lanes > 8) { while (true) { Console.WriteLine("Enter a valid amount");
                    lanes = Convert.ToInt32(Console.ReadLine());
                    if (lanes > 4 && lanes < 8  || lanes == 4 || lanes == 8) { break; }
                } }
            for (int i = 0; i < lanes; i++)
            {
                
                Console.WriteLine("What Was The Time Of The Contestant?");
                time.Add(float.Parse(Console.ReadLine()));


            }

            time.Sort();
            Console.Clear();
            for (int i = 0; i < lanes; i++)
            {

                Console.WriteLine( time[i]);
                Console.WriteLine("---------------------------");



            }
            if (gender == 1)
            {
                for (int i = 0; i < lanes; i++)
                {
                    if (time[i] < maleworld)
                    {

                        Console.WriteLine(time[i] + " Has Just Broke The World Record!");

                        maleworld = time[i];
                    }
                    else if (time[i] < maleeurope)
                    {

                        Console.WriteLine( time[i] + " Has Just Broke The European Record!");
                        maleeurope = time[i];
                    }
                    else if (time[i] < malebritain)
                    {
                        Console.WriteLine(time[i] + " Has Just Broke The British Record!");
                        malebritain = time[i];
                    }

                }
            }
            if (gender == 2)
            {
                for (int i = 0; i < lanes; i++)
                {
                    if (time[i] < femaleworld)
                    {

                        Console.WriteLine(time[i] + " Has Just Broke The World Record!");

                        femaleworld = time[i];
                    }
                    else if (time[i] < femaleeurope)
                    {

                        Console.WriteLine(time[i] + " Has Just Broke The European Record!");
                        femaleeurope = time[i];
                    }
                    else if (time[i] < femalebritain)
                    {
                        Console.WriteLine(time[i] + " Has Just Broke The British Record!");
                        femalebritain = time[i];
                    }

                }
            }
            
            
            
            
            
         Console.ReadKey();

        }
    }
}
