using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using new_pizza_delivery.Models;

namespace new_pizza_delivery.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza {get; set;}
        public float PizzaPrice { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
            if(Pizza.TomatoSauce)PizzaPrice += 1;
            if(Pizza.Cheese)PizzaPrice += 1;
            if(Pizza.Pepperoni)PizzaPrice += 2;
            if(Pizza.Anchovies)PizzaPrice += 2;
            if(Pizza.Mushrooms)PizzaPrice += 1;
            if(Pizza.Pineapple)PizzaPrice += 1;
            if(Pizza.Beef)PizzaPrice += 2;
            return RedirectToPage("/Checkout/Checkout",
            new { 
                Pizza.PizzaName, 
                PizzaPrice
            });
        }
    }
}