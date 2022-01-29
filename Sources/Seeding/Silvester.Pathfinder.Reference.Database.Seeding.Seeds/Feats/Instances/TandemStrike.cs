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
    public class TandemStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("b5a577bf-66e2-4ca1-94af-abdac129bacd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tandem Strike",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b77416e8-c525-4298-a7c0-b1452396e0ab"), Type = TextBlockType.Text, Text = $"You and your eidolon each attack, seamlessly targeting the same foe without interfering with each other's movements. Your eidolon makes a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, and then you make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against the same creature. Both attacks count toward your multiple attack penalty, but the penalty doesn't increase until after both attacks have been made." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("ff0dd3d7-9725-45ba-8696-1fbcafc84ce2"), Traits.Instances.Summoner.ID);
            builder.Add(Guid.Parse("ef1e7d18-125f-4715-89e3-32cff7a76097"), Traits.Instances.Tandem.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7a0e9556-9035-49c5-ad18-c34e3d007800"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
