// CST-150 Milestone 5 – Business Logic Layer
// Author: Eric Gathinji
// Description: This class manages reading and holding inventory data using N-layer architecture.



using System;
using System.Collections.Generic;
using System.IO;

namespace InventoryApp.Business
{
    public class Inventory
    {
        public List<InventoryItem> Items { get; private set; }

        public Inventory()
        {
            Items = new List<InventoryItem>();
            LoadInventoryFromFile();
        }

        private void LoadInventoryFromFile()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\Inventory.txt");
            
            try
            {
                if (File.Exists(path))
                {
                    string[] lines = File.ReadAllLines(path);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 5)
                        {
                            string desc = parts[0];
                            int qty = int.Parse(parts[1]);
                            decimal cost = decimal.Parse(parts[2]);
                            string category = parts[3];
                            DateTime date = DateTime.Parse(parts[4]);

                            Items.Add(new InventoryItem
                            {
                                Description = desc,
                                Quantity = qty,
                                Cost = cost,
                                Category = category,
                                DateAdded = date
                            });
                        }
                    }
                }
                else
                {
                    throw new FileNotFoundException("Inventory.txt not found at " + path);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading inventory file.", ex);
            }
        }
        
    }
}