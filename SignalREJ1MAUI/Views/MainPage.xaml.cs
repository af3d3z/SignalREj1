﻿using Microsoft.AspNetCore.SignalR.Client;
using Models;
using System.Collections.ObjectModel;

namespace SignalREJ1MAUI.Views
{
    public partial class MainPage : ContentPage
    {
        private readonly HubConnection _connection;
        public MainPage()
        {
            ObservableCollection<MensajeUsuario> mensajitos = new ObservableCollection<MensajeUsuario>();
            InitializeComponent();
            _connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7141/chathub")
                .Build();

            mensajes.ItemsSource = mensajitos;

            _connection.On<MensajeUsuario>("ReceiveMessage", (message) =>
            {
               Dispatcher.Dispatch(() =>
                {
                    mensajitos.Add(message);
                });

            });
            Task.Run(() =>
            {
                Dispatcher.Dispatch(async () =>
                await _connection.StartAsync());
            });

        }

        private async void sendButton_Clicked(object sender, EventArgs e)
        {
            if (_connection.State == HubConnectionState.Connected)
            {
                await _connection.InvokeCoreAsync("SendMessage", args: new[] { new MensajeUsuario(myUsername.Text, myChatMessage.Text) });
            }
            else {
                await _connection.StartAsync();
                await _connection.InvokeCoreAsync("SendMessage", args: new[] { new MensajeUsuario(myUsername.Text, myChatMessage.Text) });
            }

            myChatMessage.Text = String.Empty;
        }
    }

}
