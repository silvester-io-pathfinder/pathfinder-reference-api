using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DefendSummoner : Template
    {
        public static readonly Guid ID = Guid.Parse("563c2741-c1c8-4950-bc28-074b64a6570d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Defend Summoner",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c030c036-6bfd-41f1-8d58-cb1820f5a33c"), Type = TextBlockType.Text, Text = "Your eidolon blocks attacks against you. After your eidolon uses this action, you gain a +2 circumstance bonus to AC until the beginning of your next turn. This bonus applies only while you’re within your eidolon’s reach (in most cases, this means your eidolon is adjacent to you or in your space)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c279a32-8a5d-4fb9-a594-d718d4b08878"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
