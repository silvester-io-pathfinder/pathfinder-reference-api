using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class TalismanDabbler : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The classic idea of magic is that of a hoary wizard, poring over a crumbling book of spells. But magic is so much more than that—it is thought, will, and action, and with the right talismans, you can make even the cut of a sword a deeply magical act. This all hinges on the small magical talismans you affix to your gear. You know how to make and use the perfect talismans for any job." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 195
            };
        }
    }
}
