using PropertyChanged;
using ReactiveUI;

namespace IMergeGui.Core.ViewModels
{
    [ImplementPropertyChanged]
    public class EmptyMainViewModel : ReactiveObject
    {
        public string PathToLoad { get; set; }
    }
}