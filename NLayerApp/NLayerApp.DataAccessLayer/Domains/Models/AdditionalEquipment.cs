﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DataAccessLayer.Domains.Models
{
    /// <summary>
    /// Describe additional equipment 
    /// </summary>
    public class AdditionalEquipment
    {


        public int Id { get; set; }


        /// <summary >
        /// Property Boiler 
        /// </summary>
        /// <value>
        /// Additional Equipment: Boiler 
        /// </value>
        public bool BoilerAdditionalEquipment { get; set; }


        /// <summary>
        /// Property Intercom
        /// </summary>
        /// <value>
        /// AdditionalEquipment :Intercom
        /// </value>
        public bool IntercomAdditionalEquipment { get; set; }


        /// <summary>
        /// Property Internet
        /// </summary>
        /// <value>
        /// Additional Equipment : Internet
        /// </value>
        public bool InternetAdditionalEquipment { get; set; }


        /// <summary>
        /// Property Cable TV
        /// </summary>
        ///<value>
        /// Additional Equipment : Cable TV
        /// </value>
        public bool CableTVadditionalEquipment { get; set; }


        /// <summary>
        /// Property Fireplace 
        /// </summary>
        /// <value>
        /// Additional Equipment : Fireplace 
        /// </value>
        public bool FirePlaceAdditionalEquipment { get; set; }


        /// <summary>
        /// Property Air Condition
        /// </summary>
        /// <value>
        /// Additional Equipment : Air Condition 
        /// </value>
        public bool AirConditioningAdditionalEquipment { get; set; }


        /// <summary>
        /// Property Signaling
        /// </summary>
        /// <value>
        /// Additional Equipment : Signaling 
        /// </value>
        public bool SignalingAdditionalEquipment { get; set; }


        /// <summary>
        /// Property Satellite TV
        /// </summary>
        /// <value>
        /// Additional Equipment :Satellite TV
        /// </value>
        public bool SatelliteTVadditionalEquipment { get; set; }


        /// <summary>
        /// Property Double glazed windows
        /// </summary>
        /// <value>
        /// Additional Equipment : Additional Equipment :
        /// </value>
        public bool WindowsAdditionalEquipment { get; set; }


        /// <summary>
        /// Property Telephone 
        /// </summary>
        /// <value>
        /// Additional Equipment :Telephone  
        /// </value>
        public bool TelephoneAdditionalEqipment { get; set; }
    }
}
