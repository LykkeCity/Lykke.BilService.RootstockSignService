using JetBrains.Annotations;
using Lykke.BilService.RootstockSignService.Modules;
using Lykke.BilService.RootstockSignService.Settings;
using Lykke.Quintessence;
using Lykke.Sdk;

namespace Lykke.BilService.RootstockSignService
{
    [UsedImplicitly]
    public class Startup : SignServiceStartupBase<RootstockSignServiceSettings>
    {
        protected override string IntegrationName
            => "Rootstock";

        protected override void RegisterAdditionalModules(
            IModuleRegistration modules)
        {
            modules.RegisterModule<RootstockSignServiceModule>();
            
            base.RegisterAdditionalModules(modules);
        }
    }
}