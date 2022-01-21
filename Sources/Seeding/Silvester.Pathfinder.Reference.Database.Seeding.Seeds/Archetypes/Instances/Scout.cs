using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Scout : Template
    {
        public static readonly Guid ID = Guid.Parse("e38502e9-5f0b-434a-bbed-07f02b1df518");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Scout",
                DedicationFeatId = Feats.Instances.ScoutDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b17f263c-5b6b-4f5b-9e28-c747d372303d"), Type = TextBlockType.Text, Text = "You�re an expert in espionage and reconnaissance, able to skulk silently through the wilderness to gather intelligence, sneak through enemy lines to report to your comrades, or suddenly and decisively strike your foes. Your skills ease the difficulty of travel for you and your companions and keep you all on guard when you�re approaching danger." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d89345cf-c9b2-4452-b230-21dedccd5658"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 188
            };
        }
    }
}
