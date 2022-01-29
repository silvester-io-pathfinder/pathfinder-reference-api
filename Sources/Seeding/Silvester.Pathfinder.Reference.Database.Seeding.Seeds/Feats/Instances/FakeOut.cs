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
    public class FakeOut : Template
    {
        public static readonly Guid ID = Guid.Parse("7cdd1ae2-a8b9-4336-b8ad-f1f8246b860b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fake Out",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally is about to use an action that requires an attack roll, targeting a creature within your weapon's first range increment.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2b302bdc-1663-46db-99ef-dd9ddea91e17"), Type = TextBlockType.Text, Text = $"With a skilled flourish of your weapon, you force an enemy to acknowledge you as a threat. Make an attack roll to {ToMarkdownLink<Models.Entities.Action>("Aid", Actions.Instances.Aid.ID)} the triggering attack. If you dealt damage to that enemy with the same weapon since the start of your last turn, you gain a +1 circumstance bonus to this roll." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("55415b88-0a59-4b4c-a0fb-6b08be3ab4bc"), Traits.Instances.Gunslinger.ID);
            builder.Add(Guid.Parse("77e5ad4c-b161-45a4-a3f5-6a56bebe1f09"), Traits.Instances.Visual.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ca0b9cb0-875b-432a-b18b-9d55e02cdc31"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
