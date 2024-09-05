using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    private static async Task AlarmMessage(string message)
    {
        var alarm = "http://t69.me";
        var key = "71b6ffb3-7cff-403e-a2f7-15e3d919f1e1";
        var client = new HttpClient();

        var data = new StringContent($"{{\"key\":\"{key}\",\"message\":\"{message}\"}}", Encoding.UTF8, "application/json");

        try
        {
            var response = await client.PostAsync(alarm, data);

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Alarm request failed with status {response.StatusCode}: {response.ReasonPhrase}");
            }
            else
            {
                Console.WriteLine("Alarm sent successfully");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Alarm error for {key}: {ex.Message}");
        }
    }

    static async Task Main(string[] args)
    {
        await AlarmMessage("😀 Hello World");
    }
}
