using Newtonsoft.Json;
using WebshipperSharp.Entities.Printers;

namespace WebshipperSharp
{
    public static class PrinterExtension
    {
        public static async Task<Printer?> GetPrinterAsync(this WebshipperSharpService webshipperSharpService, long id) => JsonConvert.DeserializeObject<Printer>(await (await webshipperSharpService.asyncRetryPolicy.ExecuteAsync(async () => await webshipperSharpService.httpClient.GetAsync($"printers/{id}"))).Content.ReadAsStringAsync());
        public static async Task<Printer?> GetPrinterByPrinterJobIdAsync(this WebshipperSharpService webshipperSharpService, long id) => JsonConvert.DeserializeObject<Printer>(await (await webshipperSharpService.asyncRetryPolicy.ExecuteAsync(async () => await webshipperSharpService.httpClient.GetAsync($"printer_jobs/{id}/printer"))).Content.ReadAsStringAsync());
    }
}
