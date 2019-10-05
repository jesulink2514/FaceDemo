using System.IO;
using FaceDemo.Datos;
using FaceDemo.Droid.Datos;
using FaceDemo.Helpers;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseDatosAndroid))]
namespace FaceDemo.Droid.Datos
{
    public class BaseDatosAndroid : IBaseDatos
    {
        public string GetDatabasePath()
        {
            return Path.Combine(
                System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal), 
                    Constantes.NombreBD);
        }
    }
}