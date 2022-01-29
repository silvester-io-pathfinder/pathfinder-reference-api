using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OdeToOuroboros : Template
    {
        public static readonly Guid ID = Guid.Parse("ad6a0969-e277-4a52-8086-db6a9b512438");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ode to Ouroboros",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("97f8acd9-fbb9-4bf9-83c3-1b79fe2e28ef"), Type = TextBlockType.Text, Text = $"You learn the {ToMarkdownLink<Models.Entities.Feat>("ode to ouroboros", Feats.Instances.OdeToOuroboros.ID)} composition spell, which enables you to temporarily spare your allies from death." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6f776dc-df0a-4597-b650-92933b0ef90f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
