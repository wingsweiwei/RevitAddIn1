using RevitAddIn1.ViewModels;
using Wpf.Ui;
using Wpf.Ui.Abstractions;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;

namespace RevitAddIn1.Views
{
    public sealed partial class RevitAddIn1View : INavigationWindow
    {
        public RevitAddIn1View(RevitAddIn1ViewModel viewModel, INavigationViewPageProvider navigationViewPageProvider)
        {
            DataContext = viewModel;
            InitializeComponent();
            SystemThemeWatcher.Watch(this);
            ApplicationThemeManager.Apply(this);
            SetPageService(navigationViewPageProvider);
        }

        public void ShowWindow() => Show();
        public void CloseWindow() => Close();
        public INavigationView GetNavigation() => RootNavigation;
        public bool Navigate(Type pageType) => RootNavigation.Navigate(pageType);
        public void SetPageService(INavigationViewPageProvider navigationViewPageProvider) => RootNavigation.SetPageProviderService(navigationViewPageProvider);
        public void SetServiceProvider(IServiceProvider serviceProvider) => RootNavigation.SetServiceProvider(serviceProvider);
    }
}