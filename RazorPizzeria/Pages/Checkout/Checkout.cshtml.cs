using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Checkout
{
	[BindProperties(SupportsGet = true)]
	public class CheckoutModel : PageModel
	{
		private readonly ApplicationDbContext _context;

		public string PizzaName { get; set; }
		public float PizzaPrice { get; set; }
		public string ImageTitle { get; set; }

		public CheckoutModel(ApplicationDbContext context)
		{
			this._context = context;
		}

		public void OnGet()
		{
			if (string.IsNullOrWhiteSpace(PizzaName))
				PizzaName = "custom";

			if (string.IsNullOrWhiteSpace(ImageTitle))
				ImageTitle = "Create";

			var pizzaOrder = new PizzaOrder();
			pizzaOrder.PizzaName = PizzaName;
			pizzaOrder.BasePrice = PizzaPrice;

		}
	}
}
