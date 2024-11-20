namespace GuessNumber.Interface
{
    public interface IGameService
    {
        IGameConfig GameConfig { get; }
        IRandomNumberGenerator NumberGenerator { get; }
        IInputOutput IOConsole { get; }
        bool IsGameFinished { get; }
        int AttemptsLeft { get; }
        void StartNewGame();
        void StopGame();
        bool MakeGuess();
    }
}
