using PropertyChanged;
using ReactiveUI;

namespace IMergeGui.Core.ViewModels
{
    [ImplementPropertyChanged]
    public class RepositoryViewModel : ReactiveObject
    {
        public string Path { get; set; }

        public RepositoryViewModel(string path)
        {
            Path = path;
        }
    }
}