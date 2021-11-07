using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PerfectClarity : Template
    {
        public static readonly Guid ID = Guid.Parse("4970704c-1b53-495e-a45e-06e9a9c80243");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Perfect Clarity",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You fail or critically fail an attack roll or Will save.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8a700fe4-be1d-449d-bcbd-e308eb0a653e"), Type = TextBlockType.Text, Text = "You burn out all of your rage to ensure that your attack lands and your mind remains free. Reroll the triggering attack roll or Will save with a +2 circumstance bonus, use the better result, and resolve the effect. You then immediately stop raging." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("971e3c93-3e7f-4057-80d5-03172b132d95"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
