using System;
using System.Collections.Generic;

namespace Core_InventoryMS.Models
{
    public partial class Territory
    {
        public int TerritoryId { get; set; }
        public string TerritoryName { get; set; }
        public string Note { get; set; }
        public string EnteredBy { get; set; }
        public bool Estatus { get; set; }
    }
}
