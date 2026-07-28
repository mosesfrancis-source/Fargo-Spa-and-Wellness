<<<<<<< HEAD
﻿namespace Family_and_Spa_Wellness.Models;
=======
namespace Family_and_Spa_Wellness.Models;
>>>>>>> origin/main

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
<<<<<<< HEAD

    // "Client", "Provider", or "Admin" — single role per user, matching the
    // Admin User Role Management screen (one dropdown per user, not multi-role).
    public string Role { get; set; } = "Client";

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public string FullName => $"{FirstName} {LastName}".Trim();
}
=======
    public string Role { get; set; } = "Client";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
>>>>>>> origin/main
