using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MvcUI.Pages
{
    public class CheckOut : PageModel
    {
        private readonly ILogger<CheckOut> _logger;

        public CheckOut(ILogger<CheckOut> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}