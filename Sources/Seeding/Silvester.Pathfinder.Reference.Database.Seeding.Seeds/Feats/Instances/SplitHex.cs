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
    public class SplitHex : Template
    {
        public static readonly Guid ID = Guid.Parse("a1d4506d-ec8a-4e2d-8275-f7e245ba6a87");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Split Hex",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("939b3ef4-b3ad-4fef-87d6-e510a032d96d"), Type = TextBlockType.Text, Text = $"You siphon some of the power from an offensive hex you cast to direct it at a second target as well. If the next action you use is to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} to cast a harmful {ToMarkdownLink<Models.Entities.Trait>("hex", Traits.Instances.Hex.ID)} with a single target, reduce its level by 2 (making it 2 levels lower than the maximum spell level you can cast). If you do, you can select a second target for that {ToMarkdownLink<Models.Entities.Trait>("hex", Traits.Instances.Hex.ID)} to affect." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d182b976-7972-4df2-aec8-a8f33721d7c3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
