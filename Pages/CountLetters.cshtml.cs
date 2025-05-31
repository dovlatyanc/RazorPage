using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPage.Pages
{
    public class CountLettersModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public char Letter { get; set; } = '�';

        public int Count { get; set; }

        private const string Text = "��� ���, ������� �������� ����. � ��� �������, ������� � ������ ������ �������� � ����, ������� �������� ����. � ��� ������� �����-������, ������� ����� ������ �������, ������� � ������ ������ �������� � ����, ������� �������� ����.";

        public void OnGet()
        {
            Count = Text.ToLower()
                       .Count(c => c == char.ToLower(Letter));
        }
    }
}
