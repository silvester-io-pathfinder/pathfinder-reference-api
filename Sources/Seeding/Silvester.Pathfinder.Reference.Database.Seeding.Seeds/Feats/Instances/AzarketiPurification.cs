using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AzarketiPurification : Template
    {
        public static readonly Guid ID = Guid.Parse("47a72c6c-1236-4ac1-9f5d-056352d63738");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Azarketi Purification",
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
            yield return new TextBlock { Id = Guid.Parse("8fc87916-5926-4d1f-8356-7d0b7347d31a"), Type = TextBlockType.Text, Text = $"You can cast {ToMarkdownLink<Models.Entities.Spell>("purify food and drink", Spells.Instances.PurifyFoodAndDrink.ID)} as a primal innate spell, but only on liquids. You can cast this spell once every 10 minutes. You can also use your innate {ToMarkdownLink<Models.Entities.Spell>("purify food and drink", Spells.Instances.PurifyFoodAndDrink.ID)} on a touched creature instead of a liquid to purify their blood, giving that creature a +2 status bonus for 1 minute on their ongoing saves against poisons already present in their body when you cast the spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("75ea045b-3a2f-49a8-8f61-7baf8676aa91"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
