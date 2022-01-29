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
    public class HyenaFamiliar : Template
    {
        public static readonly Guid ID = Guid.Parse("b5f91f77-b909-4bf2-9779-0bd3bced942e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hyena Familiar",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("707c2fce-90cb-4ea7-a953-ad907bb38d83"), Type = TextBlockType.Text, Text = $"Hyenas serve gnolls as pets, trackers, and in your case, vessels for spirits. You gain a Tiny hyena as a familiar." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("e0ffd5a0-1b2f-4cd2-8076-899c41908ff0"), Traits.Instances.Gnoll.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("292e3f5a-33e0-4fd5-ba90-a65bc7df90ed"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
