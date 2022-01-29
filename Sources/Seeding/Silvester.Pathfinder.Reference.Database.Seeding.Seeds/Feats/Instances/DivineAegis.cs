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
    public class DivineAegis : Template
    {
        public static readonly Guid ID = Guid.Parse("2f7f7014-1cf3-48aa-8cb3-c5b6983fc4a7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Divine Aegis",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You attempt a saving throw against a magical effect, but you haven't rolled yet.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c50761ba-dbf4-4e46-b6e5-7d92fcfaefb5"), Type = TextBlockType.Text, Text = $"You summon divine energy to shield yourself, offering protection against other traditions but leaving you exposed to other {ToMarkdownLink<Models.Entities.Trait>("divine", Traits.Instances.Divine.ID)} effects. Until the beginning of your next turn, you gain a +1 circumstance bonus to saving throws against non-divine magical effects, but you also take a -1 circumstance penalty to saves against {ToMarkdownLink<Models.Entities.Trait>("divine", Traits.Instances.Divine.ID)} effects." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("f2ff560a-0e02-4e7a-8d67-fcc95a6842b9"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("2148dac5-ffe4-4591-9667-deee8eadaebd"), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse("f879683f-8525-4774-97f6-3f78c3f3d219"), Traits.Instances.Oracle.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4e4579db-b4c8-49bd-b845-1f0c1ef328b2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
