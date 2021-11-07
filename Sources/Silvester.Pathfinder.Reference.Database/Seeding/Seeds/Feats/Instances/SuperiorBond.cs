using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SuperiorBond : Template
    {
        public static readonly Guid ID = Guid.Parse("f4cf71f0-a563-4928-a88c-7551ae378498");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Superior Bond",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c2fa0b26-5ac0-4d1f-9876-11299e9c825b"), Type = TextBlockType.Text, Text = "When you draw upon your bonded item, you can leave a bit of energy within it for later use. You can use (Action: Drain Bonded Item) one additional time per day, but only to cast a spell 2 or more levels lower than your highest-level spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e13d1cf3-79fc-4ba7-a3a8-0b2662f2cbe8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
