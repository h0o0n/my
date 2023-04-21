using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTest
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF { get; set; }
        public string Summary { get; set; }
    }

    public class WeatherForecastService
    {
        private static string[] summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild",
            "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();

            return Task.FromResult(Enumerable.Range(1, 5).Select(idx => new WeatherForecast //1부터 5까지의 랜덤한 정수 중 선택 idx에 저장
            {
                Date = startDate.AddDays(idx), // 지정한 날짜 부터 +5일 까지의 결과 확인 가능
                TemperatureC = rng.Next(-20, 55), // 랜덤한 온도 -20도 부터 55 까지의 랜덤한 정수
                Summary = summaries[rng.Next(summaries.Length)] //summaries 의 내용중 랜덤한 1개 변수에 저장
            }).ToArray());
        }
    }

    class WeatherForecastApp
    {
        static async Task Main()
        {
            var service = new WeatherForecastService();
            var forecasts = await service.GetForecastAsync(DateTime.Now);

            Console.WriteLine("Date\t\tTemp. (C)\tTemp. (F)\tSummary");
            foreach (var f in forecasts)
            {
                Console.WriteLine($"{f.Date.ToShortDateString()}\t" +
                    $"{f.TemperatureC}\t\t{f.TemperatureF}\t\t{f.Summary}");
            }
        }
    }
}
