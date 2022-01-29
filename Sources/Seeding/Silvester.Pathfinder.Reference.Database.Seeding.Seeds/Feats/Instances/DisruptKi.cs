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
    public class DisruptKi : Template
    {
        public static readonly Guid ID = Guid.Parse("003670d4-c161-4f79-b253-5f972be3ca9e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Disrupt Ki",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f15d0232-5b6f-4b96-bf75-3a3106f11aa7"), Type = TextBlockType.Text, Text = $"Make an unarmed {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. If it deals damage to a living creature, you block that creature's inner life force. The creature takes 2d6 persistent negative damage and is enfeebled 1 until the persistent damage ends. If you're 18th level or higher, this deals 3d6 persistent negative damage instead." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("1595156c-88ea-4c84-a4d3-8e40a4ebfeaa"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("953b8338-d1d2-4e0c-9b2a-9a368ac3791f"), Traits.Instances.Negative.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1859b809-f94f-43c2-9250-9328b7e90d35"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
