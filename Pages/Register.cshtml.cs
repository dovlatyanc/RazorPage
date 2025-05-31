using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Models;
using System;
using RazorPage.Data;
using RazorPage.Models;
namespace RazorPage.Pages;

public class RegisterModel : PageModel
{
    private readonly AppDbContext _context;

    [BindProperty]
    public User User { get; set; }

    public RegisterModel(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // ѕроверка уникальности email
        if (_context.Users.Any(u => u.Email == User.Email))
        {
            ModelState.AddModelError("User.Email", "Email уже зарегистрирован");
            return Page();
        }

        _context.Users.Add(User);
        _context.SaveChanges();

        return RedirectToPage("/Success");
    }
}
