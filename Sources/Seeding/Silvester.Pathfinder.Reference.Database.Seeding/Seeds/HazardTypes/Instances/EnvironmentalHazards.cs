using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HazardTypes.Instances
{
    public class EnvironmentalHazards : Template
    {
        public static readonly Guid ID = Guid.Parse("6b56b0d2-5b30-4ccf-b72c-532c244d9b73");

        protected override HazardType GetHazardType()
        {
            return new HazardType 
            { 
                Id = ID, 
                SourcePageId = Guid.Parse("3ab73fe4-1b68-42e0-8a0e-c7cc58cb5301"), 
                Name = "Environmental Hazards", 
                Description = "Environmental hazards are either living things, like dangerous spores and molds, or simply features of the terrain or environment, like avalanches or rockslides. While they are always physical, some environmental hazards can't reasonably be attacked or damaged, such as a cloud of poisonous gas or a patch of quicksand. Survival is the most common skill used to disable environmental hazards." 
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e1f4c55-f81c-4e02-a34b-170eaf519ad1"),
                SourceId = GamemasteryGuide.ID,
                Page = 74
            }; 
        }
    }
}
