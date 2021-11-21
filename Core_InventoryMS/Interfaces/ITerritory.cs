using Core_InventoryMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_InventoryMS.Interfaces
{
  public interface ITerritory
    {
        IEnumerable<Territory> GetAllTerritory();
        IEnumerable<Territory> GetSearchResult(string searchString);
        void AddTerritory(Territory territory);
        int UpdateTerritory(Territory territory);
        Territory GetTerritoryData(int id);
        void DeleteTerritory(int id);
        
    }
}



//IList<Company> GetAllCompany(string username, string rolename);

//Company getCompanyDetails(string username, string rolename);

//int Insert(Company model);


//viewmodel

//public int CompanyId { get; set; }
//public string ComapayName { get; set; }
//public string Logo { get; set; }
//public string Address { get; set; }
//public string Tel { get; set; }
//public string Mobile { get; set; }
//public string Fax { get; set; }
//public string Email { get; set; }
//public string Web { get; set; }
//public string Slogan { get; set; }
//public string UserName { get; set; }
//public DateTime CreationDate { get; set; }