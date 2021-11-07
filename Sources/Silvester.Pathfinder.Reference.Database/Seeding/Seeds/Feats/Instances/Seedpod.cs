using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Seedpod : Template
    {
        public static readonly Guid ID = Guid.Parse("906aaf74-f2c5-43e8-a723-7bd95484fb42");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Seedpod",
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
            yield return new TextBlock { Id = Guid.Parse("7c998a97-bb79-4bb6-9f91-912735057a99"), Type = TextBlockType.Text, Text = "Your body produces a nearly endless supply of hard seedpods. You gain a seedpod ranged unarmed attack that deals 1d4 bludgeoning damage; these (action: Strikes | Strike) have the manipulate trait. On a critical hit, a seedpod bursts, issuing forth a tangle of vegetation that imposes a -10-foot circumstance penalty on the target’s Speed for 1 round. Seedpods do not add critical specialization effects." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1de7082a-c45f-4782-b2cc-71ef80c02c52"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
