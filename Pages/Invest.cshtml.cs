using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace asp_webpage.Pages
{
    public class InvestModel : PageModel
    {
        private readonly ILogger<InvestModel> _logger;

        public InvestModel(ILogger<InvestModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
