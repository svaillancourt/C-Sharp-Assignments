using System;
using System.Linq; //To use Linq methods on our arrays
using System.IO; //To read from files

// citation https://stackoverflow.com/questions/34035463/looping-through-a-menu-items-in-c-sharp

namespace myApp
{
    class Program
    {
        static void myOption1Output(string myFileName) //Method which accepts two parameters and returns void
        {
            string textContent = File.ReadAllText(myFileName);
            Console.WriteLine(textContent);
        }
        static void Main(string[] args)
        {
            int num;
            string userChoice;

            do
            {
                Console.WriteLine("Choose a number that correspond to what you'd like to do: ");
                Console.WriteLine("1: Create a filename. The filename will be stored in a local variable");
                Console.WriteLine("2: Replace a string within filename");
                Console.WriteLine("3: Quit");
                Console.Write("Enter the number of your choice: ");
                userChoice = Console.ReadLine();

                if (!Int32.TryParse(userChoice, out num)) continue;

                if (userChoice == "3")
                {
                    Environment.Exit(0);
                }

                Console.WriteLine("Choice = " + userChoice);

                if (userChoice == "1")
                {
                    // (Option 1) 

                    // User Inputs (will prompt the user to enter a filename. The filename will be stored in a local variable).

                    Console.WriteLine("Enter a file name and file extension(.txt): ");
                    // prompt not necessary, but helps with user understanding
                    string myFileName = Console.ReadLine();

                    //creates file if it exists and adds content to it, overwrites file content if file exists
                    File.WriteAllText(myFileName,
                    @"Lyrics
-----------------
Song: Redbone 
Artist: Donald Glover

Daylight
I wake up feeling like you won't play right
I used to know, but now that shit don't feel right
It made me put away my pride
So long
You made a nigga wait for some, so long
You make it hard for boy like that to go on
I'm wishing I could make this mine, oh
If you want it, yeah
You can have it, oh, oh, oh
If you need it, ooh
We can make it, oh
If you want it
You can have it
But stay woke
Niggas creepin'
They gon' find you
Gon' catch you sleepin' (oh)
Now stay woke
Niggas creepin'
Now don't you close your eyes
Too late
You wanna make it right, but now it's too late
My peanut butter chocolate cake with Kool-Aid
I'm trying not to waste my time
If you want it, oh
You can have it (you can have it)
If you need it (you better believe in something)
We can make it, oh
If… ");

                    // Output the content within the file
                    string textContent = File.ReadAllText(myFileName);
                    Console.WriteLine(textContent);

                    Console.WriteLine("\nPress enter to go to back to the main menu");
                    // prompt not necessary, but helps with user understanding
                    string myReturnToMenu = Console.ReadLine();
                }

                if (userChoice == "2")
                {
                    // (Option 2) 

                    //Replacement part (will prompt the user to enter a string. It will then go through the file specified by option 1 and replace any sequences of the user entered string with a blank space.)

                    // example
                    // String str = "1 2 3 4 5 6 7 8 9";
                    // Console.WriteLine("Original string: \"{0}\"", str);
                    // Console.WriteLine("CSV string:      \"{0}\"", str.Replace(' ', ','));

                    // This example produces the following output:
                    // Original string: "1 2 3 4 5 6 7 8 9"
                    // CSV string:      "1,2,3,4,5,6,7,8,9"

                    Console.WriteLine("Prompt: Please a string you like to replace: "); //prompt not necessary, but helps with user understanding
                    string replacement = Console.ReadLine();

                    // Output the content within the file
                    string textContent = File.ReadAllText(myFileName);
                    Console.WriteLine(textContent);

                    // this shows your content
                    String initialString = textContent;
                    Console.WriteLine("The initial string:\n\n{0}", initialString);

                    // spacing
                    Console.WriteLine("\n----------");
                    Console.WriteLine("----------\n");

                    // replace that the user request
                    initialString = initialString.Replace(replacement, " ");

                    Console.WriteLine("Every '" + replacement + "' will be replaced with a blank space! \nHere are the results \n{0}\n", initialString);
                }

            } while (true);
        }
    }
}
