using System;

namespace CategoryApp.Models;

public class PCategory
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }

}
