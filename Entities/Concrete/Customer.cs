﻿
using CleanCodeDemo.Entities.Abstract;
public class Customer : ICustomer, IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    //public bool IsStudent { get; set; }
    //public bool IsOfficer { get; set; }
}
