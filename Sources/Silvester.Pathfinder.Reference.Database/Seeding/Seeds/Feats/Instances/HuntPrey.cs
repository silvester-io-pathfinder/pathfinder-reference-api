using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HuntPrey : Template
    {
        public static readonly Guid ID = Guid.Parse("dd47c4d1-455d-4877-b6bb-f622c43a6c4c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hunt Prey",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e4dbd1e7-5518-4780-bc68-20e3c87f83b7"), Type = TextBlockType.Text, Text = "You designate a single creature as your prey and focus your attacks against that creature. You must be able to see or hear the prey, or you must be (action: Tracking | Track) the prey during exploration." };
            yield return new TextBlock { Id = Guid.Parse("93e267d5-f8b2-4c68-90d0-5083c917ffce"), Type = TextBlockType.Text, Text = "You gain a +2 circumstance bonus to Perception checks when you (action: Seek) your prey and a +2 circumstance bonus to Survival checks when you (action: Track) your prey. You also ignore the penalty for making ranged attacks within your second range increment against the prey you’re hunting." };
            yield return new TextBlock { Id = Guid.Parse("7d795c81-780f-4abf-a22f-8114dcfa301d"), Type = TextBlockType.Text, Text = "You can have only one creature designated as your prey at a time. If you use Hunt Prey against a creature when you already have a creature designated, the prior creature loses the designation and the new prey gains the designation. Your designation lasts until your next daily preparations." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0bf6fa6e-fefe-462d-960b-146e959d888f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
