// CST-150 Milestone 5 – Business Logic Layer
// Author: Eric Gathinji
// Description: This class manages reading and holding inventory data using N-layer architecture.




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Business
{
    public class InventoryItem
    {
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }
        public string Category { get; set; }
        public DateTime DateAdded { get; set; }
    }
} 
