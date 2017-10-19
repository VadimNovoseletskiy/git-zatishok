﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Domains.Models;

namespace NLayerApp.BusinessLogicLayer.Models
{
    public class HouseInputParameters
    {
        public PropertyType Type = PropertyType.House;
  //Address
        public int Village { get; set; }
        public int Region { get; set; }
        public int Street { get; set; }
        public string NumberAdress { get; set; }
        public TypeOfOperation OperationType { get; set; }

  //Details Info  
        public TypeOfHouse TypeHouse { get; set; }//
        public PartOfHouse PartHouse { get; set; }//
        public ConditionOfHouse ConditionHouse { get; set; }
        public int RoomsHouse { get; set; }//
        public int FloorHouse { get; set; }//
        public int FloorMaterial { get; set; }
        public int WallMaterial { get; set; }
        public float TotalAreaInfo { get; set; }
        public float LivingAreaHouse { get; set; }//
        public float KitchenAreaHouse { get; set; }//
        public float LandAreaHouse { get; set; }//

        //Additional Equipment 
        public bool Boiler { get; set; }
        public bool Intercom { get; set; }
        public bool Internet { get; set; }
        public bool CableTv { get; set; }
        public bool FirePlace { get; set; }
        public bool Air { get; set; }
        public bool Furniture { get; set; }
        public bool Signaling { get; set; }
        public bool SatelliteTv { get; set; }
        public bool MyWindows { get; set; }
        public bool Telephone { get; set; }
        public bool WashingMachine { get; set; }

        //OutBuildings
        public bool BahtHouse { get; set; }
        public bool Swimming { get; set; }
        public bool Garage { get; set; }
        public bool Well { get; set; }
        public bool SummerKitchen { get; set; }
        public bool WorkShop { get; set; }
        public bool Barn { get; set; }
        public bool Well1 { get; set; }
        public bool GreenHouse { get; set; }


        //communications
        public bool Gas { get; set; }
        public bool RailWay { get; set; }
        public bool CentralSewerage { get; set; }
        public bool CentralWater { get; set; }
        public bool CentralHeating { get; set; }
        public bool Electricity { get; set; }
        public bool AutonomousSewerage { get; set; }
        public bool AutonomusHeating { get; set; }
        public bool AutonomousWater { get; set; }
        //Describes object
        public string CaptionLink { get; set; }
        public string NameInfo { get; set; }
        public string InfoDetails { get; set; }
        public string InfoPrivat { get; set; }
   //Money
        public int GrnPrice { get; set; }
        public int DollarPrice { get; set; }
    }
}

