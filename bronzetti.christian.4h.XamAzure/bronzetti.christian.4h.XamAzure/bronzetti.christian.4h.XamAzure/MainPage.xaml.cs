using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using bronzetti.christian._4h.XamAzure.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace bronzetti.christian._4h.XamAzure
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            List<Studente> elenco = new List<Studente>();

            try
            {
                HttpClient client = new HttpClient();
                
                string response = await client.GetStringAsync("https://bronzetti-christian-4h-xamazureapi.conveyor.cloud/Studenti");
                elenco = JsonConvert.DeserializeObject<List<Studente>>(response);
            }
            catch (Exception err)
            {
                await DisplayAlert("Non va", err.Message, "Ok");
            }

            
            lvStudenti.ItemsSource = elenco;
        }
    }
}
