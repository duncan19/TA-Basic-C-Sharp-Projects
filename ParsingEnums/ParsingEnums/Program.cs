using System;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week");
            string userDay = Console.ReadLine();
            //DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userDay);
            //if ()
            //{
            //    Console.WriteLine("");
            //}

            DaysOfTheWeek day;
            try
            {
                day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userDay);
                Console.WriteLine("You said today was " +userDay);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please put an actual day of the week");
                Console.WriteLine(ex.Message);

                day = DaysOfTheWeek.None;
            }
          


        }
        public enum DaysOfTheWeek
        {
            None,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
