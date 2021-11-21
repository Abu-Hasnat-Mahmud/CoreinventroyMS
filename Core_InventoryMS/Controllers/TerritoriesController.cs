using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_InventoryMS.Interfaces;
using Core_InventoryMS.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Core_InventoryMS.Controllers
{
    public class TerritoriesController : Controller
    {
        private readonly ITerritory territory;

        public TerritoriesController(ITerritory _territory)
        {
            territory = _territory;
        }

        // GET: /<controller>/
        public IActionResult Index(string searchString)
        {
            List<Territory> lstTerri = new List<Territory>();
            lstTerri = territory.GetAllTerritory().ToList();

            if (!string.IsNullOrEmpty(searchString))
            {
                lstTerri = territory.GetSearchResult(searchString).ToList();
            }
            return View(lstTerri);
        }


        public ActionResult AddEditTerritory(int territoryId)
        {
            Territory model = new Territory();
            if (territoryId > 0)
            {
                model = territory.GetTerritoryData(territoryId);
            }
            return PartialView("_TerritoryForm", model);
        }


        [HttpPost]
        public ActionResult Create(Territory newterritory)
        {
            if (ModelState.IsValid)
            {
                if (newterritory.TerritoryID > 0)
                {
                    territory.UpdateTerritory(newterritory);
                }
                else
                {
                    territory.AddTerritory(newterritory);
                }
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            territory.DeleteTerritory(id);
            return RedirectToAction("Index");
        }

    }
}
