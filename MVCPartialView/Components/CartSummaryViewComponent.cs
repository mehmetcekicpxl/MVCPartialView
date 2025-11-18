using Microsoft.AspNetCore.Mvc;

namespace MVCPartialView.Components
{
    public class CartSummaryViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            // fake data
            int productCount = 3;
            decimal totalPrice = 2970;

            return View((productCount, totalPrice));
        }
    }
}
