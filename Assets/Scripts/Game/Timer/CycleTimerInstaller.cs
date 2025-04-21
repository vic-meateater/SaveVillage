using Zenject;

namespace SaveVillage
{
    public class CycleTimerInstaller : Installer<CycleTimerInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<CycleTimer>().AsSingle().NonLazy();
        }
    }
}