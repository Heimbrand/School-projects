﻿namespace DataAccess.Entities;

public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public List<Tag> Tags { get; set; } = new();

}
