using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NginxTest.Models
{
    public class CreateModel:PageModel
    {
        [BindProperty]
        public Customer Customer { get; set; }
        [HttpGet]
        public void OnGet()
        {
            this.Customer = new Customer() { Name = "xiaoping", Id = 1 };
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            System.IO.File.WriteAllText(@"d:/1.txt", Customer.Name);
            return RedirectToPage("/Index");
        }
    }
}
