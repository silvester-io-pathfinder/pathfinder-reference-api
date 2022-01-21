using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SenseAccuracies.Instances
{
    public class Vague : Template
    {
        public static readonly Guid ID = Guid.Parse("2cbd1197-e75d-46f0-beee-47f3a10fc04a");
        
        protected override SenseAccuracy GetSenseAccuracy()
        {
            return new SenseAccuracy
            {
                Id = ID, 
                Name = "Vague",
                Description = "A character also has many vague senses�ones that can alert you that something is there but aren�t useful for zeroing in on it to determine exactly what it is. The most useful of these for a typical character is the sense of smell. At best, a vague sense can be used to detect the presence of an unnoticed creature, making it undetected. Even then, the vague sense isn�t sufficient to make the creature hidden or observed."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a101f754-2be1-4129-97c8-d18587ff2620"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 464
            };
        }
    }
}
