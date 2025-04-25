using SaveVillage;
using Zenject;

public class WorkersModelFactory : IFactory<GameConfig, WorkersViewModel>
{
    public WorkersViewModel Create(GameConfig gameConfig)
    {
        return new WorkersViewModel(gameConfig);
    }
}