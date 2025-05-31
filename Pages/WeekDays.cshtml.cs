using Microsoft.AspNetCore.Mvc.RazorPages;

public class WeekDaysModel : PageModel
{
    public string CurrentDay { get; set; }

    private static readonly string[] Days = {
        "Понедельник", "Вторник", "Среда",
        "Четверг", "Пятница", "Суббота", "Воскресенье"
    };

    public void OnGet()
    {
        int index = HttpContext.Session.GetInt32("dayIndex") ?? 0;
        CurrentDay = Days[index];

        index = (index + 1) % Days.Length;
        HttpContext.Session.SetInt32("dayIndex", index);
    }
}