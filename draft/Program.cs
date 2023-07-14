// See https://aka.ms/new-console-template for more information

namespace Draft
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Amber leshea"; //plaintext data variable
            int characterAge = 28;
            char grade = 'A';
            bool isAuth = true;

            //boolean is true or false value and can be used by creating bool variable

            // int characterAge;
            //charcaterAge = 28, this is another syntax to declare a variable
         

            Console.WriteLine("My name is \n" + characterName.ToUpper() );
            Console.WriteLine(" I am " + characterAge + "years old"); //this is concatinating a string
            Console.WriteLine("I like being " + characterName[3].ToUpper() );
            Console.WriteLine("Being " + characterAge + " is fine i guess");

            Console.ReadLine();
        }
    }
}

