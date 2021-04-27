using System;

namespace ToolBoxDemo 
{
    class Program
    {
        //acts as our program's .exe file, aka "executable or entry point" this is the file we double click on to start any program.
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Your Tool Box!");
            Console.WriteLine("You can either hit\"Y\" then ENTER to Continue, or hit \"N\" then ENTER to Clear the Console and Continue.");

            string userResponse = Console.ReadLine();
            if(userResponse == "Y")
            {
                KeyToContinue();
            }
            else if(userResponse == "N")
            {
                KeyToContinueWithClearConsole();
            }
            else
            {
                Console.WriteLine("Not sure friend, but I'm gonna close the program when you hit ENTER");
            }

            Console.ReadLine();










            //Functions below this line
            void KeyToContinue()
            {
            Console.WriteLine("Hit ENTER Clear the Console and continue on with the code...");
            Console.ReadLine();

            }
             void ClearConsole()
            {
            Console.Clear();
            }

            void KeyToContinueWithClearConsole();
        }
    }
}
