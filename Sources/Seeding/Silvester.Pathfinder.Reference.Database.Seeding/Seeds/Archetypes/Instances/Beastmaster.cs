using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Beastmaster : Template
    {
        public static readonly Guid ID = Guid.Parse("2bdbb643-a4f6-47f8-91b3-295a4b5e3fcc");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Beastmaster",
                DedicationFeatId = Feats.Instances.BeastmasterDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("39431922-979f-4de4-ad68-71846990bf61"), Type = TextBlockType.Text, Text = "You attract the loyalty of animals, and as your powers increase you can command more of them, briefly inhabit their body to perceive what they perceive, and even communicate with them over vast distances. Your animals may see you as a beloved parent, teacher, and mentor, or they may consider you a poor, defenseless cub that needs protection. Regardless, they will fight for you and alongside you, even sacrificing their lives for you if necessary." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87c1497b-3caf-4c0c-8e49-0c3e6b4e13be"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 160
            };
        }
    }
}
