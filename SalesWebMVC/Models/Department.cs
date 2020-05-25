﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department() { }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller se)
        {
            Sellers.Add(se);
        }

        public void RemoveSeller(Seller se)
        {
            Sellers.Remove(se);
        }

        public double TotalSellers(DateTime initial, DateTime final)
        {
            return Sellers.Sum(se => se.TotalSales(initial,final));
        }
    }
}
