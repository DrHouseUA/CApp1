using System;

namespace CApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Dude";
            int Age = 28;
            bool isEmployed = false;
            double Weight = 80.52;
            var c =20;
            var hello = "helloooooo";
            Console.WriteLine($"{Name}");
            Console.WriteLine("Введите свое имя:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi {name}!");
            {
                Console.WriteLine("First block");
                {
                    Console.WriteLine("Second block"); 
                    Console.WriteLine($"Name: {Name}; Age: {Age};  Weight: {Weight}");
                    Console.WriteLine("Employed:{0}; +{1} +{2} +{2} +{1} +{0}", isEmployed,c,hello);
                    Console.WriteLine(c.GetType().ToString());
                    Console.WriteLine(hello.GetType().ToString());

                }
                
                Console.WriteLine("Vivod i transformatsia Peremennih block start");
                {
                    Console.WriteLine("Input Name:");
                    string name2 = Console.ReadLine();
                    Console.WriteLine("Input Age:");
                    int age2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input Height:");
                    double height2 = Convert.ToDouble(Console.ReadLine()); // При вводе важно учитывать текущую операционную систему. В одних культурах разделителем между целой и дробной частью является точка (США, Великобритания...), в других - запятая (Россия, Германия...). Например, если текущая ОС - русскоязычная, значит, надо вводить дробные числа с разделителем запятой. Если локализация англоязычная, значит, разделителем целой и дробной части при вводе будет точка.
                    Console.WriteLine("Input salary");
                    decimal salary = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Name {0}; Age {1}; Height {2}; Salary {3}", name2, age2, height2, salary);

                    Console.WriteLine("Vivod i transformatsia Peremennih block end");
                }

                Console.WriteLine("Encryp block start");
                {
                    
                    int x1 = 45;
                    int key = 102;
                    int encrypt = x1 ^ key;
                    Console.WriteLine("Zashifrovanoe 4islo:" + encrypt);

                    int decrypt = encrypt ^ key;

                    Console.WriteLine("Ishodnoe 4islo:" + decrypt);
                    Console.WriteLine("Encryp block end");
                }
            }
            System.Console.ReadKey();
        }
    }
}
