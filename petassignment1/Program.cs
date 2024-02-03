using System.Reflection.Metadata;
using System.Xml.Linq;

namespace petassignment1
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            // Declaration for variable 
            int Healthy = 5;
            int Hungry = 6;
            int Happy = 7;

            //Selection for Petanimals
            Console.WriteLine("Select Type of Pet");
            Console.WriteLine("1.Dog");
            Console.WriteLine("2.Cat");
            Console.WriteLine("3.Rabbit\n");
            Console.Write("Input User:");

            //Name the Pet
            int pettype = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nName your pet?");
            Console.WriteLine("Input User: ");
            string petname = Console.ReadLine();

            Console.WriteLine($"\nTakeCare {petname}");
            while (true)
            {
                //List of Menu
                Console.WriteLine("\nList of Main Menu");
                Console.WriteLine("1.Feed Your Pet");
                Console.WriteLine("2.Play with Your Pet");
                Console.WriteLine("3.Rest Your Pet");
                Console.WriteLine("4.Check");
                Console.WriteLine("5.Exit");

                Console.Write("Input User: ");
                int care = Convert.ToInt32(Console.ReadLine());
                switch (care)
                {
                    case 1:
                        Hungry = Hungry - 2; //Less Hungry
                        Healthy = Healthy + 1; //More Healthy
                        Console.WriteLine("Less hungry , Slighty incresed their health");
                        break;
                   case 2:
                        Hungry = Hungry +1; //More Hungry
                        Happy = Happy  + 1; //More Happy
                        Console.WriteLine("More Happy, Slighty incresed their Food");
                        break;
                    case 3:
                        Healthy = Healthy -2; //Less Healthy
                        Happy = Happy  -1; //Less Happy
                        Console.WriteLine("Expanding Health,Slightly Decrease Happiness");
                        break;
                     case 4:
                        Console.WriteLine("Status for PetAnimals");
                        Console.WriteLine("Healthy :" + Convert.ToString(Healthy));
                        Console.WriteLine("Hungry :" + Convert.ToString(Hungry));
                        Console.WriteLine("Happy :" + Convert.ToString(Happy));

                        if
                            (Healthy <= 2 || Hungry <= 2 || Happy <= 2)
                        {
                            Console.WriteLine("Your Pet Health is in Risk");
                        }
                        break;
                      case 5:
                        Console.WriteLine("See Yaa!");
                        return;
                    default:
                        Console.WriteLine("Options are not Valid");
                        break;
                }
                //Time-Based 
                Hungry = Hungry + 1;
                Happy = Happy - 1;
                if
                    (Healthy <= 2 || Hungry <= 2 || Happy <= 2)
                    Console.WriteLine("Ohh! Your Pet health is in Risk");
                }
            }
        }
    }

