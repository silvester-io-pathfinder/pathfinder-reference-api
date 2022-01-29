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
    public class FuriousStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("505b4991-d45f-45a6-9618-008b63fb0441");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Furious Strike",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9925e1e7-5a19-44f0-9a41-dc742b72f524"), Type = TextBlockType.Text, Text = $"Your eidolon channels its anger into a furious attack. It makes a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. This counts as two attacks when calculating your multiple attack penalty. If this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} hits, your eidolon deals an extra die of weapon damage and gains a +1 circumstance bonus to the damage roll." };
            yield return new TextBlock { Id = Guid.Parse("bad048bc-8049-4161-91d3-2216f589db12"), Type = TextBlockType.Text, Text = $"If you're at least 10th level, increase this to two extra dice with a +2 circumstance bonus, and if you're at least 18th level, increase it to three extra dice with a +3 circumstance bonus." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("73842284-4463-4e50-824a-b7c353746ab2"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
