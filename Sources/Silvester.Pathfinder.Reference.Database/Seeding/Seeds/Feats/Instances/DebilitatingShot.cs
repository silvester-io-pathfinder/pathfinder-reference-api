using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DebilitatingShot : Template
    {
        public static readonly Guid ID = Guid.Parse("558d03bd-5d06-419e-b52e-aaa26f860e10");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Debilitating Shot",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3cf1c942-725b-4628-bcc1-f8e8f9a0956d"), Type = TextBlockType.Text, Text = "Aiming for a weak point, you impede your foe with a precise shot. Make a ranged weapon (Action: Strike). If it hits and deals damage, the target is slowed 1 until the end of its next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f31322c0-5004-4b5e-b916-902fc187aa01"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
