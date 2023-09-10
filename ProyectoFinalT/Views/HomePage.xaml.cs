namespace ProyectoFinalT.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}
    private async void Button_Click_Simbolo(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SimbologiaPage());
    }
    private async void Button_Click_Lectura(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LecturaPage());
    }
    private async void Button_Click_Leyenda(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LeyendaPage());
    }
    private async void Button_Click_Traduccion(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TraduccionPage());
    }
}