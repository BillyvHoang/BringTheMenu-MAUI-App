using BringTheMenu.MVVM.ViewModel.Tabs;

namespace BringTheMenu.MVVM.View.Tabs;

public partial class Account : ContentPage
{
	public Account(Account_ViewModel data)
	{
		InitializeComponent();
		BindingContext = data;
	}
}