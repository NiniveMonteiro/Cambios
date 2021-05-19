
namespace Cambios
{
    using Modelos;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadRates();
        }

        private async void LoadRates()
        {
            // bool load;

            progressBar1.Value = 0;

            var client = new HttpClient();// Criar Http para fazer ligação externa via Http
            client.BaseAddress = new Uri("http://cambios.somee.com");// Endereço base da Api
            var respose = await client.GetAsync("/api/rates"); // Assincrona - Diz onde esta o controlador da API

            var result = await respose.Content.ReadAsStringAsync(); //Carrega os resultados no formado de uma string para dentro do objeto result


            if (!respose.IsSuccessStatusCode)//Se algo correr mau
            {
                MessageBox.Show(respose.ReasonPhrase);
                return;
            }

            var rates = JsonConvert.DeserializeObject<List<Rate>>(result);//Pega o json e coloca em uma lista que o guarda do tipo Rates

            Cb_MoedaOrigem.DataSource = rates;
            Cb_MoedaOrigem.DisplayMember = "Name";

            Cb_MoedaDestino.BindingContext = new BindingContext(); //Separar Cbs, diz que a cb destino tem um binding diferente

            Cb_MoedaDestino.DataSource = rates;
            Cb_MoedaDestino.DisplayMember = "Name";

            progressBar1.Value = 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
