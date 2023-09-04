namespace ProyectoFinalT;

public partial class LoginUp : ContentPage
{
	public LoginUp()
	{
		InitializeComponent();
	}
    private async void TapGestureRecognizer_Tapped_For_Login(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Login");
    }
}