using Microsoft.UI.Xaml.Controls;

using Mission.ViewModels;

namespace Mission.Views;

public sealed partial class BlrainStormingPage : Page
{
    public BlrainStormingViewModel ViewModel
    {
        get;
    }

    public BlrainStormingPage()
    {
        ViewModel = App.GetService<BlrainStormingViewModel>();
        InitializeComponent();
    }
}
