using System;
using Newtonsoft.Json;
using ProductoAppBWA.Models;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Components.Forms;
using System.Net;

namespace ProductoAppBWA.Service
{
	public class APIStorageService : IAPIStorageService
    {

        public HttpClient _httpClient;

        public APIStorageService()
		{
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://apiproductostorage.azurewebsites.net");
        }

        public async Task<string> PostImage(IBrowserFile file)
        {

            using (var multipartFormContent = new MultipartFormDataContent())
            {
                //Load the file and set the file's Content-Type header
                var fileStreamContent = new StreamContent(file.OpenReadStream(file.Size));
                fileStreamContent.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType);

                //Add the file
                multipartFormContent.Add(fileStreamContent, name: "file", fileName: file.Name);

                //Send it
                var response = await _httpClient.PostAsync("/api/productostorage", multipartFormContent);
                if (response.IsSuccessStatusCode)
                {
                    var string_response = await response.Content.ReadAsStringAsync();
                    return string_response;
                }
               
                return null;
            }
        }

        public async Task<string> GetUrlImage(string ImageName)
        {
            var response = await _httpClient.GetAsync($"/api/productostorage/{ImageName}");
            if (response.IsSuccessStatusCode)
            {
                var string_response = await response.Content.ReadAsStringAsync();
                return string_response;
            }
            return null;
        }

        public async Task<bool> DeleteImage(string ImageName)
        {
            var response = await _httpClient.DeleteAsync($"/api/productostorage/{ImageName}");
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
    }
}

