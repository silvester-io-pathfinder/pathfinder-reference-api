using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.HazardTypes.Instances
{
    public class Haunts : Template
    {
        public static readonly Guid ID = Guid.Parse("9d0426d4-021e-4822-a114-04840f3bb9c4");

        protected override HazardType GetHazardType()
        {
            return new HazardType 
            { 
                Id = ID, 
                SourcePageId = Guid.Parse("8419e536-0368-4dc8-ae2b-72d472a4d869"), 
                Name = "Haunts", 
                Description = "Haunts are spiritual hazards, usually formed when the spiritual essence of a location is imprinted with the instincts and emotions from a living being’s demise. Because haunts lack matter, they rarely involve a physical component, and when they do, that component is generally incorporeal or might even be damaged only by positive energy. The skills and options used to disable haunts vary, though using Religion for an exorcism is common. However, even with a successful check to disable a haunt, it can reoccur until its unfinished business is resolved. Typically, successfully disabling or enduring a haunt provides clues to determine what it would take to lay it to rest permanently." 
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dc57e77e-c622-475f-93f5-48283fcff21f"),
                SourceId = GamemasteryGuide.ID,
                Page = 74
            }; 
        }
    }
}
