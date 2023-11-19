using DashPod.MAUI.ViewModels;

namespace DashPod.MAUI;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
