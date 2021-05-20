


namespace Cambios.Servicos
{
    using Modelos;
    using System.Net;

    public class NetworkService
    {
        public Response CheckConnectin()
        {
            var client = new WebClient();

            try
            {
                using (client.OpenRead("http://client3.google.com/generate_204"))//sempre se coloca um ping ao site da google,
                                                                                 //pois o servidor esta sempre online
                {
                    return new Response
                    {
                        IsSuccess = true, 
                    };
                }
            }
            catch 
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = "Configure a sua ligação a Internet",
                };
            }
        }
    }
}
