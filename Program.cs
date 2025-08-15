using System.ComponentModel;
using System.Security;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q_1
            // Create an Enum called "WeekDays" with the days of the week ‎‎(Monday to Sunday) as its members.
            // Then, write a C# program that ‎prints out all the days of the week using this Enum.‎

            //sol
            //Console.WriteLine("Days Of Week \n -------------");
            //foreach (var day in Enum.GetValues(typeof(WeekDays)))
            //{
            //Console.WriteLine($"  {day}");
            //}



            #endregion

            #region Q_2
            //Create an Enum called "Season" with the four seasons
            //(Spring, ‎Summer, Autumn, Winter) as its members.
            //Write a C# program that ‎takes a season name as input from the user
            //and displays the ‎corresponding month range for that season.
            //Note range for seasons ( ‎spring march to may, summer june to august ,
            //autumn September to ‎November , winter December to February)‎



            //sol


            //Season Season ;
            //bool Check;
            //do
            //{
            //    Console.WriteLine("Enter Season Name");
            //    Check = Enum.TryParse(Console.ReadLine(), out Season);

            //}while (!Check);

            //switch (Season)
            //{
            //    case Season.Spring:
            //        Console.WriteLine("This Season from March To May");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("This Season from June To August");
            //        break;
            //    case Season.Autumn:
            //        Console.WriteLine("This Season from September To November");
            //        break;
            //    case Season.Winter:
            //        Console.WriteLine("This Season from December  To February");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Season");
            //        break;
            //}


            #endregion

            #region Q_3
            //Assign the following Permissions (Read, write, Delete, Execute) in a ‎form of Enum .‎
            // Create Variable from previous Enum to Add and Remove ‎Permission from variable,
            // check if specific Permission existed ‎inside variable



            //sol

            //Permissions Mpr = new Permissions();
            //Mpr ^= Permissions.Write;
            //Mpr ^= Permissions.Read;
            //Mpr |= Permissions.Delete;
            //if ((Mpr & Permissions.Delete) == Permissions.Delete)
            //{
            //Console.WriteLine("Permission Delete Is Existed");
            //Console.WriteLine($"Existed Permissions are ( {Mpr} )");
            //}
            //else
            //{
            //Console.WriteLine("Permission Delete Is Not Existed");
            //Console.WriteLine($"Existed Permissions are ( {Mpr} )");
            //}
            #endregion

            #region Q_4
            // Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
            // Write a C# program that takes a color name as ‎input from the user and
            // displays a message indicating whether the ‎input color is a primary color or not.‎


            //sol


            //bool Check;
            //Colors color;
            //do
            //{
            //Console.WriteLine("Enter The Color");
            //Check = Enum.TryParse(Console.ReadLine(), out color);
            //}while (!Check);

            //string Massage = color switch
            //{
            //Colors.Red => "Is Prim color",
            //Colors.Blue => "Is Prim color",
            //Colors.Green => "Is Prim color",
            //_ => "NOt Prime Color"
            //};
            //Console.WriteLine(Massage);

            #endregion


        }
    }
}
