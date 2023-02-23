using MyShoppingApp.ViewModel;

namespace MyShoppingApp.View;

public partial class MyOrdersPage : ContentPage
{
    private MyOrdersViewModel _viewModel;

    public MyOrdersPage(MyOrdersViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
        _viewModel = viewModel;
    }

    public async void ContentPage_Loaded(object sender, EventArgs e)
    {
        //await _viewModel.OnLoaded();

    }

    public async void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        await _viewModel.OnLoaded();

    }
}