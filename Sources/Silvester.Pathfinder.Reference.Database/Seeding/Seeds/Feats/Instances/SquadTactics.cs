using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SquadTactics : Template
    {
        public static readonly Guid ID = Guid.Parse("fd55499c-44ce-42b2-833e-d3ee65c78fa2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Squad Tactics",
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
            yield return new TextBlock { Id = Guid.Parse("9ec74412-aeb3-4b39-88f3-8e331d27d9f6"), Type = TextBlockType.Text, Text = "You are adept at working with your allies to surround a foe. If an enemy is within reach of you and at least two of your allies, that enemy is flat-footed against you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b7039a87-8f2b-49ea-bbb3-cfdfd87ac9d6"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
