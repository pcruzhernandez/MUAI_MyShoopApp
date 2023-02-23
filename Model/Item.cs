﻿namespace MyShoppingApp.Model
{
    public class Item
    {
        public int ItemID { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string SDescription { get; set; }
        public string LDescription { get; set; }
        public int QtyInStock { get; set; }
        public int RequestedAmount { get; set; }
    }
}
