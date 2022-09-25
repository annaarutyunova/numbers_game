/// player is in charge of inputs
public class Player 
{
    List<string> numbersSeen = new List<string>();
    public Player()
    {

    }

    public List<string> GetNumbers(string userinput)
    {
        string t = userinput.Trim();
        t = t.Replace(" ", "");
        numbersSeen = t.Split("").ToList();
        return numbersSeen;
        // foreach(string i in numbers_seen)
        // {
        //     Console.WriteLine(i);
        // }
    }
    public void PrintNumbersSeen()
    {
        Console.WriteLine(String.Join(" ", numbersSeen));
    }


/// In order to compare easier, trim the user input string, and replace spaces and commas with no spaces ("")  and compare it to the converted into string List of int (numbers)
}
