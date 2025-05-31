using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace RazorPage.Pages;

public class SeriesModel : PageModel
{
    [BindProperty]
    [Range(-0.999, 0.999, ErrorMessage = "|x| должен быть < 1")]
    public double X { get; set; } = 0.5;

    [BindProperty]
    [Range(0.00001, 0.1, ErrorMessage = "Точность 0.00001 - 0.1")]
    public double Precision { get; set; } = 0.001;

    public double Sum { get; private set; }
    public int TermsCount { get; private set; }

    public void OnPost()
    {
        if (!ModelState.IsValid) return;

        double currentTerm = X;
        Sum = 0;
        TermsCount = 0;
        int n = 1;

        while (Math.Abs(currentTerm) >= Precision)
        {
            Sum += currentTerm;
            TermsCount++;
            n++;
            currentTerm = X / n; // Следующий член ряда
        }
    }
}
