/* Write an application that allows the user to input monthly rainfall amounts for one year storing the values in an array. 
 * Create a second array that holds the names of the month. 
 * Produce a report showing the month name along with the rainfall amount and its variance from the mean. 
 * Calculate and display the average rainfall for the year*/


using System;

namespace QUESTION1_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double totalRain = 0;
            int[] rainM = new int[12];
            string [] month = new string[] { "January", "February", "March", "April", "May","June", "July", 
               "August", "September","October", "November", "December"};

            for (int i = 0; i < 12; i++ )
            {
                Console.WriteLine(" Enter the amount of rainfall in cm for " + month[i] + " (it needs to be a integer ):");
                rainM[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i <12; i++)
            {
                totalRain += rainM[i];
            }

            for (int i = 0; i <12; i++)
            {
                Console.WriteLine("Month: " + month[i] + " RainFall: " + rainM[i] + "cm");
            }
            
            Console.WriteLine("The total amount of rainfall in the year was: " + totalRain/12 + " cm" );
        }
    }
}
