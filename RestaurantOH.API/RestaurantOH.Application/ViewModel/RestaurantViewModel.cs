using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOH.Application.ViewModel
{
    public class RestaurantViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan OpenHoursStart { get; set; }
        public TimeSpan OpenHoursEnd { get; set; }
    }
}
