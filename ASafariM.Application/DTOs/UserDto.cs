using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Enums;

namespace ASafariM.Application.DTOs;

public class UserDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? UserName { get; set; }
    public string Email { get; set; } = string.Empty;
    public bool IsAdmin { get; set; }
    public bool IsActive { get; set; }

    // createdAt, updatedAt, lastLogin, isdeleted
    public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;
    public bool IsDeleted { get; set; } = false;
    public DateTime? DeletedAt { get; set; } = null;
    public DateTime? LastLogin { get; set; } = null; // Timestamp of the user's last login,
    public string? Biography { get; set; }
    public string? Remark { get; set; }
    public string? ProfilePicture { get; set; }
    public string? Address { get; set; }
    public DateTime? DateOfBirth { get; set; }
}
