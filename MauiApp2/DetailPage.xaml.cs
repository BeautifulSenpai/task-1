using MauiApp2.ViewModel;

namespace MauiApp2;

public partial class DetailPage : ContentPage
{
	public DetailPage(DatailViewModel datailViewModel)
	{
		InitializeComponent();
		BindingContext = datailViewModel;
	}
}