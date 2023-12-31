﻿using System.ComponentModel.DataAnnotations;

namespace TD.MinAPI;

public class ToDo
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Value { get; set; }
    public bool IsCompleted { get; set; }
}
