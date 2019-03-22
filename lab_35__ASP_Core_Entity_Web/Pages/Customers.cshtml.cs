using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab_35__ASP_Core_Entity_Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab_35__ASP_Core_Entity_Web.Pages
{
    public class CustomersModel : PageModel
    {

        private Northwind db;
        public IEnumerable<Customer> customers { get; set; }
        [BindProperty]
        public Customer customer { get; set; }

        public CustomersModel(Northwind injectedContext)
        {
            db = injectedContext;
        }

        // HTTP GET REQUEST 
        public void OnGet()
        {
            ViewData["Title"] = "List of Northwind Customers";
            customers = db.Customers.ToList<Customer>();
        }

        //HTTP POST
        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToPage("/Customers");
            }
            return Page();
        }



    }
}