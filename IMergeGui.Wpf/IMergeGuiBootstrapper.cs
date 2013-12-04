using Caliburn.Micro;
using IMergeGui.Core.ViewModels;

namespace IMergeGui.Wpf
{
    public class IMergeGuiBootstrapper : Bootstrapper<ShellViewModel>
    {
        public IMergeGuiBootstrapper()
        {
            var mappingConfig = new TypeMappingConfiguration
            {
                DefaultSubNamespaceForViewModels = "Core.ViewModels",
                DefaultSubNamespaceForViews = "Wpf.Views",
            };
            ViewLocator.ConfigureTypeMappings(mappingConfig);
            ViewModelLocator.ConfigureTypeMappings(mappingConfig);
        }
    }
}