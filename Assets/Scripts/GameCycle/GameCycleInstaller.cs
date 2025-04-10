using Zenject;

namespace SaveVillage
{
    public class GameCycleInstaller : Installer<GameCycleInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<GameCycle>()
                .FromNewComponentOnNewGameObject()
                .AsSingle()
                .NonLazy();
        }
    }
}