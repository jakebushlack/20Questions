using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TwentyQuestionsWebApp.Pages;

public class RulesModel : PageModel
{
    private readonly ILogger<RulesModel> _logger;

    public RulesModel(ILogger<RulesModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}