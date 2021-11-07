using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TwinFeint : Template
    {
        public static readonly Guid ID = Guid.Parse("8c7a1b21-0273-44a0-96c1-d7f47d4af662");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Twin Feint",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("69e3edb1-c474-49e6-9c0e-0cc4e025c336"), Type = TextBlockType.Text, Text = "You make a dazzling series of attacks with both weapons, using the first attack to throw your foe off guard against a second attack at a different angle. Make one (action: Strike) with each of your two melee weapons, both against the same target. The target is automatically flat-footed against the second attack. Apply your multiple attack penalty to the (action: Strikes | Strike) normally." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("258f012e-48a4-47a4-99cd-70c9ed94be02"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
