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
    public class DeadlyGrace : Template
    {
        public static readonly Guid ID = Guid.Parse("2b3096e5-afb5-471b-83c7-f3e1650a78fe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deadly Grace",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("580f35ad-b234-451b-9e38-6dc073500e78"), Type = TextBlockType.Text, Text = $"Your graceful attacks are especially powerful. When you score a critical hit with an {ToMarkdownLink<Models.Entities.Trait>("agile", Traits.Instances.Agile.ID)} or {ToMarkdownLink<Models.Entities.Trait>("finesse", Traits.Instances.Finesse.ID)} melee weapon that has the {ToMarkdownLink<Models.Entities.Trait>("deadly", Traits.Instances.Deadly.ID)} trait, you double the number of dice from that trait. When you wield an {ToMarkdownLink<Models.Entities.Trait>("agile", Traits.Instances.Agile.ID)} or {ToMarkdownLink<Models.Entities.Trait>("finesse", Traits.Instances.Finesse.ID)} melee weapon that doesn't have the {ToMarkdownLink<Models.Entities.Trait>("deadly", Traits.Instances.Deadly.ID)} trait, it gains the {ToMarkdownLink<Models.Entities.Trait>("deadly", Traits.Instances.Deadly.ID)} d8 trait instead." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("821adab2-76ae-43d5-a8e7-a47c024d3722"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
