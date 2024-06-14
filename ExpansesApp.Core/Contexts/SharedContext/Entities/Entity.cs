﻿namespace ExpansesApp.Core.Contexts.SharedContext.Entities;
public abstract class Entity
{
    public Guid Id { get; set; }
    public Entity()
    {
        Id = Guid.NewGuid();
    }
}
