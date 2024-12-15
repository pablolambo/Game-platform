using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace VgcZeroGamePlatform.Domain.Entities
{
    public class Game
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string GameData { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public string Description { get; set; }
        public Guid DeveloperId { get; set; }
        public byte[] Icon { get; set; }

        public ApplicationUser Developer { get; set; }
    }

    public enum Genre
    {
        Action,
        Adventure,
        RPG,
        Simulation,
        Strategy
    }

    public class ApplicationUser : IdentityUser
    {
        public byte[] ProfileImage { get; set; }
        public string Address { get; set; }
        public string FirstName { get; set; }
    }
}
