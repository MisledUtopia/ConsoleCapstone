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
	"1: Maria's Game",
	"2: Garrion's Game",
	"3: Leon's Game",
	"4: Big Wallet Gangstas",
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
			selectedGame = SelectedGame.Maria;
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
	Maria,
	Garrion,
	Leon,
	Kyle,
	Neebles,
	Rachel,
	Cali,
	Aaron,
	War
}