using Newtonsoft.Json;
using WebshipperSharp.Entities.PrinterClients;

namespace WebshipperSharp
{
    public static class PrinterClientExtension
    {
        //public static async Task<PrinterClientsBody?> GetPrinterClientsAsync(this WebshipperSharpService webshipperSharpService) => JsonConvert.DeserializeObject<PrinterClientsBody>(await (await webshipperSharpService.asyncRetryPolicy.ExecuteAsync(async () => await webshipperSharpService.httpClient.GetAsync($"printer_clients"))).Content.ReadAsStringAsync());
        public static async Task<PrinterClientIdBody?> GetPrinterClientAsync(this WebshipperSharpService webshipperSharpService, long id) => JsonConvert.DeserializeObject<PrinterClientIdBody>(await (await webshipperSharpService.asyncRetryPolicy.ExecuteAsync(async () => await webshipperSharpService.httpClient.GetAsync($"printer_clients/{id}"))).Content.ReadAsStringAsync());
        public static async Task<PrinterClientIdBody?> GetPrinterClientByPrinterJobIdAsync(this WebshipperSharpService webshipperSharpService, long id) => JsonConvert.DeserializeObject<PrinterClientIdBody>(await (await webshipperSharpService.asyncRetryPolicy.ExecuteAsync(async () => await webshipperSharpService.httpClient.GetAsync($"printer_jobs/{id}/printer_client"))).Content.ReadAsStringAsync());
        public static async Task<PrinterClientIdBody?> GetPrinterClientByShipmentIdAsync(this WebshipperSharpService webshipperSharpService, long id) => JsonConvert.DeserializeObject<PrinterClientIdBody>(await (await webshipperSharpService.asyncRetryPolicy.ExecuteAsync(async () => await webshipperSharpService.httpClient.GetAsync($"shipments/{id}/printer_client"))).Content.ReadAsStringAsync());
        public static async Task<PrinterClientIdBody?> GetPrinterClientByOrderIdAsync(this WebshipperSharpService webshipperSharpService, long id) => JsonConvert.DeserializeObject<PrinterClientIdBody>(await (await webshipperSharpService.asyncRetryPolicy.ExecuteAsync(async () => await webshipperSharpService.httpClient.GetAsync($"orders/{id}/printer_client"))).Content.ReadAsStringAsync());
    }
}
