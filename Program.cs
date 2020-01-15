using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corrected_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            int option;
            do
            {
                Console.WriteLine("Choose option: ");
                Console.WriteLine("1 Create Person ");
                Console.WriteLine("2 Change Name ");
                Console.WriteLine("3 Change Surname ");
                Console.WriteLine("4 Age");
                Console.WriteLine("5 Change Mood");
                Console.WriteLine("6 Check Marital Status");
                Console.WriteLine("7 Check Info About Person");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Type in Name:");
                        string typedinname = Console.ReadLine();
                        person.Name = typedinname;
                        Console.WriteLine("Type in Surname:");
                        string typedinsurname = Console.ReadLine();
                        person.Surname = typedinsurname;
                        Console.WriteLine("Type in Age:");
                        int typedinage = int.Parse(Console.ReadLine());
                        person.Age = typedinage;
                        Console.WriteLine("Type in Mood:");
                        string typedinmood = Console.ReadLine();
                        person.Mood = typedinname;
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Type in new Name:");
                        string newname = Console.ReadLine();
                        person.Name = newname;
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Type in new Surname:");
                        string newsuranme = Console.ReadLine();
                        person.Surname = newsuranme;
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Type in new Age:");
                        int newage = int.Parse(Console.ReadLine());
                        person.Age = newage;
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Type in new Mood:");
                        string newmood = Console.ReadLine();
                        person.Mood = newmood;
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine(person.Marital_Status);
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine(person.Brace_yourself());
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }

            } while (option != 0);
            
           
            
            
            
            Console.ReadKey();
        
        }
    }
}
