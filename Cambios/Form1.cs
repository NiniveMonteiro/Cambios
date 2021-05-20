
namespace Cambios
{
    using Servicos;
    using Modelos;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Windows.Forms;
    using System.Threading.Tasks;

    public partial class Form1 : Form
    {
        #region Atributos

        private NetworkService networkService;

        private ApiService apiService;

        #endregion
        public List<Rate> Rates { get; set; } = new List<Rate>();

        public Form1()
        {
            InitializeComponent();

            networkService = new NetworkService();

            apiService = new ApiService();

            LoadRates();
        }

        private async void LoadRates()
        {
            // bool load;

            Lb_Resultado.Text = "Atualizar taxas";

            var connection = networkService.CheckConnectin();//Verificação com a Net

            if (!connection.IsSuccess)
            {
                //LoadLocalRates()
                MessageBox.Show(connection.Message);
                return;
            }
            else
            {
                await LoadApiRates();
            }

            //Corrige bugs da microsoft
            Cb_MoedaOrigem.DataSource = Rates;
            Cb_MoedaOrigem.DisplayMember = "Name";

            Cb_MoedaDestino.BindingContext = new BindingContext(); //Separar Cbs, diz que a cb destino tem um binding diferente

            Cb_MoedaDestino.DataSource = Rates;
            Cb_MoedaDestino.DisplayMember = "Name";

            progressBar1.Value = 100;

            Lb_Resultado.Text = "Taxas Carregadas";
        }

        private async Task LoadApiRates()
        {
            progressBar1.Value = 0;

            var response = await apiService.GetRates("http://cambios.somee.com", "/api/rates");

            Rates = (List<Rate>) response.Result; 
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //var client = new HttpClient();// Criar Http para fazer ligação externa via Http - foi retirado daqui e colocado em uma classe
        //client.BaseAddress = new Uri("http://cambios.somee.com");// Endereço base da Api
        //var respose = await client.GetAsync("/api/rates"); // Assincrona - Diz onde esta o controlador da API
        // var result = await respose.Content.ReadAsStringAsync(); //Carrega os resultados no formado de uma string para dentro do objeto result
        //if (!respose.IsSuccessStatusCode)//Se algo correr mau
        //{
        //    MessageBox.Show(respose.ReasonPhrase);
        //    return;
        //}
        //var rates = JsonConvert.DeserializeObject<List<Rate>>(result);//Pega o json e coloca em uma lista que o guarda do tipo Rates

    }
}
