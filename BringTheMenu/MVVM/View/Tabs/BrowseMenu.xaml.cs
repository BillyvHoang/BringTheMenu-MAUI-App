using BringTheMenu.MVVM.ViewModel.Tabs;

namespace BringTheMenu.MVVM.View;

public partial class BrowseMenu : ContentPage
{
	public BrowseMenu(BrowseMenu_ViewModel data)
	{
		InitializeComponent();
		BindingContext = data;
	}
}