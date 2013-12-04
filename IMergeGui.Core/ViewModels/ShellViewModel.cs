using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;
using ReactiveUI;

namespace IMergeGui.Core
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
