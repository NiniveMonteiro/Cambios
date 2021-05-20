
namespace Cambios.Modelos
{
    public class Response
    {
        public bool IsSuccess { get; set; }//para dizer se as coisas correram bem ou nao

        public string Message { get; set; }//caso as coisas corram mal, saber o que se passou, informando pela msg

        public object Result { get; set; }//Caso de tudo certo, carrega o objeto

    }
}
