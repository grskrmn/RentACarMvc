using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MvcUI.Pages
{
    public class DetailModel : PageModel
    {
        
        public Model Model { get; set; } = new();
        private readonly IModelService _modelService;
        public string? ReturnUrl { get; set; } = "/";
        public Cart Cart { get; set; }

        public DetailModel(IModelService modelService, Cart cart)
        {
            _modelService = modelService;
            Cart = cart;
        }

        // public void OnGet(int id)
        // {
        //     var model = _modelService.GetModelById(id);
        //     Model = model;
        // }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(int id, string returnUrl)
        {
            var model = _modelService.GetModelById(id);
            if(model is not null)
            {
                Cart.CreateItem(model, DateTime.UtcNow, DateTime.UtcNow.AddDays(1));
            }
            return RedirectToPage(new {returnUrl = returnUrl});
        }
    }
}