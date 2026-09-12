using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace loops___pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //loops___pattern

            //loops__
            //reomving repeacted code into the program
            //example 
            Console.WriteLine("hello");
            Console.WriteLine("hello");
            Console.WriteLine("hello");
            Console.WriteLine("hello");
            Console.WriteLine("hello");
            Console.WriteLine("hello");
            Console.WriteLine("hello");
            Console.WriteLine("hello");



            //for loop
            //for (int i = 0; i < length; i++)


            //for (initialization; condition; increment / decrement)
            //{
            //    // code
            //}


            for (double i = 0; i < 4; i++)
                Console.WriteLine("hii i am here !");



            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            //EventArgs number



            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);

            }
            //odd 

            for (int i = 1; i <= 20; i += 2)
            { Console.WriteLine(i); }

            //reverse 
            for (int i = 10; i >= 1; i--)
            { Console.WriteLine(i); }


            //while loops

            //int i = 1;
            //while (i <= 5)
            //{  Console.WriteLine(i);
            //    i++;
            //}




            int c = 1;

            while (c <= 5)
            {
                Console.WriteLine(c);
                c++;
            }


            //int g = 2;
            //while (g <=10)
            //{  Console.WriteLine(g); 
            //}
            //if you are absent the c++ yhat time it contune loop are genrating so be use the c++)


            int k = 3;
            while (k <= 15)
            {
                Console.WriteLine(k);
                k++;
            }




            //do while 
            //if while use for the condition check then output will be display 
            //AuthenticatedStream the do while it will be use because display the output then they check the condition 



            int ok = 1;

            do

            {
                Console.WriteLine(ok);
                ok++;
            }
            while (ok <= 10);




            int f = 9;

            do
            {
                Console.WriteLine(f);
                f++;

            }
            while (f > 10);



            //break 
            //if it will be use for the immedicatly stop the loop and the stop proccessing 
            //if we can use the break theloop will be stop exitcuting the procees



            for (int w = 1; w < 10; w++)
            {
                if (w == 2)


                    break;
                { }

                Console.WriteLine(w);

            }


            for (int p = 5; p < 10; p++)
            {
                if (p == 2)
                    break;
                Console.WriteLine(p);


            }


            //continue:
            //Attribute only one valuse it will be skiping and other value
            //it will be display these are  knwon as these continue fuction used
            Console.WriteLine("y");
            Console.WriteLine("y");


            for (int s = 1; s < 10; s++)
            {
                if (s == 3)

                    continue;
                Console.WriteLine(s);
            }

            //Nestedloop 
            //fixing the two loop  in a same loop 
            //simply combining the loops are non as NestedContainer looop
            for (int z = 1; z <= 6; z++)
            {
                for (int j = 1; j <= 3; j++)

                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }


            for (int qz = 1; qz <= 6; qz++)
            {
                for (int qj = 1; qj <= 3; qj++)

                {
                    Console.Write("&&");

                }
                Console.WriteLine();
            }


            for (int s = 1; s < 5; s++)
            {
                for (int ks = 1; ks <= s; ks++)
                {
                    Console.Write("* ");
                }

                    Console.WriteLine();
                }


            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }



            for (int s = 1; s < 11; s++)
            {
                for (int ks = 1; ks <= s; ks++)
                {
                    Console.Write(s );
                }

                Console.WriteLine();
            }


            Console.Write("enter the number"
                );
            int sum = Convert.ToInt32(Console.ReadLine());
            int factorial = sum;

                for (int i = 1; i <= sum; i++)
            { factorial = factorial * i;   }
            Console.WriteLine();
           

            















        }












        } 










    }

    

