using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TwinShotKnockdown : Template
    {
        public static readonly Guid ID = Guid.Parse("68c654e8-c8e0-4cb8-817a-e40a94407dd1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Twin Shot Knockdown",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("55c4415d-972b-47a0-835e-76529ddc373a"), Type = TextBlockType.Text, Text = $"You fire at an enemy while targeting a part of its anatomy that will disrupt its balance. Make two {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} against the same target, one with each of the required weapons. If both {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} are successful, the target is also knocked prone." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf3f538a-043a-42c5-a981-d8eaf795a98c"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
