using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FarThrow : Template
    {
        public static readonly Guid ID = Guid.Parse("34d82d9a-3f41-4daf-9dae-926f948fd169");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Far Throw",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("99525d59-5081-4a11-9930-8e0b1ee1f65f"), Type = TextBlockType.Text, Text = $"When you {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with a {ToMarkdownLink<Models.Entities.Trait>("thrown", Traits.Instances.Thrown.ID)} weapon, you take only a –1 penalty for each additional range increment between you and the target, rather than a –2 penalty." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("67b4707c-bee8-4d4d-b293-6c39805fe9ab"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
