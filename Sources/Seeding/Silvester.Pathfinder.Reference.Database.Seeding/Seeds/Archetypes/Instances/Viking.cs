using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Viking : Template
    {
        public static readonly Guid ID = Guid.Parse("ecf2fe51-325e-47b2-bdea-6b7a9e9e813f");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Viking",
                DedicationFeatId = Feats.Instances.VikingDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("39d69768-7627-47c0-b3cf-6825d3214661"), Type = TextBlockType.Text, Text = "To go 'a-viking' is to raid by sea, and thus vikings have spread far and wide. Some have even settled in the very communities they once raided. Vikings traditionally travel in longboats; a score of these warriors might live aboard their ship for days at a time, sailing the seas (or, as they call it, the �whale-road�) to ambush coastal communities. Once they arrive at a settlement, they charge ashore, plundering all they can find and slaying anyone foolish enough to get in their way. The ferocity of viking raids is legendary." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ddaaa8f3-e179-4673-aad8-a59b56d8a41d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 198
            };
        }
    }
}
