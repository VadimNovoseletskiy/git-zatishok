﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.BusinessLogicLayer.Models;
using NLayerApp.DataAccessLayer.Domains.Models;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;

namespace NLayerApp.BusinessLogicLayer.Handler
{
    public class DetailsInfoOutPutHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public DetailsInfoOutPutHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public DetailsInfoOutPutHandler() : this(new UnitOfWork())
        {
        }

        public ApartmentDetailsInfoViewModel  DetailsInfoObjectFind(int? id) =>
            this.unitOfWork
                .GenericRepository<Info>()
                .Get()
                .Where(x => x.Id == id)
                .Select(
                    p => new ApartmentDetailsInfoViewModel
                    {
                        Id = p.Id,
                        Village = p.Village.VillageName,
                        Region = p.Region.RegionName,
                        Street = p.Street.StreetName,
                        OperationType = p.OperationType,

                        FloorMaterial = p.FloorMaterial.NameFloorMaterils,
                        WallMaterial = p.WallMaterial.NameWallMaterils,
                        TotalAreaInfo = p.TotalAreaInfo,

                        ConditionOfApartment = p.Apartment.ConditionOfApartment,
                        RoomsApartment = p.Apartment.RoomsApartment,
                        RoomType = p.Apartment.TypeRoom,
                        ReadinessApartment = p.Apartment.ReadinessApartment,
                        BathRoomApartment = p.Apartment.BathRoomApartment,
                        BalconyApartment = p.Apartment.BalconyApartment,
                        FloorApartment = p.Apartment.FloorApartment,
                        TotalFloor = p.Apartment.TotalFloorApartment,
                        LivingAreaApartment = p.Apartment.LivingAreaApartment,
                        KitchenAreaApartment = p.Apartment.KitchenAreaApartment,

                        Boiler = p.AdditionalEquipment.BoilerAdditionalEquipment,
                        Intercom = p.AdditionalEquipment.IntercomAdditionalEquipment,
                        Internet = p.AdditionalEquipment.InternetAdditionalEquipment,
                        CableTv = p.AdditionalEquipment.CableTVadditionalEquipment,
                        FirePlace = p.AdditionalEquipment.FirePlaceAdditionalEquipment,
                        Air = p.AdditionalEquipment.AirConditioningAdditionalEquipment,
                        Furniture = p.AdditionalEquipment.FurnitureAdditionalEquipment,
                        Signaling = p.AdditionalEquipment.SignalingAdditionalEquipment,
                        SatelliteTv = p.AdditionalEquipment.SatelliteTVadditionalEquipment,
                        MyWindows = p.AdditionalEquipment.WindowsAdditionalEquipment,
                        Telephone = p.AdditionalEquipment.TelephoneAdditionalEqipment,
                        WashingMachine = p.AdditionalEquipment.WashingMachineAdditionalEqipment,

                        CaptionLink = p.NameCaptionLink,
                        NameInfo = p.NameInfo,
                        InfoDetails = p.DetailsInfo,
                        GrnPrice = p.GrnPrice,
                        DollarPrice = p.DollarPrice
                    }
                )
                .FirstOrDefault();

    }
}
