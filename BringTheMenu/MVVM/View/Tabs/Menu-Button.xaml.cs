using BringTheMenu.MVVM.ViewModel.Tabs;

namespace BringTheMenu.MVVM.View;

public partial class Menu_Button : ContentPage
{
	public Menu_Button(Menu_Button_ViewModel data)
	{
		InitializeComponent();
		BindingContext = data;
	}
}