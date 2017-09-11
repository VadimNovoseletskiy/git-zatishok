﻿
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Domains.Models;

namespace NLayerApp.DataAccessLayer.Domains
{
    public class MyContextInitializer:DropCreateDatabaseAlways<MyContext>
    {
        protected override void Seed(MyContext dbContext)
        {
            //add village
            Village v0 = new Village { VillageName = "VillageName_0" };
            Village v1 = new Village { VillageName = "VillageName_1" };
            Village v2 = new Village { VillageName = "VillageName_2" };
            Village v3 = new Village { VillageName = "VillageName_3" };

            dbContext.Villages.AddRange(new List<Village> {v0, v1, v2, v3 });

            //add region
            Region r0 = new Region { RegionName = "RegionName_0" };
            Region r1 = new Region { RegionName = "RegionName_1" };
            dbContext.Regions.AddRange(new List<Region> {r0, r1});

            //add info
            Info i0=new Info
            {
                NameInfo = "Продам 1 но кімнатну квартиру ",
                DetailsInfo = " Квартира знаходиться у 10 секції на 4 поверсі, на стадії будівництва було перепланування у якому була збільшена кухня",
                Type = 1,
                DollarPrice = 3400000,
                GrnPrice = 101001093,
                TotalAreaInfo = 123,
                Village= v0,
                Region = r1
            };
            Info i1=new Info
            {
                NameInfo = "Продам хороший будинок біля лісу",
                DetailsInfo = "Продам гарний будинок в їорошому районі, з усіма удобствами, готовий до проживаня. Можливий торг.",
                Type = 2,
                DollarPrice = 7000000,
                GrnPrice = 302001093,
                TotalAreaInfo = 656,
                Village = v2,
                Region = r1
            };

            Info i2=new Info
            {
                NameInfo = "Продам Крммерційну нерухомість",
                DetailsInfo = "Детальна інформація про коммерційну нерухомість ",
                Type = 3,
                DollarPrice = 8000000,
                GrnPrice = 402001093,
                TotalAreaInfo = 756.4f,
                Village = v3,
                Region = r0
            };

            Info i3=new Info
            {
                NameInfo = "Коротке повідомлення про продаж  земельної ділянки ",
                DetailsInfo = "Детальна інформація про продаж зеельної ділянки ",
                Type = 4,
                DollarPrice = 9000000,
                GrnPrice = 502001093,
                TotalAreaInfo = 756.4f,
                Village = v0,
                Region = r1
            };

            dbContext.Infos.AddRange(new List<Info> {i1, i0,i2});

            //add apartments 
            Apartment ap0=new Apartment
            {
                Id =i0.Id, 
                TotalFloorApartment = 10,
                BalconyApartment = 1,
                BathRoomApartment = "смежная",
                FloorApartment = 4,
                KitchenAreaApartment = 40.7f,
                LivingAreaApartment = 80.6f,
                RoomsApartment = 5,
                ReadinessApartment = "готовность к вселению",
                Info = i0


            };
           

            dbContext.Apartments.AddRange(new List<Apartment> {ap0});
            
            
            //add House
            House h0=new House
            {
                Id = i1.Id,
                TypeHouse = "коттедж",
                FloorHouse = 2,
                KitchenAreaHouse = 25.4f,
                LandAreaHouse = 50.4f,
                LivingAreaHouse = 100.4f,
                PartHouse = "1/2",
                RoomsHouse = 12,
                Info = i1
            };

            dbContext.Houses.Add(h0);

            //add Commercial
            Commercial c0=new Commercial
            {   Id=i2.Id,
                TypeCommercial = "Офісно адміністративне",
                EffectiveAreaCommercial = 25.7f,
                LandAreaCommercial = 46.5f,
                FloorCommercial = 4,
                StateCommercial = "відмінний",
                TotalFloorCommercial = 10,
                Info = i2

            };

            dbContext.Commercials.Add(c0);

            Land l0=new Land
            {
                Id=i3.Id,
                Info = i3,
                LandArea = 120.4f,
                SpecialLand = "сільсько господарське"

            };

            dbContext.Land.Add(l0);


            //add Communication
            Communication cm0=new Communication
            {
                Id = l0.Id,
                AutonomousWaterCommunications = true,
                AutonomousSewerageCommunications = false,
                AutonomusHeatingCommunications = false,
                CentralHeatingCommunications = false,
                CentralSewerageCommunications = false,
                CentralWaterCommunications = true,
                ElectricityCommunications = true,
                GasCommunications = false,
                Land = l0

            };

            Communication cm1=new Communication
            {
                Id = c0.Id,
                AutonomousWaterCommunications = false,
                AutonomousSewerageCommunications = false,
                AutonomusHeatingCommunications = true,
                CentralHeatingCommunications = false,
                CentralSewerageCommunications =true,
                CentralWaterCommunications = true,
                ElectricityCommunications = true,
                GasCommunications = true,
                Commercial = c0
                
            };

            Communication cm2=new Communication
            {
                Id = h0.Id,
                AutonomousWaterCommunications = true,
                AutonomousSewerageCommunications = true,
                AutonomusHeatingCommunications = true,
                CentralHeatingCommunications = true,
                CentralSewerageCommunications = true,
                CentralWaterCommunications = true,
                ElectricityCommunications = true,
                GasCommunications = true,
                House = h0
            };

            Communication cm3=new Communication
            {
                Id = ap0.Id,
                AutonomousWaterCommunications = true,
                AutonomousSewerageCommunications = true,
                AutonomusHeatingCommunications = true,
                CentralHeatingCommunications = true,
                CentralSewerageCommunications = true,
                CentralWaterCommunications = true,
                ElectricityCommunications = true,
                GasCommunications = true,
                Apartment = ap0
            };
            dbContext.Communications.AddRange(new List<Communication> {cm0,cm1,cm2,cm3});

            //add OutBuildigs
            OutBuilding otbl0=new OutBuilding
            {
                Id=h0.Id,
                BahtHouseOutBuilding = true,
                BarnOutBuildings = false,
                GarageOutBuildings = true,
                GreenHouseOutBuildings = false,
                SummerKitchenOutBuildings = true,
                SwimmingOutBuildings = false,
                Well1OutBuildings = true,
                WellOutBuildings = false,
                House = h0

            };
            dbContext.OutBuildings.Add(otbl0);

            //add AdditionalEquipment

            AdditionalEquipment ad0=new AdditionalEquipment
            {
                Id = ap0.Id,
                AirConditioningAdditionalEquipment = true,
                BoilerAdditionalEquipment = true,
                CableTVadditionalEquipment = false,
                FirePlaceAdditionalEquipment = false,
                IntercomAdditionalEquipment = false,
                InternetAdditionalEquipment = true,
                SatelliteTVadditionalEquipment = true,
                SignalingAdditionalEquipment = false,
                Apartment = ap0
            };

            AdditionalEquipment ad1=new AdditionalEquipment
            {
                Id = h0.Id,
                AirConditioningAdditionalEquipment = true,
                BoilerAdditionalEquipment = true,
                CableTVadditionalEquipment = false,
                FirePlaceAdditionalEquipment = false,
                IntercomAdditionalEquipment = false,
                InternetAdditionalEquipment = true,
                SatelliteTVadditionalEquipment = true,
                SignalingAdditionalEquipment = false,
                House= h0
            };

            dbContext.AdditionalEquipments.AddRange(new List<AdditionalEquipment> {ad0,ad1});

            //add wall materials
            //WallMaterial w0=new WallMaterial {NameWallMaterils = "NameWallMaterils_0" };
            //WallMaterial w1 = new WallMaterial { NameWallMaterils = "NameWallMaterils_1" };
            //WallMaterial w2 = new WallMaterial { NameWallMaterils = "NameWallMaterils_2" };

            //add floor materials 
            //FloorMaterial fm0=new FloorMaterial {NameFloorMaterils = "NameFloorMaterils_0" };
            //FloorMaterial fm1 = new FloorMaterial { NameFloorMaterils = "NameFloorMaterils_1" };
            //FloorMaterial fm2 = new FloorMaterial { NameFloorMaterils = "NameFloorMaterils_2" };



            dbContext.SaveChanges();
        }
    }
}
