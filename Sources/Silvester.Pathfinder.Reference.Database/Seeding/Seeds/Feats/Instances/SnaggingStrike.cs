using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SnaggingStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("84900add-0b4a-4654-87f5-e1f397ba080c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Snagging Strike",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1d55ecdb-4e65-41d7-9722-47bb00726c0a"), Type = TextBlockType.Text, Text = "You combine an attack with quick grappling moves to throw an enemy off balance as long as it stays in your reach. Make a (Action: Strike) while keeping one hand free. If this (Action: Strike) hits, the target is flat-footed until the start of your next turn or until it’s no longer within the reach of your hand, whichever comes first." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9d622846-8a84-4cee-97d9-3fdcd1d5feb2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
