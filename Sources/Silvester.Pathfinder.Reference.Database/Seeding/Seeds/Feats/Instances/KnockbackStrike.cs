using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KnockbackStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("8ede3155-9bc8-4f24-9b6b-bdf442ece0e6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Knockback Strike",
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
            yield return new TextBlock { Id = Guid.Parse("9eee040f-c587-4cc5-94b3-0d4cd8557c3a"), Type = TextBlockType.Text, Text = "You focus your strength into a blow powerful enough to push an enemy away from you. Make an unarmed (action: Strike)." };
            yield return new TextBlock { Id = Guid.Parse("5b383b19-ffa5-4af0-90b5-cc98c34b616f"), Type = TextBlockType.Text, Text = "If you hit, attempt an Athletics check to (action: Shove) the target. This attack uses the same multiple attack penalty as your (action: Strike), and doesn’t count toward your multiple attack penalty." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5235dd57-8bba-40cb-a646-479dbd4691f5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
