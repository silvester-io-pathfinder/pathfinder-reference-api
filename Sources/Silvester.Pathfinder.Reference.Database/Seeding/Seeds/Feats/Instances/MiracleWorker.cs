using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MiracleWorker : Template
    {
        public static readonly Guid ID = Guid.Parse("273512b8-ca81-46bf-b02a-61af387817e6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Miracle Worker",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once every 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f3b99915-7e5e-4b52-a547-c096120ce879"), Type = TextBlockType.Text, Text = "Your alchemical mastery can resuscitate the recently slain. You can administer a (item: true elixir of life | Elixir of Life true) to a creature who has been dead for no more than 2 rounds. When you do, that creature is immediately returned to life with 1 Hit Point and becomes wounded 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("03c9c9bb-5fa5-4bbf-8950-3f3d44ea5cac"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
