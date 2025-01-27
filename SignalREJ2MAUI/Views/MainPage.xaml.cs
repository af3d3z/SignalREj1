using Microsoft.AspNetCore.SignalR.Client;
using Models;
using System.Collections.ObjectModel;

namespace SignalREJ1MAUI.Views
{
    public partial class MainPage : ContentPage
    {
        private readonly HubConnection _connection;
        public MainPage()
        {
            InitializeComponent();
        }
    }

}
