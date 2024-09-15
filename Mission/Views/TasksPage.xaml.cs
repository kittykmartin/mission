using Microsoft.UI.Xaml.Controls;

using Mission.ViewModels;

namespace Mission.Views;

public sealed partial class TasksPage : Page
{
    public TasksViewModel ViewModel
    {
        get;
    }

    public TasksPage()
    {
        ViewModel = App.GetService<TasksViewModel>();
        InitializeComponent();
    }
}
