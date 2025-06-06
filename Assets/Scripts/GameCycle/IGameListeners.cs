namespace SaveVillage
{
    public interface IGameListener
    {
    
    }
    
    public interface IGamePauseListener : IGameListener
    {
        public void OnPauseGame();
    }

    public interface IGameResumeListener : IGameListener
    {
        public void OnResumeGame();
    }

    public interface IGameStartListener : IGameListener
    {
        public void OnStartGame();
    }

    public interface IGameStopListener : IGameListener
    {
        public void OnStopGame(); 
    }

    public interface IUpdateListener : IGameListener
    {
        public void OnUpdateGame(float deltaTime);
    }
}
