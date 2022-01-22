using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FatalAria : Template
    {
        public static readonly Guid ID = Guid.Parse("209864cf-bf6e-4e48-b775-27c43454ed28");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fatal Aria",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f42f12dc-b030-44f0-9991-84d28077c95d"), Type = TextBlockType.Text, Text = $"Your songs overwhelm the target with unbearable emotion, potentially striking them dead on the spot. You learn the {ToMarkdownLink<Models.Entities.Spell>("fatal aria", Spells.Instances.FatalAria.ID)} composition spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("366506cf-b904-4915-8efa-2a6a4427e63b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
