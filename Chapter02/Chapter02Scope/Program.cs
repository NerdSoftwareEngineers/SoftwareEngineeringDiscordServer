namespace Chapter02Scope
{
    internal class Program
    {
        static string myString = "global"; //white
        static void Main(string[] args)
        {
            string myString2 = "local";  //blue
            Console.WriteLine("Hello, World!");
        }

        void localV()
        {
            string myString3 = "local";  //blue
        }
    }

}
