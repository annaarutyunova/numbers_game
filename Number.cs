public class Number 
{
    List<int> numbers = new List<int>();

    public Number()
    {
        // List<int> numbers = new List<int>();
        // MakeNumberList();
    }

    public int GenerateRandomNumber() /// Generates a random number from 1 to 9 including
    {
        Random randomNumber = new Random();
        return randomNumber.Next(1,10);
    }

    public void MakeNumberList() /// Creates 4 random numbers from 1 to 9 and adds them to the numbers list
    {
        
        for (int i=0; i<4; i++)
        {
            int number = GenerateRandomNumber();
            numbers.Add(number);
            // Console.WriteLine(number);
        } 
    }

    public void AddToNumberList() ///Add 2 more numbers to the existing list of numbers
    {
        for (int i=0; i<2; i++)
        {
            int number = GenerateRandomNumber();
            numbers.Add(number);
            // Console.WriteLine(number);
        } 

    }

    public void PrintNumbers() /// In c# that's the way to print out a list: concatinate it into a string with the first argument being what separates the list items
    {
        Console.WriteLine(String.Join(" ", numbers));
    }

    public List<string> ConvertToTrimmedList()
    {
        List<string> num = numbers.Select(i => i.ToString()).ToList();
        return num;
    }
    
    public string ConvertToString()
    {
        string numbers = string.Join("",ConvertToTrimmedList());
        return numbers;
        // Console.WriteLine(numbers);
    }

    public void PrintTrimmedString()
    {
        Console.WriteLine(String.Join("", ConvertToTrimmedList()));
    }

    public void Clear()
    {
       Console.WriteLine(); 
    }

    public void ClearList()
    {
        numbers.Clear();
    }

}

/// Thread.Sleep(2000); /// Waits 2 seconds before clearing the console
/// Console.Clear();