using Newtonsoft.Json;
using WebshipperSharp.Entities.PrinterJobs;

namespace WebshipperSharp.Endpoints.PrinterJobs
{
    public static class PrinterJobExtension
    {
        public static async Task<PrinterJobIdBody?> GetPrinterJobAsync(this WebshipperSharpService webshipperSharpService, long id) => JsonConvert.DeserializeObject<PrinterJobIdBody>(await (await webshipperSharpService.asyncRetryPolicy.ExecuteAsync(async () => await webshipperSharpService.httpClient.GetAsync($"printer_jobs/{id}"))).Content.ReadAsStringAsync());
    }
}
