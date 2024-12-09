using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous_Programming.Services
{
    public class AsyncService
    {
        public async Task<string> ProcessDataAsync()
        {
            await Task.Delay(5000);
            return "Async işlem tamamlandı.";
        }
    }
}
