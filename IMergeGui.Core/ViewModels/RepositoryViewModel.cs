using LibGit2Sharp;
using PropertyChanged;
using ReactiveUI;

namespace IMergeGui.Core.ViewModels
{
    [ImplementPropertyChanged]
    public class RepositoryViewModel : ReactiveObject
    {
        private readonly IRepository repo;

        public RepositoryViewModel(IRepository repo)
        {
            this.repo = repo;
        }
    }
}