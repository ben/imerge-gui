using Caliburn.Micro;

namespace IMergeGui.Wpf
{
    public class IMergeGuiBootstrapper : Bootstrapper<Core.ShellViewModel>
    {
        public IMergeGuiBootstrapper()
        {
            var mappingConfig = new TypeMappingConfiguration
            {
                DefaultSubNamespaceForViewModels = "Core",
                DefaultSubNamespaceForViews = "Wpf",
            };
            ViewLocator.ConfigureTypeMappings(mappingConfig);
            ViewModelLocator.ConfigureTypeMappings(mappingConfig);
        }
    }
}