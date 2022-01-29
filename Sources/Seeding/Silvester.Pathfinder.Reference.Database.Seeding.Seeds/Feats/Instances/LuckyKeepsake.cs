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
    public class LuckyKeepsake : Template
    {
        public static readonly Guid ID = Guid.Parse("d9967858-c50b-4c9a-a1b2-e6ec63578995");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lucky Keepsake",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("14dfa08b-df02-47ef-a54d-935bace95ec0"), Type = TextBlockType.Text, Text = $"You have a keepsake that grants you luck. You gain a +1 circumstance bonus to saves against spells and magical effects at all times, not just when you use {ToMarkdownLink<Models.Entities.Feat>("Leshy Superstition", Feats.Instances.LeshySuperstition.ID)}. If you lose the keepsake, you lose the bonus until you designate a new keepsake, typically over the course of a week." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2de9dad3-1409-4afb-b610-86c351a3609e"), Feats.Instances.LeshySuperstition.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("6440c2c3-9d2a-4df8-a405-28218833cdac"), Traits.Instances.Leshy.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bea3b7b9-31e9-4b09-a47d-7c829947abf1"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
