using System.Text;

public class TemperatureManager
{
    private int[,] temperatures;
    private readonly string[] monthNames =
    {
        "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
        "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
    };

    public TemperatureManager()
    {
        temperatures = new int[12, 30];
        Random rnd = new Random();
        for (int i = 0; i < 12; i++)
            for (int j = 0; j < 30; j++)
                temperatures[i, j] = rnd.Next(-20, 55);
    }

    public (string Month, double Avg)[] GetMonthlyAverages()
    {
        var averages = new (string Month, double Avg)[12];

        for (int i = 0; i < 12; i++)
        {
            int sum = 0;
            for (int j = 0; j < 30; j++)
                sum += temperatures[i, j];

            averages[i] = (monthNames[i], sum / 30.0);
        }

        Array.Sort(averages, (x, y) => x.Avg.CompareTo(y.Avg));
        return averages;
    }

    public string GetFormattedAverages()
    {
        var sortedAverages = GetMonthlyAverages();
        StringBuilder sb = new StringBuilder();

        foreach (var month in sortedAverages)
        {
            sb.AppendLine($"{month.Month,-10}: {month.Avg,6:F1}°C");
        }

        return sb.ToString();
    }
}