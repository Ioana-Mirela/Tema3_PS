using MvcShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcShop.Controllers
{
    public class Item
    {
        private Product prod = new Product();

        public Product Prod
        {
            get { return prod; }
            set { prod = value; }
        }


        private int quant;

        public int Quant
        {
            get { return quant; }
            set { quant = value; }
        }


        public Item()
        { }

        public Item(Product product, int quantity)
        {
            this.prod = product;
            this.quant = quantity;
        }

    }
}