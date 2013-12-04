using PropertyChanged;
using ReactiveUI;

namespace IMergeGui.Core.ViewModels
{
    [ImplementPropertyChanged]
    public class EmptyMainViewModel
    {
        public ReactiveCommand LoadCommand { get; set; }

        public EmptyMainViewModel()
        {
            LoadCommand = new ReactiveCommand();
        }
    }
}