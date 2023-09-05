using Microsoft.Maui.Controls.PlatformConfiguration;

namespace ProyectoFinalT.Views;

public partial class CuestionariosPage : ContentPage
{
	public CuestionariosPage()
	{
		InitializeComponent();
	}
    //private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
    //{
    //    Frame.Navigate(typeof(BibliotecaPage));
    //}
    private async void Button_Click(object sender,EventArgs e)
    {
        await Navigation.PushAsync(new Cuestionario1Page());
    }
}