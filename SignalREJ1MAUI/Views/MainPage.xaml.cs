using Microsoft.AspNetCore.SignalR.Client;
using Models;

namespace SignalREJ1MAUI.Views
{
    public partial class MainPage : ContentPage
    {
        private readonly HubConnection _connection;
        public MainPage()
        {
            InitializeComponent();
            _connection = new HubConnectionBuilder()
                .WithUrl("http://192.168.1.139:7141/chat")
                .Build();

            _connection.On<MensajeUsuario>("MessageReceived", (message) => {
                chatMessages.Text += $"{Environment.NewLine}{message.NombreUsuario}: {message.MsgUsuario}";
            });
            Task.Run(() =>
            {
                Dispatcher.Dispatch(async () =>
                await _connection.StartAsync());
            });
        }

        private async void sendButton_Clicked(object sender, EventArgs e)
        {
            await _connection.InvokeCoreAsync("SendMessage", args: new[] { new MensajeUsuario(myUsername.Text,myChatMessage.Text) });

            myChatMessage.Text = String.Empty;
        }
    }

}
