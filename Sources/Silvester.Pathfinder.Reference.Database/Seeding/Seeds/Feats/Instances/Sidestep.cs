using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Sidestep : Template
    {
        public static readonly Guid ID = Guid.Parse("357cdd80-790a-4009-a031-ca501c066466");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sidestep",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "The attack roll for a Strike targeting you fails or critically fails.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a33ecee8-81b5-42d1-9540-63852ed3690b"), Type = TextBlockType.Text, Text = "You deftly step out of the way of an attack, letting the blow continue to the creature next to you. You redirect the attack to a creature of your choice that is adjacent to you and within the reach of the triggering attack. The attacker rerolls the (action: Strike’s | Strike) attack roll against the new target." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6f63f4d2-bbeb-4f9f-bd43-6525fd942de8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
