using LibGit2Sharp;
using PropertyChanged;
using ReactiveUI;
using System;

namespace IMergeGui.Core.ViewModels
{
    [ImplementPropertyChanged]
    public class ShellViewModel
    {
        public object Content { get; set; }

        public ShellViewModel()
        {
            var vm = new EmptyMainViewModel();
            vm.ObservableForProperty(x => x.PathToLoad)
                .Subscribe(path =>
                {
                    Content = new RepositoryViewModel(new Repository(Repository.Discover(path.Value)));
                });
            Content = vm;
        }
    }
}
