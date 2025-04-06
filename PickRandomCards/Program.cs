namespace PickRandomCards;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of cards to pick: "); // Prompt the user for input

        string? line = Console.ReadLine(); // Read the input from the console

        if (int.TryParse(line, out int numberOfCards)) // Try to parse the input as an integer
        {
            string[] pickedCards = CardPicker.PickSomeCards(numberOfCards); // Call the method to pick cards
            
            foreach (string card in pickedCards)
            {
                Console.WriteLine(card); // Print each card on a new line
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number."); // Handle invalid input
        }
    }
}
