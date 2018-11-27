using Autofac;
using JetBrains.Annotations;
using Lykke.BilService.RootstockSignService.Settings;
using Lykke.Quintessence.Settings;
using Lykke.Quintessence.Utils;

namespace Lykke.BilService.RootstockSignService.Modules
{
    [UsedImplicitly]
    public class RootstockSignServiceModule : Module
    {
        private readonly AppSettings<RootstockSignServiceSettings> _appSettings;

        public RootstockSignServiceModule(
            AppSettings<RootstockSignServiceSettings> appSettings)
        {
            _appSettings = appSettings;
        }

        protected override void Load(
            ContainerBuilder builder)
        {
            builder
                .RegisterRootstock(_appSettings.SignService.IsMainNet);
        }
    }
}