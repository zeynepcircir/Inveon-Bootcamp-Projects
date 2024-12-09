using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous_Programming.Utilities
{
    public static class TaskHelpers
    {
        public static async Task RunExampleMethods()
        {
            Console.WriteLine("Task.WhenAll ile işlem başlatılıyor...");
            await Task.WhenAll(Task.Delay(1000), Task.Delay(2000));
            Console.WriteLine("Tüm işlemler tamamlandı!");

            Console.WriteLine("Task.WhenAny örneği...");
            var completedTask = await Task.WhenAny(Task.Delay(1000), Task.Delay(3000));
            Console.WriteLine($"İlk tamamlanan işlem: {completedTask.Status}");

            Console.WriteLine("Task.Run örneği...");
            var result = await Task.Run(() => Enumerable.Range(1, 10).Sum());
            Console.WriteLine($"Hesaplanan toplam: {result}");
        }
    }
}
