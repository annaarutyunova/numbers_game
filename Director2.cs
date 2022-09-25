public class Director2 
{

    /// Questions: - how do I use keyboard to exit or continue the game
    
    Player player1 = new Player();
    Number number1 = new Number();
    string numbersEntered = "5";
    int time = 2000;
    bool ifMatch = true;

    public Director2()
    {
        // WelcomeMessage();
        StartGame();
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
        Console.WriteLine("This is a memory game. A set of numbers will be displayed. You have a couple of seconds to memorize them. Once they dissapear, you will be asked to enter the numbers you saw on the screen a moment eariler. As long as you get them right, you will be given a longer sequence of numbers each time. If you get it wrong once, you will be asked if you want to start the gameover. Once you are ready, press Enter. If you want to exit press ctrl C");
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
            Console.WriteLine("You got it right!");
            Console.WriteLine();
            return ifMatch;
        }
        else
        {
            Console.WriteLine("Oops");
            Console.WriteLine();
            return ifMatch = false;
        }
        
    }


    public void StartGame()
    {
        WelcomeMessage();
        number1.MakeNumberList();
        number1.PrintNumbers();
        Clear();
        EnterNumbers();
    }

    public void Play()
    {   
        // Console.WriteLine(GetNumbersEntered());
        Compare(number1.ConvertToString(),GetNumbersEntered());
        while(ifMatch == true)
        {
            number1.AddToNumberList();
            time += 1500;
            number1.PrintNumbers();
            Clear();
            EnterNumbers();
            Compare(number1.ConvertToString(), GetNumbersEntered());
        }

        if(ifMatch == false)
        {
            Console.WriteLine("Would you like to play again? y/n");
            Console.WriteLine();
            string a = Console.ReadLine();
            if(a == "n")
            {
                GameOver();
            }
            else
            {
                ResetGame();
                Play();
            }
        }
    }

    public void ResetGame()
    {
        number1.ClearList();
        time = 2000;
        ifMatch = true;
        Console.WriteLine();
        number1.MakeNumberList();
        number1.PrintNumbers();
        Clear();
        EnterNumbers();
    }

    public void Clear()
    {
        Thread.Sleep(time);
        Console.Clear();
       
    }
    
    public void GameOver()
    {
        Console.WriteLine();
        Console.WriteLine("Thanks for playing!");
        Console.WriteLine();
    }
    


    
}