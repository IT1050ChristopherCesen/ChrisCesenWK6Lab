using System;

namespace ChrisCesenWK6Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Question 1A one-dimensional array p contains four elements.  
             * The array access expressions to access each of the elements in p 
             *  Console.WriteLine(p [0]); Console.WriteLine(p [1]; ,Console.WriteLine(p [2]) and Console.WriteLine(p [3])


             */



            /*
            /* Question 2
            string[] monthOfYear = { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            for (int i = 0; i < monthOfYear.Length; i++)

            Console.WriteLine(monthOfYear[i]);
            */

            /* Question 3
            Create a 4-element array to store the names of 4 seasons.  Use a foreach loop to display the name of each season. (4 points)
            */
            /*
            string[] seasonOfYear = { "Winter", "Spring", "Summer", "Fall" };
            foreach (string season in seasonOfYear)
         
                Console.WriteLine(season);
                */

            /*Question 4
             * Create an array of integers with 1000 elements.  Fill the array with random numbers.  Use a foreach loop to print all integers in the array (4 points).
Random random = new Random();
int randomNumber
randomNumber = random.Next(0, 100); 
             
             */

            int[] elements = new int[1000];
            Random random = new Random();
            int randomNumber;
            foreach (int element in elements)
            {

                randomNumber = random.Next(0, 100);
                Console.WriteLine(randomNumber);
            }

            /*Question 5

          Paste the following code into the main() method.  
          Modify the code; so that it works (You’ll have to make 2 small modifications).  It should output the value of each string in the array called names (2 points).

          

            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i = 0;
            while (i < names.Length)
            {
                Console.WriteLine(names[i++]);
            }
            */

            /*Question 6
                Console.WriteLine("{0,2}. {1}", i, names[i]);

             */

            /*  string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

              int i = 0;
              while (i < names.Length)
              {
                  Console.Write(i + " ", 1);
                  Console.WriteLine(names[i++]);
              }
              */


            /* string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

             int i = 0;
             while (i < names.Length)
             {
                 Console.WriteLine(i++);
                 Console.WriteLine("{0,2}. {1}", i, names[i]);
                 //Console.WriteLine(names[i++]);
             }
             */


            //Question 7 

            
            

            /*
            int i = 0;
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            foreach (string name in names)
            {
                
                //Console.WriteLine(i++);
                //Console.WriteLine(name);
                Console.WriteLine("{0,2}. {1}", i, names[i++]);
            }
            */


        }
    }
}

