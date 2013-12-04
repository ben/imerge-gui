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
        public ReactiveCommand DoTheThing { get; private set; }
        public double TheText { get; set; }

        public ShellViewModel()
        {
            TheText = 5;

            DoTheThing = new ReactiveCommand(Observable.Return(true));
            DoTheThing
                .Subscribe(_ =>
                {
                    TheText++;
                });
        }
    }
}
