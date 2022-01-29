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
    public class MonasticArcherStance : Template
    {
        public static readonly Guid ID = Guid.Parse("bd893fa3-82e5-4932-a352-a09b19cea81d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Monastic Archer Stance",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "When you select this feat, you become trained in the longbow, shortbow, and any simple and martial bows with the monk trait. If you gain the expert strikes class feature, your proficiency rank for these weapons increases to expert, and if you gain the master strikes class feature, your proficiency rank for these weapons increases to master.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e4dbffff-6887-47b1-98fa-324bb032e22e"), Type = TextBlockType.Text, Text = $"You enter a specialized stance for a unique martial art centered around the use of a bow. While in this stance, the only {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} you can make are those using longbows, shortbows, or bows with the {ToMarkdownLink<Models.Entities.Trait>("monk", Traits.Instances.Monk.ID)} trait. You can use {ToMarkdownLink<Models.Entities.Feat>("Flurry of Blows", Feats.Instances.FlurryOfBlows.ID)} with these bows. You can use your other monk feats or monk abilities that normally require unarmed attacks with these bows when attacking within half the first range increment (normally 50 feet for a longbow and 30 feet for a shortbow), so long as the feat or ability doesn't require a single, specific {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dc4d5573-1281-415f-a24a-0386c89b7503"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
