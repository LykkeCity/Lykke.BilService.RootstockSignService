using Autofac;
using JetBrains.Annotations;
using Lykke.BilService.RootstockSignService.Settings;
using Lykke.Quintessence.Settings;
using Lykke.Quintessence.Utils;
using Lykke.SettingsReader;

namespace Lykke.BilService.RootstockSignService.Modules
{
    [UsedImplicitly]
    public class RootstockSignServiceModule : Module
    {
        private readonly IReloadingManager<AppSettings<RootstockSignServiceSettings>> _appSettings;

        public RootstockSignServiceModule(
            IReloadingManager<AppSettings<RootstockSignServiceSettings>> appSettings)
        {
            _appSettings = appSettings;
        }

        protected override void Load(
            ContainerBuilder builder)
        {
            builder
                .RegisterRootstock(_appSettings.CurrentValue.SignService.IsMainNet);
        }
    }
}