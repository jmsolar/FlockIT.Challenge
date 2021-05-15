using Microsoft.Extensions.Options;
using Support.Domain;
using Support.DTOs;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TechnicalAPI.Extensions;
using TechnicalAPI.Services.Interfaces;

namespace TechnicalAPI.Services
{
    public class StateService : IStateService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly IOptions<ConfigExternalApi> _config;

        public StateService(IHttpClientFactory clientFactory, IOptions<ConfigExternalApi> config)
        {
            _clientFactory = clientFactory;
            _config = config;
        }

        public async Task<ApiResponse<StateResponse>> GetStateByName(string nombre) 
        {
            var result = new ApiResponse<StateResponse>();
            var urlConfig = _config.Value;
            var urlApi = string.Concat(urlConfig.urlBase, urlConfig.methodName, nombre);

            var request = new HttpRequestMessage(HttpMethod.Get, urlApi);
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                using var httpResponse = await response.Content.ReadAsStreamAsync();
                var res = await JsonSerializer.DeserializeAsync<Country>(httpResponse);
                var state = res.provincias.FirstOrDefault();
                if (state != null)
                {
                    var resp = new StateResponse(latitud: state.centroide.lat, longitud: state.centroide.lon){ };

                    result.Data = resp;
                }
                else result.Message = "Invalid state";

                result.Success = true;
            }
            else {
                result.Errors.Add(response.StatusCode.ToString());
            }

            return result;
        }
    }
}
