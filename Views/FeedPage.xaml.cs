using LoginDemoMAUI.ViewModels;

namespace LoginDemoMAUI.Views;

public partial class FeedPage : ContentPage
{
	public FeedPage(FeedViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel; 
	}
}