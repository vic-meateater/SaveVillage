using Zenject;

namespace SaveVillage.Helpers
{
    public class LevelInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            GameCycleInstaller.Install(Container);
            GameModelInstaller.Install(Container);
            CycleTimerInstaller.Install(Container);
        }
    }
}