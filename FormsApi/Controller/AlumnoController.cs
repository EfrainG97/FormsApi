using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FormsApi.Model;
using Newtonsoft.Json;

namespace FormsApi.Controller
{
    internal class AlumnoController : IAlumno
    {
        private static HttpClient CrearCliente()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7296/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return httpClient;
        }

        private static readonly HttpClient client = CrearCliente();

        public async Task<List<Alumno>> GetAlumnos()
        {
            HttpResponseMessage response = await client.GetAsync("api/Alumno");
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var alumnos = JsonConvert.DeserializeObject<List<Alumno>>(jsonResponse);
                return alumnos;
            }
            return new List<Alumno>();
        }

        public async Task<bool> AgregarAlumno(Alumno alumno)
        {
            var json = JsonConvert.SerializeObject(alumno);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("api/Alumno", content);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> EliminarAlumno(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"api/Alumno/{id}");
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;

        }

        public async Task<bool> ActualizarAlumno(int id, Alumno alumno)
        {
            var json = JsonConvert.SerializeObject(alumno);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PutAsync($"api/Alumno/{id}", content);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<Alumno> ObtenerAlumnoID(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"api/Alumno/{id}");
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var alumnos = JsonConvert.DeserializeObject<Alumno>(jsonResponse);
                return alumnos;
            }
            return null;
        }
    }
}
