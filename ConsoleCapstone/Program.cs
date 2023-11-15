//title info and version
using System;

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
    "2: Ship Shape",
	"3: Leon's Game",
	"4: Big Wallet Gangstas",
	"5: Neebles's Game",
	"6: Rachel's Game",
	"7: Aaron's BlackJack Game",
	"8: Tic Tac Toe",
	"9: Thermonuclear War",
    "10: Whack-A-Nerd"
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
			selectedGame = SelectedGame.ShipShape;
            PlayShipShape();
			break;
		case "3":
			selectedGame = SelectedGame.Leon;
			break;
		case "4":
			selectedGame = SelectedGame.Kyle;
			PlayBigWalletGangstas();
			break;
		case "5":
			selectedGame = SelectedGame.Neebles;
			break;
		case "6":
			selectedGame = SelectedGame.Rachel;
			break;
		case "7":
			selectedGame = SelectedGame.Aaron;
            playBlackJackGame();
			break;
		case "8":
			selectedGame = SelectedGame.Cali;
			PlayTicTacToe();
            break;
		case "9":
			selectedGame = SelectedGame.War;
			PlayWar();
			break;
        case "10":
            selectedGame = SelectedGame.Cali2;
            PlayWhackANerd();
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
        Console.WriteLine("Welcome to the Lovecraftian Mystery Adventure!");
        Console.WriteLine("------------------------------------------------");
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
        Console.WriteLine("Would you like to try again? Press R to Retry or X to Exit");
        choice = Console.ReadLine().ToLower();
        if (choice == "x") {
            gameOn = false;
        }  
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


// Aaron - there was an issue with unneeded { } in here. I deleted and application ran.

void PlayShipShape()
{
    Console.WriteLine("Welcome, Pirate!");
    Console.WriteLine("You've been marooned on a deserted island.");
    Console.WriteLine("Your ship, the Black Pearl, is missing.");
    Console.WriteLine("Your goal is to find your ship and set sail again.");
    Console.WriteLine("Are you ready to begin your adventure?");
    Console.WriteLine();

    int currentLocation = 0;
    bool hasFoundShip = false;

    while (!hasFoundShip)
    {
        Console.WriteLine("Choose your action:");
        Console.WriteLine("1. Explore the jungle");
        Console.WriteLine("2. Search the beach");
        Console.WriteLine("3. Climb a hill");
        Console.WriteLine("4. Check the shipwreck");
        Console.WriteLine("5. Build a shelter");
        Console.WriteLine("6. Light a signal fire");
        Console.WriteLine("7. Hunt for food");
        Console.WriteLine("8. Examine a mysterious cave");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid input. Please choose a valid option.");
            continue;
        }

        switch (choice)
        {
            case 1:
                Console.WriteLine("You venture into the dense jungle.");
                if (currentLocation == 0)
                {
                    Console.WriteLine("You discover some old tracks.");
                    Console.WriteLine("Do you follow them? (Y/N)");
                    if (Console.ReadLine().Equals("Y", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("You follow the tracks and find your ship!");
                        hasFoundShip = true;
                    }
                    else
                    {
                        Console.WriteLine("You return to the beach.");
                    }
                }
                else
                {
                    Console.WriteLine("You find nothing of interest in the jungle.");
                }
                break;

            case 2:
                Console.WriteLine("You search the beach.");
                if (currentLocation == 0)
                {
                    Console.WriteLine("You find a piece of driftwood.");
                    Console.WriteLine("It has a message carved on it.");
                    Console.WriteLine("It says, 'Look up the hill.'");
                }
                else
                {
                    Console.WriteLine("You find some seashells, but nothing else.");
                }
                break;

            case 3:
                Console.WriteLine("You climb a hill.");
                if (currentLocation == 0)
                {
                    Console.WriteLine("You have a better vantage point.");
                    Console.WriteLine("You spot a glimmer in the distance.");
                    Console.WriteLine("Could it be your ship?");
                    Console.WriteLine("You rush down the hill to investigate.");
                    Console.WriteLine("You see nothing but trees and clouds.");
                    currentLocation = 0;
                }

                break;

            case 4:
                Console.WriteLine("You check the shipwreck.");
                {
                    Console.WriteLine("You find a skeleton.");
                    Console.WriteLine("The skeleton comes alive and attacks!");
                    Console.WriteLine("You reach for your cutlass and realize you lost it somewhere.");
                    Console.WriteLine("You have no choice but to run away.");
                }

                break;

            case 5:
                Console.WriteLine("You decide to build a shelter.");
                {
                    Console.WriteLine("You build a magnificient castle out of sand, leaves and sticks.");
                }

                break;

            case 6:
                Console.WriteLine("You light a signal fire.");
                {
                    Console.WriteLine("You wait for a few hours.");
                    Console.WriteLine("You can't sit around forever, you have a ship to find!");
                }

                break;

            case 7:
                Console.WriteLine("You hunt for food.");
                {
                    Console.WriteLine("You dont find any animals but you do find some coconuts.");
                    Console.WriteLine("You hit some against a rock nearby to open them and eat your fill.");
                    Console.WriteLine("You bury the rest in the ground to grow more coconuts...");
                    Console.WriteLine("You're pretty sure thats how farming works?");
                }

                break;

            case 8:
                Console.WriteLine("You examine a mysterious cave.");
                {
                    Console.WriteLine("You are pretty sure your ship won't be in a cave, look somewhere else!");
                }

                break;


            default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                break;
        }
    }

    Console.WriteLine("Congratulations! You've found your ship, the Black Pearl.");
    Console.WriteLine("You set sail once again, ready for new adventures on the high seas.");
}

void PlayBigWalletGangstas()
{
	Random random = new Random();
	Console.ForegroundColor = ConsoleColor.Green;
	Console.WriteLine("");
	Console.WriteLine("");
	Console.WriteLine("Big Wallet Gangstas v0.1");
	Console.WriteLine("A Williams' Enterprises Production");
	Console.WriteLine("");
	Console.WriteLine("");
	Console.WriteLine("Big Wallet Gangstas");
	WaitForEnter();

	Console.WriteLine("A Williams' Enterprises Production, mutha fuckas!");
	WaitForEnter();

	Console.WriteLine("Welcome to the Gabagoolio Family. As our newest member, you will be expected to be a good earner. You will report here every day and give your tribute to your Lieutenant. Good luck out there. Now get out there and earn us some dough!");
	WaitForEnter();

	List<decimal> moneyList = new List<decimal>();
	decimal total = 0;
	decimal donatedTotal = 0;
	decimal myCash = 0;

	while (true)
	{
		Console.WriteLine("Another beautiful day in Mafia City. Time to make some dough so I can pay my tribute and earn my keep!");
		WaitForEnter();

		Console.WriteLine("How do you want to earn?\n1. Extort local business owner\n2. Mug random sucker on the street\n3. Rob the cannoli store");
		string earningMethod = Console.ReadLine()!;

		if (earningMethod == "1")
		{
			Console.WriteLine("Which business would you like to extort?\n1. Paulie's Liquor Cabinet\n2. Mort's Pharmacy\n3. Vinny's Tires and Auto Repair");
			string businessChoice = Console.ReadLine()!;
			var randomNumber = random.Next(2);
			if (randomNumber == 0)  // Randomly decide success or gun pull
			{
				decimal moneyExtorted = random.Next(1, 11);  // Randomly choose a value between 1 and 10
				Console.WriteLine($"You successfully extorted the business owner for ${moneyExtorted}");
				total += moneyExtorted;
				WaitForEnter();
			}
			else
			{
				Console.WriteLine("The business owner decided to pull out a gun and tell you to leave the store.");
				WaitForEnter();
				Console.WriteLine("What do you do?\n1. Run out the door\n2. Pull out a gun and point it back at them");
				string reaction = Console.ReadLine()!;

				if (reaction == "1")
				{
					Console.WriteLine("Phew! That was a close one! We'll come back tomorrow and teach him a lesson he'll never forget!");
					WaitForEnter();
				}
				else if (reaction == "2")
				{
					Console.WriteLine("The store owner had the drop on you and shot you before you even got your hand on your gun. You were dead before you hit the floor.");
					return;
				}
			}
		}

		Console.WriteLine("Time to head back to the hideout and pay tribute on today's earnings.");
		WaitForEnter();

		Console.WriteLine("Give the money to the Lieutenant? Y or N");
		string decision = Console.ReadLine()!.ToUpper();

		if (decision == "Y")
		{
			Console.WriteLine("How much do you have for tribute?");
			decimal moneyGiven;
			while (!decimal.TryParse(Console.ReadLine(), out moneyGiven))
			{
				Console.WriteLine("Please enter a valid number.");
			}
			if (moneyGiven == 0)
			{
				Console.WriteLine("That's banana ducks! Get outta here and don't come back!");
				WaitForEnter();
				Console.WriteLine("The Don does not look upon you with favor.");
			}
			else
			{
				// Message based on amount
				if (moneyGiven >= 5)
				{
					Console.WriteLine("That's a good day's earnings, kid. Keep it up.");
				}
				else if (moneyGiven >= 1 && moneyGiven <= 4)
				{
					Console.WriteLine("This is pretty low, but it will do for today. Earn more tomorrow!");
				}

				donatedTotal += moneyGiven;

				if (total % 30 == 0)
				{
					Console.WriteLine("The Don appreciates your hard work. Keep it up, kid.");
				}
			}

			Console.WriteLine("Running Total: " + total);
			Console.WriteLine("Dontated Total: " + donatedTotal);
			Console.WriteLine("My Cash: " + myCash);

			WaitForEnter();
		}
		else if (decision == "N")
		{
			Console.WriteLine("You have been shot!");
			return;
		}
	}
}

void PlayTicTacToe()
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    bool closeRequested = false;
    bool playerTurn = true;
    Random random = new();
    char[,] board;

    while (!closeRequested)
    {
        board = new char[3, 3]
        {
        { ' ', ' ', ' ', },
        { ' ', ' ', ' ', },
        { ' ', ' ', ' ', },
        };
        while (!closeRequested)
        {
            if (playerTurn)
            {
                PlayerTurn();
                if (CheckForThree('X'))
                {
                    EndGame("You Win.");
                    break;
                }
            }
            else
            {
                ComputerTurn();
                if (CheckForThree('O'))
                {
                    EndGame("You Lose.");
                    break;
                }
            }
            playerTurn = !playerTurn;
            if (CheckForFullBoard())
            {
                EndGame("Draw.");
                break;
            }
        }
        if (!closeRequested)
        {
            Console.WriteLine();
            Console.WriteLine("Play Again [enter], or quit [escape]?");
        GetInput:
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.Enter: break;
                case ConsoleKey.Escape:
                    closeRequested = true;
                    Console.Clear();
                    break;
                default: goto GetInput;
            }
        }
    }

    void PlayerTurn()
    {
        var (row, column) = (0, 0);
        bool moved = false;
        while (!moved && !closeRequested)
        {
            Console.Clear();
            RenderBoard();
            Console.WriteLine();
            Console.WriteLine("Choose a valid position and press enter.");
            Console.SetCursorPosition(column * 6 + 1, row * 4 + 1);
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.UpArrow: row = row <= 0 ? 2 : row - 1; break;
                case ConsoleKey.DownArrow: row = row >= 2 ? 0 : row + 1; break;
                case ConsoleKey.LeftArrow: column = column <= 0 ? 2 : column - 1; break;
                case ConsoleKey.RightArrow: column = column >= 2 ? 0 : column + 1; break;
                case ConsoleKey.Enter:
                    if (board[row, column] is ' ')
                    {
                        board[row, column] = 'X';
                        moved = true;
                    }
                    break;
                case ConsoleKey.Escape:
                    Console.Clear();
                    closeRequested = true;
                    break;
            }
        }
    }

    void ComputerTurn()
    {
        var possibleMoves = new List<(int X, int Y)>();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] == ' ')
                {
                    possibleMoves.Add((i, j));
                }
            }
        }
        int index = random.Next(0, possibleMoves.Count);
        var (X, Y) = possibleMoves[index];
        board[X, Y] = 'O';
    }

    bool CheckForThree(char c) =>
        board[0, 0] == c && board[1, 0] == c && board[2, 0] == c ||
        board[0, 1] == c && board[1, 1] == c && board[2, 1] == c ||
        board[0, 2] == c && board[1, 2] == c && board[2, 2] == c ||
        board[0, 0] == c && board[0, 1] == c && board[0, 2] == c ||
        board[1, 0] == c && board[1, 1] == c && board[1, 2] == c ||
        board[2, 0] == c && board[2, 1] == c && board[2, 2] == c ||
        board[0, 0] == c && board[1, 1] == c && board[2, 2] == c ||
        board[2, 0] == c && board[1, 1] == c && board[0, 2] == c;

    bool CheckForFullBoard() =>
        board[0, 0] != ' ' && board[1, 0] != ' ' && board[2, 0] != ' ' &&
        board[0, 1] != ' ' && board[1, 1] != ' ' && board[2, 1] != ' ' &&
        board[0, 2] != ' ' && board[1, 2] != ' ' && board[2, 2] != ' ';

    void RenderBoard()
    {
        Console.WriteLine();
        Console.WriteLine($" {board[0, 0]}  ║  {board[0, 1]}  ║  {board[0, 2]}");
        Console.WriteLine("    ║     ║");
        Console.WriteLine(" ═══╬═════╬═══");
        Console.WriteLine("    ║     ║");
        Console.WriteLine($" {board[1, 0]}  ║  {board[1, 1]}  ║  {board[1, 2]}");
        Console.WriteLine("    ║     ║");
        Console.WriteLine(" ═══╬═════╬═══");
        Console.WriteLine("    ║     ║");
        Console.WriteLine($" {board[2, 0]}  ║  {board[2, 1]}  ║  {board[2, 2]}");
    }

    void EndGame(string message)
    {
        Console.Clear();
        RenderBoard();
        Console.WriteLine();
        Console.Write(message);
    }
}

void PlayWhackANerd()
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    string Board =
    @" ╔═══╦═══════╗ ╔═══╦═══════╗ ╔═══╦═══════╗" + '\n' +
    @" ║ 7 ║       ║ ║ 8 ║       ║ ║ 9 ║       ║" + '\n' +
    @" ╚═══╣       ║ ╚═══╣       ║ ╚═══╣       ║" + '\n' +
    @"     ║       ║     ║       ║     ║       ║" + '\n' +
    @"     ║       ║     ║       ║     ║       ║" + '\n' +
    @"     ╚═══════╝     ╚═══════╝     ╚═══════╝" + '\n' +
    @" ╔═══╦═══════╗ ╔═══╦═══════╗ ╔═══╦═══════╗" + '\n' +
    @" ║ 4 ║       ║ ║ 5 ║       ║ ║ 6 ║       ║" + '\n' +
    @" ╚═══╣       ║ ╚═══╣       ║ ╚═══╣       ║" + '\n' +
    @"     ║       ║     ║       ║     ║       ║" + '\n' +
    @"     ║       ║     ║       ║     ║       ║" + '\n' +
    @"     ╚═══════╝     ╚═══════╝     ╚═══════╝" + '\n' +
    @" ╔═══╦═══════╗ ╔═══╦═══════╗ ╔═══╦═══════╗" + '\n' +
    @" ║ 1 ║       ║ ║ 2 ║       ║ ║ 3 ║       ║" + '\n' +
    @" ╚═══╣       ║ ╚═══╣       ║ ╚═══╣       ║" + '\n' +
    @"     ║       ║     ║       ║     ║       ║" + '\n' +
    @"     ║       ║     ║       ║     ║       ║" + '\n' +
    @"     ╚═══════╝     ╚═══════╝     ╚═══════╝";

    string Mole =
        @" ╔══─┐ " + '\n' +
        @" │o-o│ " + '\n' +
        @"┌└───┘┐" + '\n' +
        @"││ N ││";

    string Empty =
        @"       " + '\n' +
        @"       " + '\n' +
        @"       " + '\n' +
        @"       ";

    TimeSpan playTime = TimeSpan.FromSeconds(30);

    if (OperatingSystem.IsWindows())
    {
        Console.WindowWidth = Math.Max(Console.WindowWidth, 50);
        Console.WindowHeight = Math.Max(Console.WindowHeight, 22);
    }

    while (true)
    {
        Console.Clear();
        Console.WriteLine("Whack-A-Nerd");
        Console.WriteLine();
        Console.WriteLine(
            $"You have {(int)playTime.TotalSeconds} seconds to whack as many nerds as you " +
            "can before the timer runs out. Use the number keys 1-9 to whack. Are you ready? ");
        Console.WriteLine();
        Console.WriteLine("Play [enter], or quit [escape]?");
    GetInput:
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.Enter:
                Play();
                break;
            case ConsoleKey.Escape:
                Console.Clear();
                Console.WriteLine("Whack-A-Nerd was closed...");
                return;
                break;
            default: goto GetInput;
        }
    }

    void Play()
    {
        Console.Clear();
        Console.WriteLine("Whack-A-Nerd");
        Console.WriteLine();
        Console.WriteLine(Board);
        DateTime start = DateTime.Now;
        int score = 0;
        Random random = new();
        int moleLocation = random.Next(1, 10);
        Console.CursorVisible = false;
        while (DateTime.Now - start < playTime)
        {
            var (left, top) = Map(moleLocation);
            Console.SetCursorPosition(left, top);
            Render(Mole);
            int selection;
        GetInput:
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1: case ConsoleKey.NumPad1: selection = 1; break;
                case ConsoleKey.D2: case ConsoleKey.NumPad2: selection = 2; break;
                case ConsoleKey.D3: case ConsoleKey.NumPad3: selection = 3; break;
                case ConsoleKey.D4: case ConsoleKey.NumPad4: selection = 4; break;
                case ConsoleKey.D5: case ConsoleKey.NumPad5: selection = 5; break;
                case ConsoleKey.D6: case ConsoleKey.NumPad6: selection = 6; break;
                case ConsoleKey.D7: case ConsoleKey.NumPad7: selection = 7; break;
                case ConsoleKey.D8: case ConsoleKey.NumPad8: selection = 8; break;
                case ConsoleKey.D9: case ConsoleKey.NumPad9: selection = 9; break;
                case ConsoleKey.Escape:
                    Console.Clear();
                    Console.WriteLine("Whack-A-Nerd was closed...");
                    Environment.Exit(0);
                    return;
                default: goto GetInput;
            }
            if (moleLocation == selection)
            {
                score++;
                Console.SetCursorPosition(left, top);
                Render(Empty);
                int newMoleLocation = random.Next(1, 9);
                moleLocation = newMoleLocation >= moleLocation ? newMoleLocation + 1 : newMoleLocation;
            }
        }
        Console.CursorVisible = true;
        Console.Clear();
        Console.WriteLine("Whack-A-Nerd");
        Console.WriteLine();
        Console.WriteLine(Board);
        Console.WriteLine();
        Console.WriteLine("Game Over. Score: " + score);
        Console.WriteLine("Hopefully those nerds will learn their lesson and find a girlfriend!");
        Console.WriteLine();
        Console.WriteLine("Press [Enter] To Continue...");
        Console.ReadLine();
    }

    (int Left, int Top) Map(int hole) =>
        hole switch
        {
            1 => (06, 15),
            2 => (20, 15),
            3 => (34, 15),
            4 => (06, 09),
            5 => (20, 09),
            6 => (34, 09),
            7 => (06, 03),
            8 => (20, 03),
            9 => (34, 03),
            _ => throw new NotImplementedException(),
        };

    void Render(string @string)
    {
        int x = Console.CursorLeft;
        int y = Console.CursorTop;
        foreach (char c in @string)
        {
            if (c is '\n')
            {
                Console.SetCursorPosition(x, ++y);
            }
            else
            {
                Console.Write(c);
            }
        }
    }
}

void WaitForEnter()
{
    while (Console.ReadKey(intercept: true).Key != ConsoleKey.Enter) ;
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

//******************************************************************************
void playBlackJackGame()
{
    Console.ForegroundColor = ConsoleColor.White;
    Deck deck = new();

    deck.Shuffle(new Random());

    List<Card> playerHand = new();
    List<Card> dealerHand = new();

    Console.WriteLine("Hello, what is your name?");
    string playerName = Console.ReadLine();
    Console.WriteLine("Welcome to Blackjack!");

    // Not dealing with Hard or Soft 17, Splitting, int-Downs, etc.
    //******************************************************************************

    bool readyToPlay = PromptUserForDecision(playerName);

    if (readyToPlay)
    {
        Console.WriteLine("Let's play BlackJack!");
    }
    else
    {
        Console.WriteLine("Maybe next time. Goodbye!");
        return;
    }

    static bool PromptUserForDecision(string playerName)
    {
        Console.WriteLine($"Are you ready to play?");
        Console.WriteLine("[Y] To Play.");
        Console.WriteLine("[N] To Exit.");

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
            char keyChar = char.ToUpper(keyInfo.KeyChar);

            if (keyChar == 'Y')
            {
                Console.WriteLine();
                return true;

            }
            else if (keyChar == 'N')
            {
                Console.WriteLine();
                return false;

            }
            else
            {
                Console.WriteLine("\nInvalid input. Please press [Y] to play or [N] to exit.");
            }
        }
    }

    //******************************************************************************
    // Round 1 Start, Buy-In

    Console.WriteLine("Do you want to buy in at $10, $25, $50, or $100?");
    int buyInValue;

    while (true)
    {
        if (!int.TryParse(Console.ReadLine(), out buyInValue) || (buyInValue != 10 && buyInValue != 25 && buyInValue != 50 && buyInValue != 100))
        {
            Console.WriteLine("Invalid response. Please enter [10], [25], [50], or [100].");
        }
        else
        {
            break;
        }
    }

    int roundOutcome = 0;
    int bankRollAmount = buyInValue + -roundOutcome;

    Console.WriteLine($"Great! You've bought in at {buyInValue}. Your Bankroll is ${bankRollAmount}.");
    bool playAgain = true;

    //******************************************************************************
    // All continuous round start

    while (playAgain == true)
    {
        deck.Shuffle(new Random());
        playerHand.Clear();
        dealerHand.Clear();

        // Deal 2 new cards to player and dealer
        playerHand.Add(deck.DealCard());
        dealerHand.Add(deck.DealCard());
        playerHand.Add(deck.DealCard());
        dealerHand.Add(deck.DealCard());

        if (bankRollAmount <= 0)
        {
            Console.WriteLine("Sorry! You have bust out. Better luck next time!");
            return;
        }

        int playerTotal = CalculateHandValue(playerHand);
        int dealerTotal = CalculateHandValue(dealerHand);

        // Introduce betting mechanic
        // No decimals, need to test negative numbers

        int betValue;

        while (true)
        {
            Console.WriteLine("How much would you like to bet? Min ($1) Max ($10000)");
            if (!int.TryParse(Console.ReadLine(), out betValue) || betValue < 0 || betValue > 10000)
            {
                Console.WriteLine("Invalid bet amount. Please enter an amount between $1.00 and $10000.");
            }
            else if (betValue > buyInValue)
            {
                Console.WriteLine("You cannot bet more money than you have.. Try again.");
            }
            else
            {
                break;
            }
        }

        Console.WriteLine($"You're betting ${betValue}. Good Luck, {playerName}!");
        Console.WriteLine("");
        Console.WriteLine($"Player's hand: {DisplayHand(playerHand, true)} ({playerTotal})");
        Console.WriteLine($"Dealer lays one card facedown. Dealer's face-up card: {DisplayCard(dealerHand[1])}");

        //******************************************************************************
        // Actual Gameplay

        while (playerTotal < 21)
        {
            Console.WriteLine("Do you want to hit [H] or stand [S]?");
            char choice = char.ToUpper(Console.ReadKey().KeyChar);

            if (choice == 'H' && playerTotal < 21)
            {
                Card newCard = deck.DealCard();
                playerHand.Add(newCard);
                playerTotal = CalculateHandValue(playerHand);
                Console.WriteLine($"\n{playerName} drew {DisplayCard(newCard)}");
                Console.WriteLine($"Player's hand: {DisplayHand(playerHand, true)} ({playerTotal})");

                if (dealerTotal < 17)
                {
                    Card newCardDealer = deck.DealCard();
                    dealerHand.Add(newCardDealer);
                    dealerTotal = CalculateHandValue(dealerHand);
                    Console.WriteLine($"\nDealer has to hit. Dealer draws {DisplayCard(newCardDealer)}");
                    Console.WriteLine($"Dealer hand: FaceDown, {DisplayCard(dealerHand[1])}, {DisplayCard(newCard)}");
                    continue;
                }
                continue;
            }

            if (choice == 'S')
            {
                Console.WriteLine($"\nYou Stand. {DisplayHand(playerHand, true)} ({playerTotal})");

                while (dealerTotal <= 17) //"Hit on Soft 17, Stand on Hard 17" when implemented
                {
                    Card newCard = deck.DealCard();
                    dealerHand.Add(newCard);
                    dealerTotal = CalculateHandValue(dealerHand);
                    Console.WriteLine($"\nDealer has to hit. Dealer draws {DisplayCard(newCard)}");
                    Console.WriteLine($"Dealer hand: FaceDown, {DisplayCard(dealerHand[1])}, {DisplayCard(newCard)}");
                }
                break;
            }

            else if (choice != 'H' && choice != 'S')
            {
                Console.WriteLine("Invalid Response.\nPlease enter 'H' to Hit or 'S' to Stand.");
                continue;
            }
        }

        //******************************************************************************
        // Round over, determine winner
        // Retrieve cards first

        DetermineWinner(playerTotal, dealerTotal);

        string DisplayHand(List<Card> hand, bool revealAll = false)
        {
            List<string> cardStrings = new();

            for (int i = 0; i < hand.Count; i++)
            {
                if (i == 0 && !revealAll)
                {
                    cardStrings.Add("Hidden");
                }
                else
                {
                    cardStrings.Add(DisplayCard(hand[i]));
                }
            }
            return string.Join(", ", cardStrings);
        }

        // Calculate hand value

        int CalculateHandValue(List<Card> hand)
        {
            int total = 0;
            int numAces = 0;

            foreach (var card in hand)
            {
                if (Enum.TryParse(card.FaceValue, out FaceValue faceValue))
                {
                    if (faceValue == FaceValue.Ace)
                    {
                        numAces++;
                        total += 11; // Assume Ace is 11 initially
                    }
                    else if (faceValue >= FaceValue.Two && faceValue <= FaceValue.Ten)
                    {
                        total += (int)faceValue;
                    }
                    else
                    {
                        total += 10; // Jack, Queen, and King are all worth 10
                    }
                }
            }

            // Adjust the value of Aces if needed

            while (numAces > 0 && total > 21)
            {
                total -= 10; // Change the value of one Ace from 11 to 1
                numAces--;
            }
            return total;
        }

        string DisplayCard(Card card)
        {
            return $"{card.FaceValue} of {card.Suit}";
        }

        //******************************************************************************
        // Tell user outcome of round

        void DetermineWinner(int playerTotal, int dealerTotal)
        {
            if (playerTotal > 21)                                       //Player loses
            {
                Console.WriteLine("Player busts! Dealer wins!");
                bankRollAmount = bankRollAmount - betValue;
                Console.WriteLine($"- ${betValue}\nBankroll: ${bankRollAmount}");
            }
            else if (dealerTotal > 21)                                  //Player wins
            {
                Console.WriteLine($"Dealer busts! {playerName} wins!");
                bankRollAmount = bankRollAmount + (betValue * 2);
                Console.WriteLine($"+ ${betValue * 2}\nBankroll: ${bankRollAmount}");
            }
            else if (playerTotal == 21 && playerTotal != dealerTotal)    //Player wins
            {
                Console.WriteLine($"{playerName} has Blackjack!");
                bankRollAmount = bankRollAmount + (betValue * 2);
                Console.WriteLine($"+ ${betValue * 2}\nBankroll: ${bankRollAmount}");
            }
            else if (dealerTotal == 21)                                 //Player loses
            {
                Console.WriteLine("Dealer has Blackjack!");
                bankRollAmount = bankRollAmount - betValue;
                Console.WriteLine($"- ${betValue}\nBankroll: ${bankRollAmount}");
                return;
            }
            else if (playerTotal > dealerTotal)                         //Player wins
            {
                Console.WriteLine($"{playerName} wins!");
                bankRollAmount = bankRollAmount + (betValue * 2);
                Console.WriteLine($"+ ${betValue * 2}\nBankroll: ${bankRollAmount}");
            }
            else if (playerTotal < dealerTotal)                         //Player loses
            {
                Console.WriteLine("Dealer wins!");
                bankRollAmount = bankRollAmount - betValue;
                Console.WriteLine($"- ${betValue}\nBankroll: ${bankRollAmount}");
            }
            else if (playerTotal == dealerTotal)
            {
                Console.WriteLine("It's a tie!");                       // TIE
                Console.WriteLine($"All bets returned. BankRoll : {bankRollAmount}");
            }
            else if (dealerTotal == 21)                                 //Player loses
            {
                Console.WriteLine("Dealer has BlackJack! You lose!");
                bankRollAmount = bankRollAmount - betValue;
                Console.WriteLine($"- ${betValue}\nBankroll: ${bankRollAmount}");
                return;
            }
        }

        //******************************************************************************
        // Can/Does user want to play another round?

        if (bankRollAmount > 0)
        {
            Console.WriteLine("Would you like to play another round? [Y] [N]");
            string anotherRound = Console.ReadLine();
            string anotherRoundUpper = anotherRound.ToUpper();

            bool playAnotherRound = anotherRoundUpper == "Y";

            if (playAnotherRound == true)
            {
                playAgain = true;
                continue;
            }
            if (playAnotherRound != true && playAnotherRound)
            {
                Console.WriteLine("Invalid Response. Please enter [Y] to play another round or [N] to quit the game.");
            }
            if (playAnotherRound == false)
            {
                Console.WriteLine("Okay, see ya again next time!");
                break;
            }
            if (bankRollAmount <= 0)
            {
                Console.WriteLine($"Sorry, you have busted out of the game. You are at {bankRollAmount}. Better luck next time!");
                break;
            }
        }
    }
}
//******************************************************************************
//Class
public class Deck
{
    public List<Card> Cards { get; set; }

    public Deck()
    {
        Cards = new List<Card>();
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (FaceValue faceValue in Enum.GetValues(typeof(FaceValue)))
            {
                Cards.Add(new Card { Suit = suit.ToString(), FaceValue = faceValue.ToString() });
            }
        }
    }

    //Method
    public void Shuffle(Random rng)
    {
        //Random rng = new Random();
        int n = Cards.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            Card value = Cards[k];
            Cards[k] = Cards[n];
            Cards[n] = value;
        }
    }

    //Method
    public Card DealCard()
    {
        Card card = Cards[0];
        Cards.RemoveAt(0);
        return card;
    }
}

//Class
public class Card
{
    public string? Suit { get; set; }
    public string? FaceValue { get; set; }
}

//Enum Class
public enum FaceValue
{
    Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
    Jack, Queen, King, Ace
}

//Enum Class
public enum Suit
{
    Hearts,
    Diamonds,
    Clubs,
    Spades
}
//******************************************************************************

public enum SelectedGame
{
    CuthulusReign,
    ShipShape,
	Leon,
	Kyle,
	Neebles,
	Rachel,
	Cali,
	Aaron,
	War,
    Cali2
}
//gitdesk