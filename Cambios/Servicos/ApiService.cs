
namespace Cambios.Servicos
{
    using Modelos;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class ApiService
    {

        public async Task<Response> GetRates(string urlBase, string controller)//Task => tarefa de devolver o que tem dentro, no caso uma Response
        {
            try
            {
                var client = new HttpClient();

                client.BaseAddress = new Uri(urlBase);// Endereço base da Api

                var respose = await client.GetAsync(controller);

                var result = await respose.Content.ReadAsStringAsync();

                if (!respose.IsSuccessStatusCode)//Se algo correr mau
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }
                var rates = JsonConvert.DeserializeObject<List<Rate>>(result);//Pega o json e coloca em uma lista que o guarda do tipo Rates

                return new Response
                {
                    IsSuccess = true,
                    Result = rates,
                };
            }
            catch(Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message,
                };
            }
        }
    }

}
