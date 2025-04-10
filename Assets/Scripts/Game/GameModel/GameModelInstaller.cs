using Zenject;

namespace SaveVillage
{
    public class GameModelInstaller : Installer<GameModelInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<GameModelFactory>().AsSingle().NonLazy();
        }
    }
}