using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOH.Domain.Model
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan OpenHoursStart { get; set; }
        public TimeSpan OpenHoursEnd { get; set; }
    }
}
