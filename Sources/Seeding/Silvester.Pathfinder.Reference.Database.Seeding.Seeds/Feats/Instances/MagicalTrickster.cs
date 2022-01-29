using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagicalTrickster : Template
    {
        public static readonly Guid ID = Guid.Parse("93c0b2d8-a922-4a38-abe8-6fc8b3788e7e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magical Trickster",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("07cdf75c-3934-4d86-8ed3-3de41c7b4431"), Type = TextBlockType.Text, Text = $"Whether you're using magic items, wielding innate magic, or dabbling in spellcasting, you can sneak spells past your foes' defenses as easily as any blade. When you succeed at a spell attack roll against a flat-footed foe's AC and the spell deals damage, you can add your sneak attack damage to the damage roll. If your single spell leads to multiple separate damage rolls, apply your sneak attack damage only once per target." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("64b54bb6-b5dc-4675-a5fd-4837f3993c90"), Traits.Instances.Rogue.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8544ed68-ae36-441f-b695-334ab0164a80"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
