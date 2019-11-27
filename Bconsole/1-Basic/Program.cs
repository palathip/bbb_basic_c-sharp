using System;

namespace _1_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic Syntax content

//            PrintAndInput();
//            Exer1();
//            Exer2();
//            ConditionIfElse();
//            ConditionSwitchCase();
//            WhileLoop();
//            DoWhileLoop();
//            ForLoop();
            Exer3();


        }

        // Basic Input Output
        static void PrintAndInput()
        {
            Console.Write("Enter Your Name:"); // Print
            String name = Console.ReadLine(); // Input Sring
            Console.Write("Enter Your Age:");
            int age = int.Parse(Console.ReadLine()); // Input Int,Float
            Console.WriteLine("My Name is " + name); // Print + Var
            Console.WriteLine("My Age " + age);
            Console.WriteLine("My Name is {0} Age {1}", name, age); // Print by Index
            Console.WriteLine($"My Name is {name} Age {age}"); // Print by Var
        }


        // Ex1 Input Output
        static void Exer1()
        {
            Console.WriteLine("******Enter Your Information******");
            Console.Write("Firstname-Lastname:");
            string stdName = Console.ReadLine();
            Console.Write("Nickname:");
            string stdNick = Console.ReadLine();
            Console.Write("Student ID:");
            string stdId = Console.ReadLine();

            Console.WriteLine("*******************************");
            Console.WriteLine($"Hello {stdNick}");
            Console.WriteLine($"Kun{stdName} Student ID{stdId}");
            Console.WriteLine("dek witya mor konkean");
            Console.WriteLine("*******************************");
        }

        // Ex2 Converter Meter
        static void Exer2()
        {
            Console.Write("length (Meter) :");
            float length = float.Parse(Console.ReadLine());
            Console.WriteLine("***************************");
            float Wa = length / 2;
            float Elbow = Wa * 4;
            float Khub = Elbow * 2;
            float inch = Khub * 12;
            Console.WriteLine($"{length} meter = {Wa} wah");
            Console.WriteLine($"{Wa} wa = {Elbow} elbow");
            Console.WriteLine($"{Elbow} elbow = {Khub} khub");
            Console.WriteLine($"{Khub} khub = {inch} inch");
        }

        // if else condition
        static void ConditionIfElse()
        {
            Console.Write("Enter Age:");
            int age = int.Parse(Console.ReadLine());
            if (age < 15)
            {
                Console.WriteLine("You young");
            }
            else if (age < 25)
            {
                Console.WriteLine("You Mid");
            }
            else
            {
                Console.WriteLine("You old");
            }
        }

        // Switch Case Condition
        static void ConditionSwitchCase()
        {
            Console.Write("Enter Age:");
            int age = int.Parse(Console.ReadLine());
            switch (age)
            {
                case 60:
                    Console.WriteLine("You Old");
                    break;
                case 50:
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }


        }

        // While Loop Condition
        static void WhileLoop()
        {
            Console.WriteLine("Enter Loop Count:");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            while (count <= 10)
            {
                Console.WriteLine("While Hello");
                count++;
            }
        }

        // Do While Loop Condition
        static void DoWhileLoop()
        {
            Console.WriteLine("Enter Loop Count:");
            int num = int.Parse(Console.ReadLine());
            int count1 = 0;
                 do
                 {
                     Console.WriteLine("Do While Hello");
                     count1++;
                 } while (count1 <= num);
        }

        // For Loop Condition
        static void ForLoop()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("For Hello");
            }
            
            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine("Hello J");
                if(j == 5)break;
            }
            
            for (int k = 0; k <= 10; k++)
            {
                if (k % 2 == 0) continue;
                Console.WriteLine($"Hello K{k}");
            }
        }

        //Exercise 3
        static void Exer3()
        {
            Console.WriteLine("***Program Calculate BMI***");
            Console.Write("Weigth(kg):");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("Heigth(m):");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Your status is" + bmiCal(weight, height));
        }
        public static string bmiCal(float weight, float height)
        {
            float bmi = weight / (height * height);

            if (bmi > 39.9)
            {
                return "Obesity max";
            }
            else if (bmi > 34.9)
            {
                return "Obesity 2";
            }
            else if (bmi > 28.4)
            {
                return "Obesity 1";
            }
            else if (bmi > 23.4)
            {
                return "Overweight";
            }
            else if (bmi > 18.5)
            {
                return "Normal weight";
            }
            else
            {
                return "Under weight";
            }
        }

        //Exercise 4
        static void Exer4()
        {
            Console.Write("Enter Number of Student :");
                       int numberStd = int.Parse(Console.ReadLine());
                       int[] arrayStd = new int[numberStd];
                       String[] stdName = new string[numberStd];
                       for (int i = 0; i < arrayStd.Length; i++)
                       {
                           Console.WriteLine($"Student {i+1}");
                           Console.Write("ID :");
                           stdName[i] = Console.ReadLine();
                           Console.Write("Score :");
                           arrayStd[i] = int.Parse(Console.ReadLine());
                       }
            
                       Console.WriteLine("========Calculate Grade=========");
                       for (int i=0;i<arrayStd.Length;i++)
                       {
                           Console.WriteLine("{0}  {1}", stdName[i],gradeCal(arrayStd[i]));
                       }
                       Console.WriteLine("================================");
        }
        public static string gradeCal(int score)
        {
            if (score >= 80)
            {
                return "A";
            }
            else if (score >= 70)
            {
                return "B";
            }
            else if (score >= 60)
            {
                return "C";
            }
            else if (score >= 50)
            {
                return "D";
            }
            else
            {
                return "F";
            }

            //Try Catch 
            //            try
            //            {
            //                int num = int.Parse(Console.ReadLine());
            //            }
            //            catch (Exception ex)
            //            {
            //                Console.WriteLine("Error:"+ex.Message);
            //            }

        }
    }
}
