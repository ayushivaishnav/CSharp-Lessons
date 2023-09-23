using Microsoft.AspNetCore.Mvc.Rendering;

namespace NWind.Models
{
    public class OrderIdViewModel
    {
        public int Id { get; set; }
        public readonly List<SelectListItem> OrderIdSelectedList;
        public OrderIdViewModel(List<int>orderId)
        {
            OrderIdSelectedList = new List<SelectListItem>();
            foreach (var no in orderId) 
            { 
                OrderIdSelectedList.Add(new SelectListItem { Text=$"{no}", Value = $"{no}" });
            }
        }
    }
}
