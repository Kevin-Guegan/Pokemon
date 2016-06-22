using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.API
{
    public class ApiManager
    {
        public async Task<T> GetFromApi<T>()
        {
            T item = default(T);
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost/PokemonSymfony3/web/app_dev.php/api/");
                HttpResponseMessage response = await client.GetAsync(typeof(T).Name.ToLower());

                if (response.IsSuccessStatusCode)
                {
                    String result = await response.Content.ReadAsStringAsync();
                    item = JsonConvert.
                        DeserializeObject<T>(result);
                }
            }

            return item;
        }

        public async Task<T> GetFromApi<T>(Int32 id)
        {
            T item = default(T);
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost/PokemonSymfony3/web/app_dev.php/api/");
                HttpResponseMessage response = await client.GetAsync(typeof(T).Name.ToLower() + "/" + id);

                if (response.IsSuccessStatusCode)
                {
                    String result = await response.Content.ReadAsStringAsync();
                    item = JsonConvert.
                        DeserializeObject<T>(result);
                }
            }

            return item;
        }

        /*public async Task<Boolean> PostToApi<T>(T item)
        {
            Boolean isOk = false;

            using (Windows.Web.Http.HttpClient client = new Windows.Web.Http.HttpClient())
            {
                Windows.Web.Http.HttpRequestMessage message = new Windows.Web.Http.HttpRequestMessage(
                    Windows.Web.Http.HttpMethod.Post, new Uri("http://pokeapi.co/api/v2/"));
                message.Content = new Windows.Web.Http.HttpStringContent(
                    JsonConvert.SerializeObject(item));

                message.Content.Headers.ContentType = new Windows.Web.Http.Headers.HttpMediaTypeHeaderValue("application/json");
                Windows.Web.Http.HttpResponseMessage response = await client.SendRequestAsync(message);

                if (response.IsSuccessStatusCode)
                {
                    isOk = true;
                }
            }

            return isOk;
        }*/
    }
}
