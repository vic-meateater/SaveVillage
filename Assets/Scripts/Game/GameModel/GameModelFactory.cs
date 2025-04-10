using Zenject;

namespace SaveVillage
{
    public class GameModelFactory : IFactory
    {
        public GameViewModel Create(GameConfig gameConfig)
        {
            return new GameViewModel(gameConfig);
        }
    }
}