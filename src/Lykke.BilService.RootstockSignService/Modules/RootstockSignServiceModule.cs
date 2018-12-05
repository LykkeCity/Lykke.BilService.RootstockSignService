using Autofac;
using JetBrains.Annotations;
using Lykke.BilService.RootstockSignService.Settings;
using Lykke.Quintessence.Core.Utils;
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
            var chainId = _appSettings.CurrentValue.SignService.IsMainNet ? 30 : 31;
            
            builder
                .RegisterChainId(chainId)
                .RegisterRootstockAddChecksumStrategy();
        }
    }
}