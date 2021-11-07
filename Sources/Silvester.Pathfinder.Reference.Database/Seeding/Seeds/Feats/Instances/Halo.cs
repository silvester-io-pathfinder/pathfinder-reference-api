using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Halo : Template
    {
        public static readonly Guid ID = Guid.Parse("d865366a-f428-4535-8db0-9f85bf73d8f8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Halo",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("97a3ccbb-24ab-46bc-93e3-ef60b6ef50bd"), Type = TextBlockType.Text, Text = "You are surrounded by a halo of light and goodness at all times. Your halo sheds light with the effects of a divine (spell: light) cantrip. A cantrip is heightened to a spell level equal to half your level rounded up. You can suppress or reestablish the halo with a single action, which has the (trait: concentrate) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("34af3855-059a-4f8a-a31f-22c450e5c0d8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
