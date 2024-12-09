using System;
using Asynchronous_Programming.Services;
using Asynchronous_Programming.Utilities;

class Program
{
    static async Task Main(string[] args)
    {
        var syncService = new SyncService();
        var asyncService = new AsyncService();

        Console.WriteLine("Sync metot çalıştırılıyor...");
        Console.WriteLine(syncService.ProcessDataSync());

        Console.WriteLine("\nAsync metot çalıştırılıyor...");
        Console.WriteLine(await asyncService.ProcessDataAsync());

        Console.WriteLine("\nTask metot örnekleri çalıştırılıyor...");
        await TaskHelpers.RunExampleMethods();

        Console.WriteLine("\nHata yönetimi ile async metot çalıştırılıyor...");
        var result = await asyncService.ProcessDataAsync();
    }
}
