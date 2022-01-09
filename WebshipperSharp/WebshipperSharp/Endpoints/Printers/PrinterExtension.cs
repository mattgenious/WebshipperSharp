using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshipperSharp.Entities.Printers;

namespace WebshipperSharp.Services.Endpoints.Printers
{
    public static class PrinterExtension
    {
        public static async Task<Printer?> GetPrinterAsync(this WebshipperSharpService webshipperSharpService, long id) => JsonConvert.DeserializeObject<Printer>(await (await webshipperSharpService.asyncRetryPolicy.ExecuteAsync(async () => await webshipperSharpService.httpClient.GetAsync($"/printers/{id}"))).Content.ReadAsStringAsync());
        public static async Task<Printer?> GetPrinterByPrinterJobIdAsync(this WebshipperSharpService webshipperSharpService, long id) => JsonConvert.DeserializeObject<Printer>(await (await webshipperSharpService.asyncRetryPolicy.ExecuteAsync(async () => await webshipperSharpService.httpClient.GetAsync($"/printer_jobs/{id}/printer"))).Content.ReadAsStringAsync());
    }
}
