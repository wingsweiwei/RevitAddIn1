using RevitAddIn1.ViewModels;
using Wpf.Ui.Abstractions.Controls;
using Wpf.Ui.Appearance;

namespace RevitAddIn1.Views
{
    /// <summary>
    /// Page1.xaml 的交互逻辑
    /// </summary>
    public partial class Page1 : INavigableView<Page1ViewModel>
    {
        public Page1ViewModel ViewModel { get; }

        public Page1(Page1ViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = ViewModel;
            InitializeComponent();
            ApplicationThemeManager.Apply(this);
        }
    }
}
