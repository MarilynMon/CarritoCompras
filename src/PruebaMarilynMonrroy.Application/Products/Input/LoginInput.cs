namespace PruebaMarilynMonrroy.Products.Input
{
    public class LoginInput
    {
        public string Transaccion { get; set; }
        public DatosUsarios DatosUsarios { get; set; }
    }

    public class DatosUsarios
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
