namespace GenericScale
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var scale1 = new EqualityScale<int>(5, 10);
            Console.WriteLine(scale1.GetHeavier());

            var scale2 = new EqualityScale<string>("Man", "Woman");
            Console.WriteLine(scale2.GetHeavier());
        }
    }
}