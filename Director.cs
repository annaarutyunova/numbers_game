public class Director 
{

    /// Questions: - how do I use keyboard to exit or continue the game
    
    bool ifMatch = true;
    Player player1 = new Player();
    Number number1 = new Number();
    string numbersEntered = "5";
    int time = 2000;

    public Director()
    {
        // WelcomeMessage();
        Play();
        // Player player1 = new Player();
        // Number number1 = new Number(); 
        // number1.MakeNumberList();
        // number1.PrintNumbers();
        // Clear();
        // player1.GetNumbers(GetNumbersSeen());
        // Console.WriteLine();
        // player1.PrintNumbersSeen();
        // number1.PrintTrimmedString();
        // Compare(number1.ConvertToString(), GetNumbersSeen());

    }

    public void WelcomeMessage()
    {
        Console.WriteLine();
        Console.WriteLine("This is a memory game. A set of numbers will be displayed. You have a couple of seconds to memorize them. Once they dissapear, you will be asked to enter the numbers you saw on the screen a moment eariler. As long as you get them right, you will be given a longer sequence of numbers each time. If you get it wrong once, you will be asked if you want to start the gameover. Once you are ready, press Enter. If you want to exit press Escape");
        string n = Console.ReadLine();
       
    }

    public void EnterNumbers()
    {
        Console.WriteLine("What were the numbers? (Don't include any spaces or commas)");
        Console.WriteLine();
        numbersEntered = Console.ReadLine();
        Console.WriteLine();
        
    }

    public string GetNumbersEntered()
    {
        return numbersEntered;
    } 


    public bool Compare(string a, string b)
    {
        if (a == b) 
        {
            return ifMatch;
        // Console.WriteLine("You got it right!");
        }
        else
        {
            return ifMatch = false;
            // Console.WriteLine("Oops. Try again");
        }
        
    }

    public void ifRight()
    {
        if(ifMatch = true)
        {
            Console.WriteLine("You got it right!");
        }
        else
        {
            Console.WriteLine("Oops. Try again");
        }
    }

    public void Play()
    {   
        Console.WriteLine();
        number1.MakeNumberList();
        number1.PrintNumbers();
        Clear();
        EnterNumbers();
        // Console.WriteLine(GetNumbersEntered());
        Compare(number1.ConvertToString(),GetNumbersEntered());
        ifRight();
        Continue();
        
        // Console.WriteLine(player1.GetNumbers(GetNumbersEntered()));
        // Compare(number1.ConvertToString(), GetNumbersEntered());
        // Console.WriteLine(GetNumbersEntered());
    }

    public void Continue()
    {
        if(ifMatch == true)
        {
            number1.AddToNumberList();
            time += 1500;
            number1.PrintNumbers();
            Clear();
            EnterNumbers();
        }
        else
        {
            Console.WriteLine("Game over");
        }

    }
    public void Clear()
    {
        Thread.Sleep(time);
        Console.Clear();
       
    }



    
}