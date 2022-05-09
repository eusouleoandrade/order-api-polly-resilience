using System.Text;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OAPR.Application.Exceptions;
using OAPR.Application.Interfaces;
using OAPR.Domain.Entities;
using OAPR.Infra.Notification.Abstractions;

namespace OAPR.Infra.BackOfficeIntegration.Services
{
    public class OrderIntegrationService : Notifiable, IOrderIntegrationService
    {
        private readonly HttpClient _httpClient;
        ILogger<OrderIntegrationService> _logger;

        public OrderIntegrationService(IHttpClientFactory httpClientFactory, ILogger<OrderIntegrationService> logger)
        {
            _httpClient = httpClientFactory.CreateClient("OrderIntegrationService");
            _logger = logger;
        }

        public async Task UpdateOrderAsync(Order entity)
        {
            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");

                var httpResponseMessage = await _httpClient.PutAsync("order", content);

                if (!httpResponseMessage.IsSuccessStatusCode)
                    AddErrorNotification("Error updating order in integration");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);

                // TODO: Implement global exception handling
                throw new ApiException(ex.Message);
            }
            finally
            {
                _httpClient?.Dispose();
            }
        }
    }
}