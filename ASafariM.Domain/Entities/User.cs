using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASafariM.Domain.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required, EmailAddress, MaxLength(255)]
        public string Email { get; set; } = string.Empty;

        [MaxLength(255)]
        public string NormalizedEmail { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [MaxLength(50)]
        public string? UserName { get; set; }

        [MaxLength(50)]
        public string? NormalizedUserName { get; set; }

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        public bool IsAdmin { get; set; } = false;

        public Guid? UserId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }
        public string? ProfilePicture { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public Guid? DeletedBy { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime? DateOfBirth { get; set; }
        public DateTime? LastLogin { get; set; }
        public int FailedLoginAttempts { get; set; } = 0;
        public bool IsLockedOut { get; set; } = false;
        public DateTime? LockoutEnd { get; set; }
        public string? SecurityStamp { get; set; }
        public string? ConcurrencyStamp { get; set; }

        [Phone]
        public string? PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; } = false;
        public bool EmailConfirmed { get; set; } = false;
        public string? Remark { get; set; }

        // Navigation properties for preferences
        public ICollection<UserPreference> Preferences { get; set; } = [];
        public UserPreference Preference { get; set; } = null; // Navigation property for the user's preference

        // Author-specific properties
        [MaxLength(50)]
        public string? PenName { get; set; }

        [Url]
        public string? Website { get; set; }

        [MaxLength(1000)]
        public string? Biography { get; set; }

        // Navigation properties

        // Role-based relationships
        public ICollection<UserRole> UserRoles { get; set; } = [];

        // A user can author multiple MarkdownFiles
        public ICollection<MarkdownFile> AuthoredMarkdownFiles { get; set; } =
            new List<MarkdownFile>();

        // A user can collaborate on multiple MarkdownFiles
        public ICollection<MarkdownFile> CollaboratedMarkdownFiles { get; set; } =
            new List<MarkdownFile>();

        // The projects this user has created (is the owner of).
        public ICollection<Project> OwnedProjects { get; set; } = new List<Project>();

        // A user can manage or be a member of multiple Projects
        public ICollection<Project> ManagedProjects { get; set; } = new List<Project>();

        // A user can be a member/manager of multiple projects (through ProjectMember).
        public ICollection<ProjectMember> ProjectMemberships { get; set; } =
            new List<ProjectMember>();

        public ICollection<MarkdownFileUser> MarkdownFileUsers { get; set; } =
            new List<MarkdownFileUser>();
    }
}
