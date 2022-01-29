using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SchoolOfPerfectionUnbreakingWaves : Template
    {
        public static readonly Guid ID = Guid.Parse("2e232e2a-5105-49ba-8899-65993a508bd6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "School of Perfection - Unbreaking Waves",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("934d903b-1f66-42f7-885e-2bc56e809036"), Type = TextBlockType.Text, Text = $"You gain the {ToMarkdownLink<Models.Entities.Spell>("unbreaking wave advance", Spells.Instances.UnbreakingWaveAdvance.ID)} ki spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c4c9ef1f-ad81-4445-9046-f8a529dc8289"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
