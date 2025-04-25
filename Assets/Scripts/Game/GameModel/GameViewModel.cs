using R3;

namespace SaveVillage
{
    public sealed class GameViewModel: IGameViewModel
    {
        public ReadOnlyReactiveProperty<float> WorkersCountDown => _workersCountDown;
        public IWorkersViewModel WorkersViewModel => _workersViewModel;
        private readonly ReactiveProperty<float> _workersCountDown;
        
        private readonly IWorkersViewModel _workersViewModel;
        
        public GameViewModel(GameConfig gameConfig, IWorkersViewModel workersViewModel)
        {
            _workersViewModel = workersViewModel;
            _workersCountDown = new ReactiveProperty<float>(gameConfig.WorkersCountDown);
        }

    }
}