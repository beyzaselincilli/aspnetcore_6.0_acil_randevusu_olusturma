using Microsoft.Extensions.Localization;
using System.Reflection;
namespace Localization.Services
{
    /// <summary>
    /// Dummy class to group shared resources
    /// </summary>
    public class SharedResource { }
    public class LanguageService
    {
        private readonly IStringLocalizer _localizer;
        public LanguageService(IStringLocalizerFactory nesne)
        {
            var tip = typeof(SharedResource);
            var assemblyName = new AssemblyName(tip.GetTypeInfo().Assembly.FullName);
            _localizer = nesne.Create("SharedResource", assemblyName.Name); // 
        }
        public LocalizedString dildegis(string value)
        {
            return _localizer[value];
        }
    }
}