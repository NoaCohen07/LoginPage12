using LoginPage.ViewModels;

namespace LoginPage.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
	   this.BindingContext = new LoginViewModel();
	}
}