using RevitAddIn1.ViewModels;
using Wpf.Ui.Abstractions.Controls;
using Wpf.Ui.Appearance;

namespace RevitAddIn1.Views
{
    /// <summary>
    /// Page2.xaml 的交互逻辑
    /// </summary>
    public partial class Page2 : INavigableView<Page2ViewModel>
    {
        public Page2ViewModel ViewModel { get; }

        public Page2(Page2ViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = ViewModel;
            InitializeComponent();
            ApplicationThemeManager.Apply(this);
        }
    }
}
