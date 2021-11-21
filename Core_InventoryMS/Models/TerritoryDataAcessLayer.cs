using Core_InventoryMS.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_InventoryMS.Models
{
    public class TerritoryDataAcessLayer : ITerritory
    {

        private CoreInventoryContext db;
        public TerritoryDataAcessLayer(CoreInventoryContext _db)
        { db = _db;}

        public IEnumerable<Territory> GetAllTerritory()
        {
            try
            {
                return db.Territory.ToList();
            }
            catch
            {
                throw;
            }
        }

        // To filter out the records based on the search string 
        public IEnumerable<Territory> GetSearchResult(string searchString)
        {
            List<Territory> exp = new List<Territory>();
            try
            {
                exp = GetAllTerritory().ToList();

                return exp.Where(x => x.TerritoryName.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) != -1);
            }
            catch
            {
                throw;
            }
        }
      
        //To Add new territory record  
        public void AddTerritory(Territory territory)
        {
            try
            {
                db.Territory.Add(territory);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
     
        //To Update the records of a particluar territory  

        public int UpdateTerritory(Territory territory)
        {
            try
            {
                db.Entry(territory).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Get the data for a particular territory  
        public Territory GetTerritoryData(int id)
        {
            try
            {
                Territory expense = db.Territory.Find(id);
                return expense;
            }
            catch
            {
                throw;
            }
        }


        //To Delete the record of a particular territory 
        public void DeleteTerritory(int id)
        {

            try
            {
                Territory emp = db.Territory.Find(id);
                db.Territory.Remove(emp);
                db.SaveChanges();

            }
            catch
            {
                throw;
            }
        }

    }
}
