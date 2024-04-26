using Ninject.Modules;
using GroupWorkerTwo.Core.Models;

namespace GroupWorkerTwo.Main;

public class DependencyInjectionManager : NinjectModule
{
    public override void Load()
    {
        Bind<IApplicationDataProperties>().To<ApplicationDataProperties>().InSingletonScope();
    }
}
