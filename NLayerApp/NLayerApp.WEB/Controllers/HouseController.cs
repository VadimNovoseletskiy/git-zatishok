﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;
using NLayerApp.WEB.Handler;

namespace NLayerApp.WEB.Controllers
{
    public class HouseController : Controller
    {
        IUnitOfWork unitOfWork=new UnitOfWork();

        // GET: House
        public ActionResult Index()
        {
            MySelect();
            return View();
        }


        //POST:House(form) 
        public ActionResult Index()
        {
            MySelect();
            return View();
        }

        void MySelect()
        {
            RegionHandler myRegionHandler=new RegionHandler(unitOfWork);
            var resultRegion = myRegionHandler.GetRegion();
            SelectList listRegion=new SelectList(resultRegion,"Id","Value");
            ViewBag.regionName = listRegion;

            VillageHandler myVillageHandler=new VillageHandler(unitOfWork);
            var resultVillage = myVillageHandler.GetVillage();
            SelectList listVillage=new SelectList(resultVillage, "Id", "Value");
            ViewBag.villageName = listVillage;
        }
    }
}