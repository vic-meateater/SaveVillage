using R3;

namespace SaveVillage
{
    public sealed class GameViewModel: IGameViewModel
    {
        public ReadOnlyReactiveProperty<float> WorkersCountDown { get; }
    
        
        private readonly ReactiveProperty<float> _workersCountDown;
        public GameViewModel(GameConfig gameConfig)
        {
            WorkersCountDown = new ReactiveProperty<float>(gameConfig.WorkersCountDown);
        }

    }
}