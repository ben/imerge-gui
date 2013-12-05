using LibGit2Sharp;
using PropertyChanged;
using ReactiveUI;

namespace IMergeGui.Core.ViewModels
{
    [ImplementPropertyChanged]
    public class RepositoryViewModel : ReactiveObject
    {
        private readonly IRepository repo;

        public string Text { get; set; }

        public RepositoryViewModel(IRepository repo)
        {
            this.repo = repo;

            Text = string.Format("{0}\r\n{1}", repo.Info.WorkingDirectory, repo.Info.Message);
        }
    }
}