using System;

namespace Choose_Your_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string noiseChoice;
            string loudNoiseChoice;
            string doorChoice;
            string loudDoorChoice;
            string riddleAnswer;
            string loudRiddleAnswer;
            string keyChoice;
            string loudKeyChoice;
            
            Console.Write("What is your name?: ");
            userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! Welcome to our story.\t");


            Console.WriteLine("It beings on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?\n");
            Console.Write("Type YES or NO\n");

            noiseChoice = Console.ReadLine();
            loudNoiseChoice = noiseChoice.ToUpper();

            Console.WriteLine();

            if (loudNoiseChoice == "NO")
            {
                Console.WriteLine("You're really just not gonna do anything in an adventure game?");
                Console.WriteLine("GAME OVER");
                return;

            }

            else if (loudNoiseChoice == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.");
                Console.WriteLine("You walk towards it. Do you open it or knock?");
            }

            Console.WriteLine("Type OPEN or KNOCK\n");
            doorChoice = Console.ReadLine();
            loudDoorChoice = doorChoice.ToUpper();

            Console.WriteLine(loudDoorChoice);

            if (loudDoorChoice == "KNOCK")
            {
                Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle:\"");
                Console.WriteLine("\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
                Console.Write("Type your answer: ");
                riddleAnswer = Console.ReadLine();
                loudRiddleAnswer = riddleAnswer.ToUpper();

                if (loudRiddleAnswer == "NOTHING")
                {
                    Console.WriteLine("Corerct answer!");
                    Console.WriteLine("The door opens and NOTHING is there.");
                    Console.WriteLine("You turn off the light and run back to your room and lock the door.");
                    Console.WriteLine("GAME OVER");
                }

                else if (loudRiddleAnswer != "NOTHING")
                {
                    Console.WriteLine("You answered incorrectly. The door doesn't open.");
                    Console.WriteLine("THE END");
                }

            }

            else if (loudDoorChoice == "OPEN")
            {
                Console.WriteLine("The door is unlocked!");
                Console.WriteLine("See if you one of your three keys will open it");
                Console.WriteLine("Type: Key 1, Key 2, or Key 3 to use one of the keys");
                keyChoice = Console.ReadLine();
                loudKeyChoice = keyChoice.ToUpper();

                switch (loudKeyChoice)
                {
                    case "KEY 1":
                        Console.WriteLine("You choose the first key. Lucky choice!");
                        Console.WriteLine("The door opens and NOTHING is there. Strange...");
                        Console.WriteLine("THE END.");
                        break;

                    case "KEY 2":
                        Console.WriteLine("You chose the second key. The door doesn't open.");
                        Console.WriteLine("THE END.");
                        break;

                    case "KEY 3":
                        Console.WriteLine("You choose the third key. The door doesn't open.");
                        Console.WriteLine("THE END.");
                        break;

                        
                }
            }

        }

        }
    }

