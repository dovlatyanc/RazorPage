using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPage.Pages
{
    public class CountLettersModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public char Letter { get; set; } = 'а';

        public int Count { get; set; }

        private const string Text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится В доме, Который построил Джек. А это веселая птица-синица, Которая часто ворует пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";

        public void OnGet()
        {
            Count = Text.ToLower()
                       .Count(c => c == char.ToLower(Letter));
        }
    }
}
