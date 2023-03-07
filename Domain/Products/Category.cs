﻿namespace PedidosApp.Domain.Products;

public class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string CreateBy { get; set; }
    public DateTime CreateOn { get; set; }
    public DateTime EditedOn { get; set; }
}

