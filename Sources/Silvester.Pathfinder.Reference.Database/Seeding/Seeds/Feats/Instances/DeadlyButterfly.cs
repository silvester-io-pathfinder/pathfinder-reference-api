using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeadlyButterfly : Template
    {
        public static readonly Guid ID = Guid.Parse("f1cfb216-a725-4968-8de4-144c6c04d18f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deadly Butterfly",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9d0d37d2-1600-4dd0-8d91-e4ddb7f6778c"), Type = TextBlockType.Text, Text = "You gain access to the (item: butterfly sword&#39;s | Butterfly Sword) critical specialization effect. If you already had access to the critical specialization effect or you gain the effect at a later time, you also gain the critical specialization effect for knives when you critically hit with a butterfly sword. You can benefit from only one critical specialization effect at a time." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("68e31e15-b728-4923-9356-c5008cdcb7ff"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
