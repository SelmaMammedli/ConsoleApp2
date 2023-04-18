using ConsoleApp20.Models;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Category category = new Category("psychotropic");
            Medicine medicine = new Medicine("sertralin", 100, 1000);

            string input = "";
            do
            {
                Console.WriteLine("Apteke xosh geldiniz");
                Console.WriteLine("Menu");
                Console.WriteLine("1.Category Menu");
                Console.WriteLine("2.Derman Menusu");
                Console.WriteLine("0.Exit");
                Console.Write("Secim edin :  ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("secim edin");
                        string input2 = Console.ReadLine();
                        switch (input2)
                        {
                            case "1":
                                category.Create();
                                break;
                            case "2":
                                category.Delete();
                                break;
                            case"3":
                                category.Update();
                                break;
                           
                                
                            default:

                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("secim edin");
                        string input3 = Console.ReadLine();

                        switch (input3)
                        {
                            case "1":
                                medicine.Create();
                                break;
                            case "2":
                                medicine.Delete();
                                break;
                            case "3":
                                medicine.Update();
                                break;
                            case "4":
                                medicine.Sell();
                                break;
                            default:

                                break;
                        }
                        break;
                }
            }
            while (input != "0");
        }
    }
}
