using LoginDemoMAUI.ViewModels;
using System.Windows.Input;

namespace LoginDemoMAUI;

public partial class MainPage : ContentPage
{

	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

