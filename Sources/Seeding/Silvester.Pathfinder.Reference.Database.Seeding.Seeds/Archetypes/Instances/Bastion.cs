using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Bastion : Template
    {
        public static readonly Guid ID = Guid.Parse("40ef6c0b-0b32-423a-842c-ea3785b851cf");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Bastion",
                DedicationFeatId = Feats.Instances.BastionDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e7ecab26-b703-4147-b467-3d92ff7e748f"), Type = TextBlockType.Text, Text = "Some say that a good offense is the best defense, but you find such boasting smacks of overconfidence. In your experience, the best defense is a good, solid shield between you and your enemies. you've focused your training on how best to use a shield to protect yourself and those around you." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("65979770-f2d6-42c8-b801-c429345a1527"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 159
            };
        }
    }
}
