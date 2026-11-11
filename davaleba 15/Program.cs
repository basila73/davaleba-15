namespace davaleba_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>
        {
            new Player("Giorgi", 90, true),
            new Player("Nika", 75, false),
            new Player("Luka", 100, true),
            new Player("Saba", 60, true),
            new Player("Dato", 85, false),
            new Player("Giga", 95, true),
            new Player("Beka", 50, false),
            new Player("Andria", 80, true),
            new Player("Levan", 40, true),
            new Player("Tornike", 70, false)
        };

            
            var sortedPlayers = players
                .OrderByDescending(p => p.Score);

            Console.WriteLine("Players sorted by score:");

            sortedPlayers.ToList().ForEach(p =>
                Console.WriteLine($"{p.Name} - {p.Score}"));

            
            Console.WriteLine("\nActive players:");

            players
                .Where(p => p.IsActive)
                .ToList()
                .ForEach(p =>
                    Console.WriteLine($"{p.Name} - {p.Score}"));

            
            var maxPlayer = players
                .OrderByDescending(p => p.Score)
                .First();

            Console.WriteLine("\nPlayer with maximum score:");

            Console.WriteLine($"{maxPlayer.Name} - {maxPlayer.Score}");

            
            var minActivePlayer = players
                .Where(p => p.IsActive)
                .OrderBy(p => p.Score)
                .First();

            Console.WriteLine("\nActive player with minimum score:");

            Console.WriteLine($"{minActivePlayer.Name} - {minActivePlayer.Score}");
        }
    }
}
