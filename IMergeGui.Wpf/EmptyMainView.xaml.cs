using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using IMergeGui.Core.ViewModels;
using Microsoft.WindowsAPICodePack;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace IMergeGui.Wpf.Views
{
    /// <summary>
    /// Interaction logic for EmptyMainView.xaml
    /// </summary>
    public partial class EmptyMainView
    {
        public EmptyMainView()
        {
            InitializeComponent();
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            var dlg = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
            };
            var result = dlg.ShowDialog(Window.GetWindow(this));
            if (result != CommonFileDialogResult.Ok) return;

            var model = DataContext as EmptyMainViewModel;
            if (model != null)
            {
                model.PathToLoad = dlg.FileName;
            }
        }
    }
}
