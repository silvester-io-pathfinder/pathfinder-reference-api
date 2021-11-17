using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Bard : Template
    {
        public static readonly Guid ID = Guid.Parse("2f098505-0b7d-4cb5-ba06-e973ff254ee9");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Bard",
                IsMulticlassArchetype = true,
                DedicationFeatId = Feats.Instances.BardDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("48ee2e7f-c670-4155-9af7-3e47c30c83ce"), Type = TextBlockType.Text, Text = "A muse has called you to dabble in occult lore, allowing you to cast a few spells. The deeper you delve, the more powerful your performances become." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("adc7f933-8c9e-46a6-9fe9-c744f38394f2"), Type = TextBlockType.Text, Text = "The bard archetype grants powerful effects that tend to use actions; it�s a great choice if you have actions to spare." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e4c09828-1d1c-42f7-84fb-92ffcac18b4f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 222
            };
        }
    }
}
