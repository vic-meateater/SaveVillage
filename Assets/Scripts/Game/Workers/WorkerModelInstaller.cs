using Zenject;

namespace SaveVillage
{
    public class WorkerModelInstaller : Installer<WorkerModelInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<WorkersModelFactory>().AsSingle();
        }
    }
}