using R3;

namespace SaveVillage
{
    public interface IGameViewModel
    {
        public ReadOnlyReactiveProperty<float> WorkersCountDown { get; }
    }
}