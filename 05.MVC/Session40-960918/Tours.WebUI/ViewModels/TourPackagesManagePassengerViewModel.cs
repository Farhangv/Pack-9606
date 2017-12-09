using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tours.Models;

namespace Tours.WebUI.ViewModels
{
    public class TourPackagesManagePassengerViewModel
    {
        public int TourId { get; set; }
        public int PassengerId { get; set; }

        public IEnumerable<Passenger> Passengers { get; set; }
    }
}