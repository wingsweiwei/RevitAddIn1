using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;

namespace RevitAddIn1.ViewModels
{
    public partial class Page2ViewModel : ObservableObject
    {
        [RelayCommand]
        public async Task Confirm()
        {
            //ApplicationThemeManager.Apply(this);
            var msgBox = new MessageBox
            {
                Title = "Page2",
                Content = "Page2",
            };
            ApplicationThemeManager.Apply(msgBox);
            await msgBox.ShowDialogAsync();
        }
    }
}
