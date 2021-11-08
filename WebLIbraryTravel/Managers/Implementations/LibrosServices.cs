
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebLIbraryTravel.Managers.Services;
using WebLIbraryTravel.Models;

namespace WebLIbraryTravel.Managers.Implementations
{
    public class LibrosServices : ILibrosServices
    {
        private readonly IConfiguration _config;
        HttpClient client = new HttpClient();
        public LibrosServices(IConfiguration configuration)
        {
            _config = configuration;

        }
         
        public async Task<Response<Libro>> GetAll()
        {
            var response = new Response<Libro>();
            try
            {
                client.BaseAddress = new Uri("https://localhost:44313");
                var res = await client.GetAsync("api/Libros");
                if (res.IsSuccessStatusCode)
                {
                    var results = res.Content.ReadAsStringAsync().Result;
                    response.Lst = JsonConvert.DeserializeObject<List<Libro>>(results);
                }
                else
                {
                    response.Error = true;
                }
            }
            catch (Exception ex)
            {
                response.Error = true;
            }
            return response;
        }

        public async Task<Response<Libro>> GetDetails(int id)
        {
            var response = new Response<Libro>();
            try
            {
                client.BaseAddress = new Uri("https://localhost:44313");
                var url = "api/Libros/" + id;
                var res = await client.GetAsync(url);
                if (res.IsSuccessStatusCode)
                {
                    var results = res.Content.ReadAsStringAsync().Result;
                    response.UnitResp = JsonConvert.DeserializeObject<Libro>(results);
                }
                else
                {
                    response.Error = true;
                }
            }
            catch (Exception ex)
            {
                response.Error = true;
            }
            return response;
        }
    }
}
