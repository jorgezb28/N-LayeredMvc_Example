using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppService.AppService;
using AppService.Dto;
using AppService.IAppService;
using AutoMapper;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStoreAppService _storeAppService;

        public HomeController()
        {
            this._storeAppService = new StoreAppService();
        }

        // GET: Home
        public ActionResult Index()
        {
            var allStores = _storeAppService.GetAllStores();

            return View(allStores);
        }

        public ActionResult Create()
        {
            var newStore = new StoreDto();
            return View(newStore);
        }

        [HttpPost]
        public ActionResult SaveStore(StoreDto newStore)
        {
            var result = _storeAppService.CreateNewStore(newStore);

            return RedirectToAction("Index");
        }

        public ActionResult StoreDetail(int storeId)
        {
            var store = _storeAppService.GetStoreById(storeId);
            return View(store);
        }

        public ActionResult UpdateStore(StoreDto storeToUpdate)
        {
            var updatedStore = _storeAppService.UpdateDto(storeToUpdate);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteStore(StoreDto storeToDelete)
        {
            _storeAppService.Remove(storeToDelete);
            return RedirectToAction("Index");
        }
    }
}