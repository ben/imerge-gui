using PropertyChanged;
using ReactiveUI;
using System;

namespace IMergeGui.Core
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