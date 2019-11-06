using System;
namespace Methods
{
    public class Methods
    {
        public Methods()
        {
            Console.WriteLine("Welcome to the party");
            Normal(3);
            Named(3);
            Optional(5);
            Optional(5, "loo");

            // THIS FUNCTION IS BEING USED WITH OPTIONAL AND NAMED
            Optional(b: "loo", a: 3);
        }
        //Normal Function
        void Normal(int a)
        {
            Console.WriteLine(a);
        }
        //Named Paramaters
        void Named(float a)
        {
            Console.WriteLine((int)a);
        }
        //Optional Parameters
        void Optional(int a, string b = "woo")
        {
            Console.WriteLine(a + b);
        }
    }
}
