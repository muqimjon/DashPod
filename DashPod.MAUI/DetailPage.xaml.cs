using DashPod.MAUI.ViewModels;

namespace DashPod.MAUI;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}