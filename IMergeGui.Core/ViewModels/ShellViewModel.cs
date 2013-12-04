using PropertyChanged;

namespace IMergeGui.Core.ViewModels
{
    [ImplementPropertyChanged]
    public class ShellViewModel
    {
        public object Content { get; set; }

        public ShellViewModel()
        {
            Content = new EmptyMainViewModel();
        }
    }
}
