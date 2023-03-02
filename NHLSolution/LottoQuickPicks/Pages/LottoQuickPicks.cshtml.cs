using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LottoQuickPicks.Pages
{
    public class LottoQuickPicksModel : PageModel
    {
        [BindProperty]
        public string? Username { get; set; }

        [BindProperty]
        public string? LottoType { get; set; } = "Lotto649";
        [BindProperty]
        public int QuickPicks { get; set; } = 3;

        public string? InfoMessage { get; private set; }
        public string? ErrorMessage { get; private set; }

        public List<int[]> QuickPickNumbers { get; private set; } = new();

        public void OnPostGenerateNumbers()
        {
            if (string.IsNullOrWhiteSpace(Username))
            {
                ErrorMessage = "strong>usaername</strong> is required and cannot be blank";

            }
            else
            {
                QuickPickNumbers.Clear();

                Random rand = new();
                for (int quickCount = 1; quickCount <= QuickPicks; quickCount++)
                {
                    if (LottoType.ToUpper() == "LOTTO649")
                    {
                        int[] currentLottoQuickPicks = new int[6];
                        for (int count = 1; count <= 6; count++)
                        {
                            currentLottoQuickPicks[count - 1] = rand.Next(1, 50);
                        }

                        Array.Sort(currentLottoQuickPicks);
                        QuickPickNumbers.Add(currentLottoQuickPicks);

                    }
                }
                InfoMessage = $"hello {Username}";
            }
            
        }

        public IActionResult OnPostClear()
        {
            Username = null;
            InfoMessage = null;
            ErrorMessage = null;
            return RedirectToPage();
        }
        public void OnGet()
        {
        }
    }
}
