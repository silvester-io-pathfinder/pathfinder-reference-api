using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WellGroomed : Template
    {
        public static readonly Guid ID = Guid.Parse("4d3a4715-f9c6-415b-8bb0-e95635878d19");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Well-Groomed",
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
            yield return new TextBlock { Id = Guid.Parse("a5e46c5e-c1d4-4078-9cb6-92a9f28f1603"), Type = TextBlockType.Text, Text = "You are fastidious about keeping yourself clean, whether licking your fur or carefully using traditional catfolk hygiene products, to salubrious effect. You gain a +1 circumstance bonus to saving throws against diseases. If you roll a success on a saving throw against a disease, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("337cd900-807a-4f20-a5fd-c3d7ed4d0bee"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
