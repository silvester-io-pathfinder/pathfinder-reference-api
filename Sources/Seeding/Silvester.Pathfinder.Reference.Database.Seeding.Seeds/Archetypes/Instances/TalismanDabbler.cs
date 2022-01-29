using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class TalismanDabbler : Template
    {
        public static readonly Guid ID = Guid.Parse("9ff321de-8590-4735-a04f-f4ea858bb075");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "TalismanDabbler",
                DedicationFeatId = Feats.Instances.TalismanDabblerDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("42b6cc3e-0b5b-43f0-8306-829ad3bb41ea"), Type = TextBlockType.Text, Text = "The classic idea of magic is that of a hoary wizard, poring over a crumbling book of spells. But magic is so much more than that - it is thought, will, and action, and with the right talismans, you can make even the cut of a sword a deeply magical act. This all hinges on the small magical talismans you affix to your gear. You know how to make and use the perfect talismans for any job." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d2265010-d50b-42c6-a64c-5db5361ada8b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 195
            };
        }
    }
}
