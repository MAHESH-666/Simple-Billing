using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("hello mahesh kamalay");
             Console.WriteLine("hello world this is mahesh");

             //Data types
             int a = 2;
             Console.WriteLine(a);

             bool b = false;
             Console.WriteLine(b);

             double f = 23.5;
             Console.WriteLine(f.GetType());

             int c = 'a';
             Console.WriteLine(c.GetType());
             string s = "welcome c sharp";
             Console.WriteLine(s.GetType());

             //Variables

             /*int age = 21;
             Console.WriteLine("age is {0} ",age);
             int age1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("age1 is {0}",age1);

             int age2 = 18;
             Console.WriteLine("age2 is {0}",age2);*/

            //operators
            //arithmetic operators
            /*int x = 10, y = 20;
            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);
            Console.WriteLine(x % y);

            //relational operators

            Console.WriteLine(x > y);
            Console.WriteLine(x < y);
            Console.WriteLine(x >= y);
            Console.WriteLine(x <= y);
            Console.WriteLine(x !=y);

            //assignment operators

            Console.WriteLine(x = y);
            Console.WriteLine(x += y);
            Console.WriteLine(x -= y);
            Console.WriteLine(y += x);
            Console.WriteLine(y -= x);
            //a=a+10;

            //unary operator
            Console.WriteLine(++x);
            Console.WriteLine(x);

            //ternary operators
            Console.WriteLine("ternary operators");
            Console.WriteLine(x<y?y:x);

            //logical operator

            Console.WriteLine(x > y && x < y);
            Console.WriteLine(x > y || x < y); */

            //adding two numbers......................

            /*int a, b, c;
            Console.Clear();
            Console.WriteLine("Enter any numbers: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Result : " + c)*/

            //dividing two numbers

            /*int i, j;
            double k;
            Console.Clear();
            Console.WriteLine("Enter any numbers: ");
            i = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToInt32(Console.ReadLine());
            k = (double)i / j;
            Console.WriteLine("Result" + k);*/

            /*int a;
            Console.Clear();
            Console.WriteLine("Enter Any Number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a : " + a);
            Console.WriteLine("a : " + ++a);
            Console.WriteLine("a : " + a);
            Console.WriteLine("a : " + a++);
            Console.WriteLine("a : " + a);


            Console.WriteLine("a : " + a);
            Console.WriteLine("a : " + --a);
            Console.WriteLine("a : " + a);
            Console.WriteLine("a : " + a--);*/

            /*int a;
            Console.Clear();
            Console.WriteLine("Enter any numbers: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        if (a > 5)
                        {
                            Console.WriteLine("welcone");

                        }
                        Console.WriteLine("Number : " + a);*/


            /* int a = 10;
             int b = 55;
             int c = 565;
             if (a < b)
             {
                 if(b<c)
                 Console.WriteLine("a is big");
             }
             else if (b > c)
             {
                 Console.WriteLine("b is big");
             }
             else
             {
                 Console.WriteLine("c is big");
             }
             */

            //reverse the even numbers


            /* iNum = 12;
            Console.Clear();
            Console.WriteLine("Enter any numbers: ");
            iNum = Convert.ToInt32(Console.ReadLine());
            int i = iNum - 1;
            while (i>0)
            {
                if (i% 2 == 0)
                {
                    Console.WriteLine(i + " ");
                }
                i--;
            }*/

            /*for (int i=2;i<20;i++)
                {
                Console.WriteLine(i);
            }
            Console.ReadLine();*/

            //finding big numbers in given three integers

            /*int a, b, c;
            Console.Clear();
            Console.WriteLine("Enter any Number: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a + "is big");
            }

            else if (b > c)
            {
                Console.WriteLine(b + "is big");
            }

            else if (c > a)
            {
                Console.WriteLine(c + "is big");
            }


            else if (a > c)
            {
                Console.WriteLine(a + "is big");
            }


            else if (c > b)
            {
                Console.WriteLine(c + "is big");
            }


            else if (b > a)
            {
                Console.WriteLine(b + "is big");
            }

            else
            {
                Console.WriteLine("All are Equal");
            }*/

            //printing 5*5 patterns

            /* for (int i=1;i<=5;i++)
            {
                for(int j=1;j<=5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.ReadLine();*/

            //Find Even or odd numbers???????????????????????????????????????????????

            /*int num = 5311323;
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even");

            }
            else
                    {
                Console.WriteLine("number is odd");
            }*/

            //else if example code;................................................
            /* int marks = 100;
             if(marks>=85&& marks<=100)
             {
                 Console.WriteLine("congrats you're topper");
             }
             else if(marks>=75&&marks<85)
             {
                 Console.WriteLine("you're second rank");
             }
             else if(marks>50&&marks<75)
             {
                 Console.WriteLine("you got 3rd rank");
             }
             else if(marks>35&&marks<50)
             {
                 Console.WriteLine("you just passed");
             }
             else
             {
                 Console.WriteLine("you failed");
             }
             Console.ReadKey();*/


            //finding biggest among three numbers.................................

            /*int a = 100, b = 20, c = 30;
            if(a>b)
            {
                if (a > c)
                {
                    Console.WriteLine(a + "is big");
                }
                else
                {
                    Console.WriteLine(c + "is big");
                }
            }
            else if (b > c)
            {
                Console.WriteLine(b + "is big");
            }
            else
            {
                Console.WriteLine(c + "is big");
            }
            Console.ReadKey();*/

            //while loop,do while loop,for & for each loop................................

            //while loop
            /*int=1;
             while (i<10)
             {
                 Console.WriteLine(i + "");
                 i++;
             }

            int  i = 100;
            while (i >= 0)

            {
            Console.WriteLine(i + " ");
            i--;*/

            //do while loop
            /*int i = 1;
            do
            {
                Console.Write(i);
                i++;
            }
            while (i < 0);*/
            //for loop

            /* for (int i = 1; i < 50; i++)
             {
                 Console.WriteLine(i + " ");
             }*/
            //for each......

            /*int[] a = { 10,20,20,30,10,40,5,565,565  };
            foreach(int i in a)
            {
                Console.WriteLine(i);

            }*/

            //strings in program.............................................................

            /*string str = "mahesh", str2 = "shreya";
            Console.WriteLine(str.Equals(str2));
            Console.WriteLine(str + " " + str2); //concatinating b/w 2 strings
            Console.WriteLine(str.Reverse());*/




            //print odd numbers in reverse using for loop.................................

            /*int iLimit;

            Console.Clear();
            Console.WriteLine("Enter any Number: ");
            iLimit = Convert.ToInt32(Console.ReadLine());
            for (int i=iLimit; i >=1; i--)
            {
               if(i%2!=0)


            {
            Console.WriteLine(i);

            }*/

            /* int a, b, c;
             Console.Clear();
             Console.WriteLine("Enter any Number: ");
             a = Convert.ToInt32(Console.ReadLine());
             b = Convert.ToInt32(Console.ReadLine());
             c = Convert.ToInt32(Console.ReadLine());

             if (a > b && a > c)

             {
                 Console.WriteLine(a + "is big");

             }
             else if (a == b && a>c)
             {
                 Console.WriteLine("both first and second values are equal than " + c);
             }

             else if (b>a && b>c)
             {
                 Console.WriteLine(b + " is big");
             }
             else if (b == a && b>c)
             {
                 Console.WriteLine("both second and third values are equal than " + a);
             }

             else if (c > b && c > a)
             {
                 Console.WriteLine(c + " is big");
             }
             else if (c == b && c>a)
             {
                 Console.WriteLine("both first and third values are equal than " + b);
             }

             /*else if(a==b && b==c && c==a)
             {
                 Console.WriteLine("All are Equal");
             }

             else
             {
                 Console.WriteLine("All are Equal");*/

            /*int[] num;
            int iSize;
            Console.WriteLine("Enter Size: ");
            iSize = Convert.ToInt32(Console.ReadLine());


            num = new int[iSize];
            Console.WriteLine("Enter Even NUmbers: ");
            for (int i = 0; i < iSize; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + "is even");
                }
                else
                {
                    Console.WriteLine(i + "is odd");
                }
                Console.ReadKey();
            }*/

            /*int[] num;
            int iSize;
            Console.WriteLine("Enter Size: ");
            iSize = Convert.ToInt32(Console.ReadLine());


            num = new int[iSize];
            Console.WriteLine("Enter any NUmbers: ");
            for (int i = 0; i <= iSize; i++)
            {
                if (i >= iSize)
                {
                    Console.WriteLine(i + "is big");
                }


                  else if (i <= iSize)

                    {
                        Console.WriteLine(i + "is smallest");

                    }
                }*/

            /*int inum, count = 0, i = 1;
            Console.WriteLine("Enter the Number: ");
            inum = Convert.ToInt32(Console.ReadLine());

            while(i <= inum)
            {
                if (inum % i == 0)
                    count++;
                i++;
            }
            if (count == 1)
            {
                Console.WriteLine("the number is prime: ");
            }
            else
            {
                Console.WriteLine("the Number is Not Prime: ");
            */

            //find the biggest and smallest elements without using arrays........................
            /*int iNum,largest,smallest,iSize;
            Console.WriteLine("Enter Size : ");
            iSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter First Number: ");
            iNum = Convert.ToInt32(Console.ReadLine());

            largest = iNum;
            smallest = iNum;

            for (int i  = 1; i < iSize-1; i++)
            {
                Console.WriteLine("Enter Another Number: ");
                iNum = Convert.ToInt32(Console.ReadLine());
                if (iNum > largest)
                    largest = iNum;
                if (iNum < smallest)
                    smallest = iNum;
            }
            Console.WriteLine("the largest number is " + largest);
            Console.WriteLine("the smallest number is " + smallest);*/

            /*int j, num;
            Console.WriteLine("Enter Any Number");
            num = Convert.ToInt32(Console.ReadLine());

            for (int j = 1; j<= 10; j++)
            {
                Console.Write("{0} x {1} = {2}\n", num, j, num * j);
            }*/



        }
    }
}


  
