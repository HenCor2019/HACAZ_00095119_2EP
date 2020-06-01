namespace Preparcial.Modelo
{
    public class Usuario
    {
        public string IdUsuario { get;}

        public string Nombre { get;}

        public string Contrasena { get;}

        public bool Admin { get;}

        public Usuario(string idUsuario, string nombre, string contrasenia, bool admin)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Contrasena = contrasenia;
            Admin = admin;
        }
    }
}
