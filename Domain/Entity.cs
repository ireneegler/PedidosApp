﻿namespace PedidosApp.Domain;

public abstract class Entity
{
    public Entity()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string CreateBy { get; set; }
    public string EditedBy { get; set; }
    public DateTime CreateOn { get; set; }
    public DateTime EditedOn { get; set; }
}
