namespace MonkeyFinder.View;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(MonkeyDetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}