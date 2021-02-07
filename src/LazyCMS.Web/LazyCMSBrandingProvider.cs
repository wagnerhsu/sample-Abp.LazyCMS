using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace LazyCMS.Web
{
    [Dependency(ReplaceServices = true)]
    public class LazyCMSBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "LazyCMS";
    }
}