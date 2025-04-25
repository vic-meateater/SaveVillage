using R3;

namespace SaveVillage
{
    public interface IWorkersViewModel
    {
        public ReadOnlyReactiveProperty<float> WorkersCountDown { get; }
    }
}