namespace GuessNumber.Domain
{
    public class GameSettings
    {
        public int MaxAttempts { get; set; } = 5;
        public int MinNumber { get; set; } = 1;
        public int MaxNumber { get; set; } = 100;
    }
}
