﻿namespace MultiTenantDbApp.Domain.Company.Entities;
public sealed class ShoppingCart
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}