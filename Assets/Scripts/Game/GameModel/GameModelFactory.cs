using Zenject;

namespace SaveVillage
{
    public class GameModelFactory : IFactory<GameConfig, GameViewModel>
    {
        private readonly WorkersModelFactory _workerModelFactory;
        public GameViewModel Create(GameConfig gameConfig)
        {
            var workerViewModel = _workerModelFactory.Create(gameConfig);
            
            return new GameViewModel(gameConfig, workerViewModel);
        }
    }
}