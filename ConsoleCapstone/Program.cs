//title info and version
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Dan's Bag-o-tricks Version 0.1");
Console.WriteLine("Created by the Dev 101 C# Class");
Console.WriteLine("");
Console.WriteLine("");

Console.ForegroundColor = ConsoleColor.DarkMagenta;

//game logo
Console.WriteLine(".             .");
Console.WriteLine("..           ..");
Console.WriteLine("...         ...");
Console.WriteLine("....       ....");
Console.WriteLine(".....     .....");
Console.WriteLine("......   ......");
Console.WriteLine("...............");
Console.WriteLine("...............");
Console.WriteLine("...XX......XX..");
Console.WriteLine("...XX......XX..");
Console.WriteLine(".......xx......");
Console.WriteLine("...xx......xx..");
Console.WriteLine("....xxxxxxxx...");
Console.WriteLine("...............");

Console.WriteLine("");
Console.WriteLine("");

Console.ForegroundColor = ConsoleColor.White;
//start the game
Console.WriteLine("Pet the kitty?");
var petTheKitty = Console.ReadLine();

Console.WriteLine("");
Console.WriteLine("");

Console.ForegroundColor = ConsoleColor.Magenta;
//intro
Console.WriteLine("Hello Human.");
Console.WriteLine("My name is Dan and I have a Bag-O-Tricks.");

Console.WriteLine("");
Console.WriteLine("I have many tricks in my bag.");
Console.WriteLine("Choose one and maybe I will show it to you....");
Console.WriteLine("Well... are you ready?!?!");
Console.WriteLine("");

//open the bag
Console.ForegroundColor = ConsoleColor.White;

var openTheBag = Console.ReadLine();
var playingTheGame = true;

while (playingTheGame)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("");
    Console.WriteLine("Easy with my big bag!!!");
    Console.WriteLine("Choose one item at a time. Dont be Greedy!!!");
    Console.WriteLine("");

    //setup the tricks

    var tricks = new List<string>
{
    "1: Cuthulu's Reign",
    "2: Garrion's Game",
    "3: Leon's Game",
    "4: Kyle's Game",
    "5: Neebles's Game",
    "6: Rachel's Game",
    "7: Aaron's Game",
    "8: Cali's Game",
    "9: Thermonuclear War"
};

    //list the tricks

    foreach (var trick in tricks)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(trick);
    }

    Console.ForegroundColor = ConsoleColor.Magenta;

    Console.WriteLine("");
    Console.WriteLine("Ok Human.... what do you want to play?");
    Console.WriteLine("");

    var selectedTrick = Console.ReadLine();
    SelectedGame selectedGame;

    switch (selectedTrick)
    {
        case "1":
            selectedGame = SelectedGame.CuthulusReign;
            PlayCuthulusReign();
            break;
        case "2":
            selectedGame = SelectedGame.Garrion;
            break;
        case "3":
            selectedGame = SelectedGame.Leon;
            break;
        case "4":
            selectedGame = SelectedGame.Kyle;
            break;
        case "5":
            selectedGame = SelectedGame.Neebles;
            break;
        case "6":
            selectedGame = SelectedGame.Rachel;
            break;
        case "7":
            selectedGame = SelectedGame.Aaron;
            break;
        case "8":
            selectedGame = SelectedGame.Cali;
            break;
        case "9":
            selectedGame = SelectedGame.War;
            PlayWar();
            break;
        default:
            break;
    }

    Console.WriteLine("");
    Console.WriteLine("Now that was a ton of fun right there..");
    Console.WriteLine("Do you want to try another trick?");
    Console.WriteLine("");

    var playAgain = Console.ReadLine();
    Console.WriteLine("");

    if (playAgain != null)
    {
        if (playAgain.Substring(0, 1).ToLower() == "y")
        {
            //play again
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("really?!?! Whatever...");
            Console.WriteLine("well get lost then!");
            Console.WriteLine("");

            playingTheGame = false;
        }
    }
}
void PlayCuthulusReign()
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Mysterygames V1");
    Console.WriteLine("Created by: Mariam Webber");
    Console.WriteLine("");
    Console.WriteLine("");

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("Welcome to the Lovecraftian Mystery");
    Console.WriteLine("Would you like to start with your story?");
    Console.WriteLine("");

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    var Wouldyouliketostart = Console.ReadLine();

    var gameOn = true;

    while (gameOn)

    {
        static void Main(string[] args)
        {
            bool playAgain;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("You find yourself in the small coastal town of Innsmouth.");
                Console.WriteLine("The town's unsettling reputation for strange occurrences and eerie disappearances ");
                Console.WriteLine("has drawn you here. As night falls, you feel a deep sense of foreboding.");

                string choice;

                // Beginning of the story
                Console.WriteLine("\nYou stand at a crossroads. There are two paths before you:");
                Console.WriteLine("1. Follow the narrow, dimly lit alleyway.");
                Console.WriteLine("2. Knock on the door of the old, decrepit mansion nearby.");

                choice = GetUserChoice("Enter your choice (1/2): ");

                if (choice == "1")
                {
                    // Explore the alleyway
                    Console.WriteLine("\nYou venture into the dark alleyway. The shadows seem to writhe and move.");
                    Console.WriteLine("As you walk deeper, you stumble upon a cryptic symbol on the ground.");

                    choice = GetUserChoice("1. Investigate the symbol. \n2. Leave the alleyway. \n3. Call out for help.");

                    if (choice == "1")
                    {
                        Console.WriteLine("\nYou kneel to examine the symbol. It's a sigil of some ancient, unknown cult.");
                        Console.WriteLine("As you touch it, you feel a sudden chill and a presence lurking nearby.");
                        Console.WriteLine("Suddenly, tentacles emerge from the shadows, and you are pulled into the darkness.");
                        Console.WriteLine("You have become one with the cosmic horror. The end.");
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("\nYou wisely choose to leave the eerie alleyway behind.");
                        Console.WriteLine("As you retreat, you hear strange whispers fading into the night.");
                        Console.WriteLine("You continue your exploration of Innsmouth.");
                    }
                    else
                    {
                        Console.WriteLine("\nYou call out for help, but your voice seems to be swallowed by the oppressive darkness.");
                        Console.WriteLine("No one responds, and the eerie silence grows more unsettling.");
                        Console.WriteLine("You decide to leave the alleyway.");
                    }
                }
                else
                {
                    // Knock on the mansion's door
                    Console.WriteLine("\nYou decide to knock on the door of the old mansion.");
                    Console.WriteLine("After a few moments, an elderly woman with a sinister smile answers.");
                    Console.WriteLine("She invites you inside and offers a cup of tea. Do you accept?");
                    Console.WriteLine("1. Accept the tea.");
                    Console.WriteLine("2. Politely decline and ask about the town's history.");
                    Console.WriteLine("3. Ask about the woman's name.");

                    choice = GetUserChoice("Enter your choice (1/2/3): ");

                    if (choice == "1")
                    {
                        // Accept the tea
                        Console.WriteLine("\nYou accept the tea, but as you take a sip, you feel your vision blur.");
                        Console.WriteLine("You realize too late that it was laced with a strange substance.");
                        Console.WriteLine("You fade into unconsciousness, never to awaken again.");
                        Console.WriteLine("Your journey ends here.");
                    }
                    else if (choice == "2")
                    {
                        // Ask about the town's history
                        Console.WriteLine("\nYou politely decline the tea and engage the woman in conversation.");
                        Console.WriteLine("She tells you about Innsmouth's dark history and the secrets that lie beneath.");
                        Console.WriteLine("She offers to guide you to a hidden library where you might find answers.");
                        Console.WriteLine("Do you accept her offer?");
                        Console.WriteLine("1. Accept the offer.");
                        Console.WriteLine("2. Refuse and leave the mansion.");
                        Console.WriteLine("3. Ask about the woman's name.");

                        choice = GetUserChoice("Enter your choice (1/2/3): ");

                        if (choice == "1")
                        {
                            // Accept the offer to the library
                            Console.WriteLine("\nYou accept her offer and follow her to the hidden library.");
                            Console.WriteLine("The books are filled with forbidden knowledge of cosmic horrors and ancient rituals.");
                            Console.WriteLine("As you delve deeper into the texts, your sanity begins to unravel.");
                            Console.WriteLine("You have discovered too much, and the price is your sanity. The end.");
                        }
                        else if (choice == "2")
                        {
                            // Refuse and leave the mansion
                            Console.WriteLine("\nYou thank the woman for her information and leave the mansion.");
                            Console.WriteLine("The night in Innsmouth is dark, and the mysteries of the town remain unsolved.");
                            Console.WriteLine("You continue your journey, forever haunted by the enigmatic encounter.");
                            Console.WriteLine("Your adventure continues...");
                        }
                        else
                        {
                            // Ask about the woman's name
                            Console.WriteLine("\nYou inquire about the woman's name.");
                            Console.WriteLine("She hesitates for a moment and then whispers, 'I am Nyarlathotep.'");
                            Console.WriteLine("You feel a sudden dread as the name echoes in your mind.");
                            Console.WriteLine("You realize you are in the presence of an ancient and malevolent entity.");
                            Console.WriteLine("Your fate is sealed, and your journey ends in madness.");
                        }
                    }
                    else
                    {
                        // Ask about the woman's name
                        Console.WriteLine("\nYou inquire about the woman's name.");
                        Console.WriteLine("She hesitates for a moment and then whispers, 'I am Nyarlathotep.'");
                        Console.WriteLine("You feel a sudden dread as the name echoes in your mind.");
                        Console.WriteLine("You realize you are in the presence of an ancient and malevolent entity.");
                        Console.WriteLine("Do you choose to attack?");
                        Console.WriteLine("1. Attack the entity.");
                        Console.WriteLine("2. Try to escape.");

                        choice = GetUserChoice("Enter your choice (1/2): ");

                        if (choice == "1")
                        {
                            // Attack the entity
                            Console.WriteLine("\nYou attempt to attack the entity, but before you can react,");
                            Console.WriteLine("Nyarlathotep's otherworldly power engulfs you.");
                            Console.WriteLine("In an instant, your existence is erased, and you become a mere memory.");
                            Console.WriteLine("The entity remains unscathed. Your journey ends in oblivion.");
                        }
                        else
                        {
                            // Try to escape
                            Console.WriteLine("\nYou wisely choose to try to escape from the entity.");
                            Console.WriteLine("With all your strength, you make a hasty retreat from the mansion.");
                            Console.WriteLine("The night in Innsmouth is dark, and the mysteries of the town remain unsolved.");
                            Console.WriteLine("You continue your journey, forever haunted by the enigmatic encounter.");
                            Console.WriteLine("Your adventure continues...");
                        }
                    }
                }

                Console.WriteLine("Would you like to try again?");
                Console.WriteLine("Press 'R' to try again or 'X' to exit.");
                choice = Console.ReadLine();
                playAgain = choice.Trim().ToUpper() == "R";
            } while (playAgain);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static string GetUserChoice(string prompt)
        {
            string choice;
            do
            {
                Console.Write(prompt);
                choice = Console.ReadLine().Trim();
            } while (choice != "1" && choice != "2" && choice != "3");
            return choice;
        }
    }
}




void PlayWar()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("WarGames Version 0.1");
    Console.WriteLine("Created by: Robert Nellinger");
    Console.WriteLine("");
    Console.WriteLine("");

    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("My name is Joshua.");
    Console.WriteLine("Would you like to play a game.");
    Console.WriteLine("");

    Console.ForegroundColor = ConsoleColor.White;
    var wouldYouLikeToPlay = Console.ReadLine();

    var gameOn = true;

    while (gameOn)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("");
        Console.WriteLine("List of Games");
        Console.WriteLine("-------------");
        Console.WriteLine("1: Chess");
        Console.WriteLine("2: Tic-Tac-Toe");
        Console.WriteLine("3: Thermonuclear War");
        Console.WriteLine("4: Exit");
        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.White;
        var gameSelection = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Gray;

        if (gameSelection == "3")
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("As you wish...");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("You stand on the precipice of uncertainty, your gaze fixed on the giant steel doors that guard the heart of NORAD.");
            Console.WriteLine("");
            Console.WriteLine("Inside the bunker, the fluorescent lights hum, casting a sterile glow on the bustling operations center. Men and women in uniform move with purpose, their faces a mix of determination and anxiety. This was the culmination of years of preparation, of drills, of imagining this very moment. The all-out thermonuclear war they had trained for was no longer an exercise in theory. It was upon them.");
            Console.WriteLine("");
            Console.WriteLine("Your weathered hands trace the surface of the polished mahogany desk in your office. You inherited the command of this bunker from a long line of leaders who had stood watch through the darkest hours of history. Now, it is your turn.");
            Console.WriteLine("");
            Console.WriteLine("Your seasoned eyes fall upon a faded photograph on the wall - family, smiling and carefree, taken on a distant summer day. You take a moment to breathe in the memory, knowing that it might be your last. As the sirens wail, a shiver ran down your spine. The world outside is descending into chaos. The geopolitical tensions that had simmered for decades had finally erupted into a nuclear inferno. The fate of millions hang in the balance.");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Do you press the button?");

            var button = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("");
            Console.WriteLine("EVERYONE DIES!!!!");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            if (gameSelection == "4")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Funny...");
                Console.WriteLine("The only way to win is not to play.");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Goodbye...");
                Console.WriteLine("");

                gameOn = false;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("I'm sorry... that game is currently unavailable");
                Console.WriteLine("Perhaps a game of Thermonuclear War?");
                Console.WriteLine("");
            }
        }
    }
}

public enum SelectedGame
{
    CuthulusReign,
    Garrion,
    Leon,
    Kyle,
    Neebles,
    Rachel,
    Cali,
    Aaron,
    War
}