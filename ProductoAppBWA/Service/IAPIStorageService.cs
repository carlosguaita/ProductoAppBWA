using Microsoft.AspNetCore.Components.Forms;

namespace ProductoAppBWA.Service
{
    public interface IAPIStorageService
    {
        public Task<string> PostImage(IBrowserFile file);
        public Task<string> GetUrlImage(string ImageName);
        public Task<bool> DeleteImage(string ImageName);
    }
}