namespace teste_git
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
        public string? Enabled { get; set; }
        public int? EnabledTemperature { get; set; } = 0;
        public bool Teste { get; set; }
        public bool? Fax { get; set; }
    }
}