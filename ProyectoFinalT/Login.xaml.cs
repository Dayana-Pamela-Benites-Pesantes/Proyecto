namespace ProyectoFinalT;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}
    private async void TapGestureRecognizer_Tapped_For_LoginUp(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//LoginUp");
    }
    private async void TapGestureRecognizer_Tapped_For_Iniciar(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}