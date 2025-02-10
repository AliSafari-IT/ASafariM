using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ASafariM.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace ASafariM.Domain.Entities
{
    public class User
        : IdentityUser<Guid>,
            IEntity,
            ITrackable,
            IDeletable,
            IHasIsActive,
            IHasDateOfBirth,
            IHasLastLogin,
            IHasFailedLoginAttempts,
            IHasIsLockedOut,
            IHasLockoutEnd,
            IHasSecurityStamp,
            IHasConcurrencyStamp,
            IHasPhoneNumber
    {
        [Required, EmailAddress]
        public override string Email { get; set; } = string.Empty;
        public bool IsAdmin { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string? ProfilePicture { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public DateTime? LastLogin { get; set; }
        public int FailedLoginAttempts { get; set; } = 0;
        public bool IsLockedOut { get; set; } = false;

        // Author-specific properties
        [MaxLength(50)]
        public string? PenName { get; set; }

        [Url]
        public string? Website { get; set; }

        [MaxLength(1500)]
        public string? Biography { get; set; }

        // Navigation properties
        public ICollection<Post> Posts { get; set; } = new List<Post>();
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
        public ICollection<MarkdownFile> AuthoredMarkdownFiles { get; set; } =
            new List<MarkdownFile>();
        public ICollection<MarkdownFile> CollaboratedMarkdownFiles { get; set; } =
            new List<MarkdownFile>();
        public ICollection<Project> OwnedProjects { get; set; } = new List<Project>();
        public ICollection<Project> ManagedProjects { get; set; } = new List<Project>();
        public ICollection<ProjectMember> ProjectMemberships { get; set; } =
            new List<ProjectMember>();
        public ICollection<MarkdownFileUser> MarkdownFileUsers { get; set; } =
            new List<MarkdownFileUser>();
        public string? Name { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? LinkUrl { get; set; }
        public Guid? UpdatedBy { get; set; }
        public Guid CreatedBy { get; set; }
        public bool? IsDeleted { get; set; } = false;
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? LockoutEnd { get; set; }
        public bool? PhoneNumberConfirmed { get; set; }
    }
}
