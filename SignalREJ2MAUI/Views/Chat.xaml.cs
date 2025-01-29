using SignalREJ1MAUI.Model.ViewModels;

namespace SignalREJ1MAUI.Views;

public partial class Chat : ContentPage
{
	public Chat() {
		InitializeComponent();
	}

	public Chat(string nombreUsuario, string nombreGrupo)
	{
        InitializeComponent();
		BindingContext = new ChatVM(nombreUsuario, nombreGrupo);
	}
}