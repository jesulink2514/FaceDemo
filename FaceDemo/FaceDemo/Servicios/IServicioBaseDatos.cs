using System.Threading.Tasks;
using FaceDemo.Modelos;

namespace FaceDemo.Servicios
{
    public interface IServicioBaseDatos
    {
        Task<Usuario> ObtenerUsuario(string key);
        Task<bool> RegistrarUsuario(Usuario dato);
        Task<bool> ActualizarUsuario(Usuario dato);
    }
}
