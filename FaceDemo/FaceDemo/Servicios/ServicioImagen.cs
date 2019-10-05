using System;
using System.Threading.Tasks;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;

namespace FaceDemo.Servicios
{
    public static class ServicioImagen
    {
        public static async Task<MediaFile> TomarFoto()
        {
            MediaFile foto = null;

            try
            {
                var cameraStatus = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Storage);
                var storageStatus = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Camera);

                if (cameraStatus != PermissionStatus.Granted || storageStatus != PermissionStatus.Granted)
                {
                    var permissionsStatus = await CrossPermissions.Current.RequestPermissionsAsync(Permission.Storage,Permission.Camera);
                }

                await CrossMedia.Current.Initialize();

                if (CrossMedia.Current.IsCameraAvailable || CrossMedia.Current.IsTakePhotoSupported)
                {
                    foto = await CrossMedia.Current.PickPhotoAsync();
                }
            }
            catch (Exception ex)
            {

            }

            return foto;
        }
    }
}
