namespace PruebaTecnica.Core.Common
{
    public class RespuestaBase
    {
        public RespuestaBase()
        {
            Satisfactorio = true;
        }
        public RespuestaBase(string message = null)
        {
            Satisfactorio = true;
            Mensaje = message;
        }

        public RespuestaBase(string message, bool success)
        {
            Satisfactorio = success;
            Mensaje = message;
        }

        public bool Satisfactorio { get; set; }
        public string Mensaje { get; set; }
        public List<string> ValidacionErrores { get; set; }
    }
}
