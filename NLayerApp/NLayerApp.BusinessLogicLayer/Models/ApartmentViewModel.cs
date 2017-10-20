﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Domains.Models;

namespace NLayerApp.BusinessLogicLayer.Models
{
     public  class ApartmentViewModel
    {
         public int Id { get; set; }
         public string CaptionLink { get; set; }
         public string Village{ get; set; }
         public string Region { get; set; }
         public SpecialFloorApartment Floor { get; set; }
         public SpecialRoomsApartment NumberOfRooms { get; set; }
         public float TotalAreaInfo { get; set; }
         public int DollarPrice { get; set; }
         public int GrnPrice { get; set; }
         public string NameInfo { get; set; }

    }
}
