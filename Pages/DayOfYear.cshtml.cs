using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace RazorPage.Pages
{
    public class DayOfYearModel : PageModel
    {
        [BindProperty]
        [Range(1, 365, ErrorMessage = "„исло должно быть от 1 до 365")]
        public int DayNumber { get; set; } = 1;

        public string Result { get; set; }

        private static readonly int[] DaysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly string[] Months = {
        "€нвар€", "феврал€", "марта", "апрел€", "ма€", "июн€",
        "июл€", "августа", "сент€бр€", "окт€бр€", "но€бр€", "декабр€"
    };

        public void OnPost()
        {
            int remainingDays = DayNumber;
            int month = 0;

            while (remainingDays > DaysInMonth[month])
            {
                remainingDays -= DaysInMonth[month];
                month++;
            }

            Result = $"{remainingDays} {Months[month]}";
        }
    }
}
