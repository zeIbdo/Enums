using Enums.Tempers;

namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon(10); 
            
                Menu:
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1 - Fill the weapon");
                Console.WriteLine("2 - Check the next bullet");
                Console.WriteLine("3 - Fire the weapon");
                Console.WriteLine("4 - Exit");
                Console.WriteLine("Choose an option");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "4":
                        return;
                    case "1":
                        BulletType:
                        Console.WriteLine("Choose bullet type (9 mm - mm9 or 1, 5.56 mm - mm556 or 2 , 7.62 mm - mm763 or 3)");
                        string BulletType = Console.ReadLine();
                        BulletTypes bulletTypes;
                        bool correctBullet = Enum.TryParse(BulletType, out bulletTypes);
                        if (correctBullet)
                        {
                        count:
                            Console.WriteLine("Enter number of bullets:");
                            string str = Console.ReadLine();
                        int count;
                        if (int.TryParse(str, out count)&&count>0)
                        {
                            weapon.Fill(bulletTypes, count);
                        }
                        else { Console.WriteLine("Invalid input(desired is above zero)"); goto count; }
                        }
                        else { Console.WriteLine("invalid input"); goto BulletType; }
                    Console.WriteLine("press enter");
                    Console.ReadKey();

                    goto Menu;
                    case "3":
                        weapon.Fire();
                    Console.WriteLine("press enter");
                    Console.ReadKey();

                    goto Menu;
                    case "2":
                        weapon.PullTrigger();
                    Console.WriteLine("press enter");
                    Console.ReadKey();

                    goto Menu;
                    default:
                        Console.WriteLine("Invalid input");
                    Console.WriteLine("press enter");
                    Console.ReadKey();

                    goto Menu;
                }
            
        }
    }
}
