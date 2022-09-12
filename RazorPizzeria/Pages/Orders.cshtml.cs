using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class OrdersModel : PageModel
    {
		private readonly ApplicationDbContext context;
		public List<PizzaOrder> Orders = new List<PizzaOrder>();

        public OrdersModel(ApplicationDbContext context)
		{
			this.context = context;
		}
        public void OnGet()
        {
            Orders = context.PizzaOrders.ToList();
        }
    }
}
