﻿namespace CampervanProject_Backend.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}