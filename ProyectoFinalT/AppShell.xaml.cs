﻿namespace ProyectoFinalT;
using ProyectoFinalT.Views;
public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        //this.BindingContext = new AppShellViewModel();
        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
    }
}
