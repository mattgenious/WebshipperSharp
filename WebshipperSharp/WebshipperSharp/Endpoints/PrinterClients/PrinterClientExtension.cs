using Newtonsoft.Json;
using WebshipperSharp.Entities.PrinterClients;

namespace WebshipperSharp.Endpoints.PrinterClients
{
    public static class PrinterClientExtension
    {
        public static async Task<PrinterClient?> GetPrinterClientAsync(this WebshipperSharpService webshipperSharpService, long id) => JsonConvert.DeserializeObject<PrinterClient>(await (await webshipperSharpService.asyncRetryPolicy.ExecuteAsync(async () => await webshipperSharpService.httpClient.GetAsync($"/printer_clients/{id}"))).Content.ReadAsStringAsync());
        public static async Task<PrinterClient?> GetPrinterClientByPrinterJobIdAsync(this WebshipperSharpService webshipperSharpService, long id) => JsonConvert.DeserializeObject<PrinterClient>(await (await webshipperSharpService.asyncRetryPolicy.ExecuteAsync(async () => await webshipperSharpService.httpClient.GetAsync($"/printer_jobs/{id}/printer_client"))).Content.ReadAsStringAsync());
    }
}
