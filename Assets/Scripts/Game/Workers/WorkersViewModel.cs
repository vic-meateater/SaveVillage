using R3;

namespace SaveVillage
{
    public class WorkersViewModel: IWorkersViewModel
    {
        public ReadOnlyReactiveProperty<float> WorkersCountDown => _workersCountDown;
        private readonly ReactiveProperty<float> _workersCountDown;

        public WorkersViewModel(GameConfig gameConfig)
        {
            _workersCountDown = new ReactiveProperty<float>(gameConfig.WorkersCountDown);
        }
    }
}