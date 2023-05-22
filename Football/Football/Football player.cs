namespace Football
{
    internal class Football_player : Person
    {
        public Football_player(string name,int age,int number, double height): base(name,age)
        {
            Number = number;
            Height = height;
        }

        public int Number { get; set; }
        public double Height { get; set; }

        public void ShowPlayerStatistics()
        {
            Console.WriteLine("Player statistcs are:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Number: {Number}");
            Console.WriteLine($"Height: {Height}cm");
        }
    }
}
