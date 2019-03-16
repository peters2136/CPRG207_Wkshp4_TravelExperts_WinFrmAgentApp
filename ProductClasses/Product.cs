using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClasses
{
    /// <summary>
    /// Product class object for the TravelExperts database 
    /// </summary>
    /// Author: Stuart Peters
    /// Date: March 2019
    public class Product
    {
        //properties
        public int ProductID { get; set;}

        public string ProductName { get; set; }

        //constructor
        public Product() { }

        public Product(int i, string n)
        {
            ProductID = i;
            ProductName = n;
        }

        //methods
        public override string ToString()
        {
            return "Product ID: " + ProductID + " Name: " + ProductName;
        }

    }
}
