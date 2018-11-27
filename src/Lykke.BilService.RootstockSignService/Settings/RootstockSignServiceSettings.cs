using JetBrains.Annotations;
using Lykke.Quintessence.Settings;

namespace Lykke.BilService.RootstockSignService.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class RootstockSignServiceSettings : SignServiceSettings
    {
        public bool IsMainNet { get; set; }
    }
}