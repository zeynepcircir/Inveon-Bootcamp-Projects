using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous_Programming.Services
{
    public class SyncService
    {
        public string ProcessDataSync()
        {
            System.Threading.Thread.Sleep(5000); 
            return "Sync işlem tamamlandı.";
        }
    }
}
