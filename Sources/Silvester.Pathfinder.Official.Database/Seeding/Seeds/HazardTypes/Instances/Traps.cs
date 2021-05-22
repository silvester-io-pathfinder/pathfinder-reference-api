using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.HazardTypes.Instances
{
    public class Traps : Template
    {
        public static readonly Guid ID = Guid.Parse("db68d894-7a5a-489f-a6f5-ca45ef6986f6");

        protected override HazardType GetHazardType()
        {
            return new HazardType 
            { 
                Id = ID, 
                SourcePageId = Guid.Parse("ffe77480-d1b7-4155-9152-4bbb4a651721"), 
                Name = "Traps", 
                Description = "Traps are usually built or placed, though they can also form accidentally, such as if a magic portal, through millennia of disuse, malfunctions as its magic warps. Mechanical traps always have some physical component, whereas purely magical traps typically don’t. Magical traps can usually be counteracted by dispel magic, and those without a listed proficiency rank for Stealth can be found using detect magic. Thievery is the most common skill used to disable traps." 
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a5c9fa7a-a08c-4207-916e-d00b445fe0c5"),
                SourceId = GamemasteryGuide.ID,
                Page = 74
            }; 
        }
    }
}
