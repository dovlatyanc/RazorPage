using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

public class QuadraticModel : PageModel
{
    [BindProperty]
    public double A { get; set; } = 1;

    [BindProperty]
    public double B { get; set; } = 2;

    [BindProperty]
    public double C { get; set; } = 1;

    [BindProperty]
    public double X { get; set; } = 0;

    public double? Result { get; set; }

    // Статический метод, возвращающий функцию
    public static Func<double, double> CreateQuadratic(double a, double b, double c)
    {
        return x => a * x * x + b * x + c;
    }

    public void OnPost()
    {
        var quadratic = CreateQuadratic(A, B, C);
        Result = quadratic(X);
    }
}