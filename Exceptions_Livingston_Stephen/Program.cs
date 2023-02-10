using System;

namespace Exceptions_Livingston_Stephen
{
    class Program
    {   /// <summary>
    /// Asks the user for a number other than zero and returns a random number to determin if user is older than or equal to 17.
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            float myFloat = 28.4f;
            float myOtherFloat = 0.0f;
            float result = 0f;

            Random r = new Random();
            int myInt = r.Next(2, 30);

            try
            {
                result = Divide(myFloat, myOtherFloat);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please add a number other than zero");
                myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());
                
                try
                {
                    result = Divide(myFloat, myOtherFloat);
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e2.Message);
                }
               
            }
            finally
            {
                Console.WriteLine("Calculations comepleted, with results of " + result);
            }
            try
            {
                CheckAge(myInt);
            }
            catch
            {
                Console.WriteLine($"You are {myInt}, you are not old enough!");
            }
        }
        /// <summary>
        /// Divides x, and y if y is not equal to 0.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static float Divide(float x , float y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
              return  x / y;
            }
        }
        /// <summary>
        /// If age is equal to or greater than 17 prints to the user that you can play mature games.
        /// </summary>
        /// <param name="age"></param>
        static void CheckAge(int age)
        {
            if (age >= 17)
            {
                Console.WriteLine($"You are {age}, you can play mature games!");
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
